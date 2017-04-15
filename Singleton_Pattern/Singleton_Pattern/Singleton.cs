using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Line
    {
        public Singleton s;

        public void WriteS(string s)
        {
            this.s = Singleton.getInstance(s);
        }
    }
    
    class Singleton
    {
        public string s;

        private static Singleton instance;

        private Singleton(string s)
        {
            this.s = s;
        }

        public static Singleton getInstance(string s)
        {
            if (instance == null)
                instance = new Singleton(s);
            return instance;
        }
    }
}
