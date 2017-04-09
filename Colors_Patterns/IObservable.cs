using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Colors_Patterns
{
    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers(Color color);
    }

    class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;
       
        public ConcreteObservable()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers(Color color)
        {            
            foreach (IObserver observer in observers)
                observer.Update(color);
        }
    }
}
