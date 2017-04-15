using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //10. Создать класс Singleton используя статический метод. 
           
            Line line = new Line();
            line.WriteS("1st label");
            Console.WriteLine(line.s.s);
            Console.WriteLine();

            line.WriteS(Console.ReadLine());
            Console.WriteLine(line.s.s);

            Console.ReadKey();

        }
    }
}
