using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new ();
            shapes[0] = new Circles("Red", 5);
            shapes[1] = new Rectangle ("Red", new double [4,2] { { 1, 3 }, { 5, 3 }, { 1, 8 }, { 5, 8 } });
            shapes[2] = new Circles("Blue", 6);
            foreach (Shape sh in shapes)
            {
                Console.WriteLine(sh);
                sh.DrawCoordinates();
            }
        }
    }
}
