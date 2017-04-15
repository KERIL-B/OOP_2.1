using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memento_Pattern
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool mouseDown = false;

        Rectangle rect;

        RectHistory rects;

        public MainWindow()
        {
            InitializeComponent();
            rects = new RectHistory();
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseDown = true;
            rect = new Rectangle();
            rect.Fill = Brushes.White;
            rect.Stroke = Brushes.Black;
            rect.StrokeThickness = 1;
            rect.Margin = new Thickness(e.GetPosition(null).X, e.GetPosition(null).Y, 0, 0);
            rect.Width = rect.Height = 1;
            canvas.Children.Add(rect);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                rect.Width = Math.Abs(e.GetPosition(null).X - rect.Margin.Left);
                rect.Height = Math.Abs(e.GetPosition(null).Y - rect.Margin.Top);
            }
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mouseDown = false;
        }

        private void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            LastRectParametrs();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (rect != null)
                rects.History.Push(SaveState());
        }

        private RectMemento SaveState()
        {
            return new RectMemento(rect);
        }

        private void LastRectParametrs()
        {
            Rectangle oldRect=rects.History.Peek().rect;
            string parametrs = "WIDTH: " + oldRect.Width + "\n";
            parametrs += "HEIGHT: " + oldRect.Height + "\n";
            parametrs += "MARGIN:\n";
            parametrs += "    TOP: " + oldRect.Margin.Top + "\n";
            parametrs+="    LEFT: "+oldRect.Margin.Left+"\n";

            MessageBox.Show(parametrs,"Last rectangle parametrs");
        }
    }
}
