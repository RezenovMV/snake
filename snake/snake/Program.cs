using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            func1(x);
            Console.WriteLine("Координаты Х func1: " + x);

            x = 1;
            func2(x);
            Console.WriteLine("Координаты Х func2: " + x);

            x = 1;
            func3(x);
            Console.WriteLine("Координаты Х func3: " + x);

            Point p1 = new Point(1, 3, '*');
            move(p1, 10, 10);
            Console.WriteLine("Координаты p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2, p1.x = " + p1.x + ", p1.y = " + p1.y + ", p2.x = " + p2.x + ", p2.y = " + p2.y);

            p1 = new Point(1, 3, '*');
            Console.WriteLine("Координаты p1.x = " + p1.x + ", p1.y = " + p1.y);

            Console.ReadLine();
        }

        public static void func1(int value)
        {
        }
        public static void func2(int value)
        {
            value += 1;
        }
        public static void func3(int x)
        {
            x += 1;
        }
        public static void move(Point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }
    }
}
