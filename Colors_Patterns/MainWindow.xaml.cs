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

namespace Colors_Patterns
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConcreteObservable observable;
        TextBoxObserver textBoxObserver;
        CanvasObserver canvasObserver;

        public MainWindow()
        {
            InitializeComponent();

            observable = new ConcreteObservable();
            textBoxObserver=new TextBoxObserver(ColorTB);
            canvasObserver = new CanvasObserver(canvas);

            observable.AddObserver(textBoxObserver);
            observable.AddObserver(canvasObserver);

        }

        private void RedRB_Checked(object sender, RoutedEventArgs e)
        {
            observable.NotifyObservers(Colors.Red);
        }

        private void GreenRB_Checked(object sender, RoutedEventArgs e)
        {
            observable.NotifyObservers(Colors.Green);
        }

        private void BlueRB_Checked(object sender, RoutedEventArgs e)
        {
            observable.NotifyObservers(Colors.Blue);
        }

        private void WhiteRB_Checked(object sender, RoutedEventArgs e)
        {
            observable.NotifyObservers(Colors.White);
        }

        private void BlackRB_Checked(object sender, RoutedEventArgs e)
        {
            observable.NotifyObservers(Colors.Black);
        }
    }
}
