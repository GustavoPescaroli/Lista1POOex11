using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulos a;
            a = new Triangulos();

            Console.WriteLine("x");
            a.setx(double.Parse(Console.ReadLine()));
            Console.WriteLine("y");
            a.sety(double.Parse(Console.ReadLine()));
            Console.WriteLine("z");
            a.setz(double.Parse(Console.ReadLine()));
            a.calcular();
        }
    }
}
