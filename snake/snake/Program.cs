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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();
            
            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(1, 75, 1, '-');
            line.Drow();

            VertikalLine line2 = new VertikalLine(2, 23, 1, '|');
            line2.Drow();

            Console.ReadLine();
        }
    }
}
