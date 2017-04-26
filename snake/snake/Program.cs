using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            //отрисовка рамки
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            VertikalLine LeftLine = new VertikalLine(0, 24, 0, '+');
            VertikalLine RightLine = new VertikalLine(0, 24, 78, '+');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 3, Direction.Right);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadLine();
        }
    }
}
