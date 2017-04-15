using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Memento_Pattern
{
    class RectMemento
    {
        public Rectangle rect { get; private set; }

        public RectMemento(Rectangle rect)
        {
            this.rect = rect;
        }
    }

    class RectHistory
    {
        public Stack<RectMemento> History { get; private set; }
        
        public RectHistory()
        {
            History = new Stack<RectMemento>();
        }
    }
}
