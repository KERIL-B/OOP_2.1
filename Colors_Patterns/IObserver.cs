using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Controls;

namespace Colors_Patterns
{
    interface IObserver
    {
        void Update(Color color);
    }

    class TextBoxObserver : IObserver
    {
       TextBox textbox;

        public TextBoxObserver(TextBox textbox)
        {
            this.textbox = textbox;
        }

        public void Update(Color color)
        {
            textbox.Text += color + ";\n";
        }
    }
    
    class CanvasObserver : IObserver
    {
        Canvas canvas;

        public CanvasObserver(Canvas canvas)
        {
            this.canvas = canvas;
        }
       
        public void Update(Color color)
        {
            canvas.Background = new SolidColorBrush(color);
        }
    }
}
