using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Line
    {

        internal float k, b;
        public Line(float k, float b)
        {
            this.k = k;
            this.b = b;
        }

    }
    public class Point
    {
        internal float x, y;
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static void print(Point c)
        {
            if (c != null)
            {
                Console.WriteLine("Точка пересечения вот такая {0} {1}", c.x, c.y);
            }
            else
            {
                Console.WriteLine("Точек пересечения нет");
            }
        }
    }
    public class Operations
    {
        public static Point Cross(Line First, Line Second)
        {

            {

                if ((First.b == Second.b) && (Second.k == First.k))
                {
                    Console.WriteLine("Прямые наложены друг на друга");
                    var a = new Point(First.k, Second.k);
                    return a;
                }
                if (First.k != Second.k)
                {
                    float x = (Second.b - First.b) / (First.k - Second.k);
                    float y = First.k * x + First.b;
                    Point c = new Point(x, y);
                    return c;
                }
                else
                {
                    return null;
                }
            }
        }
    }
        public class GetDataConsole
        {
            public static float Data()
            {
                float x;
                try
                {
                    x = float.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("НЕВЕРНО! ПРОБУЙ СНОВА");
                    x = float.Parse(Console.ReadLine());
                }
                return x;
            }
        }
    }

