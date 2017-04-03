using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            float k, b;
            Console.WriteLine("введите коэфицениы для первой прямой");
            k = GetDataConsole.Data();
            b = GetDataConsole.Data();
            Line First = new Line(k, b);
            k = GetDataConsole.Data();
            b = GetDataConsole.Data();
            Line Second = new Line(k, b);
            Point c = Operations.Cross(First, Second);
            Point.print(c);
           Console.ReadKey();
        }
    }
}
