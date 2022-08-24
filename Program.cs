using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new ();
            shapes.Add ( new Circles("Red", 2));
            shapes.Add ( new Rectangle ("Red", new double [4,2] { { 1, 3 }, { 9, 3 }, { 1, 10 }, { 9, 10 } }));
            shapes.Add ( new Circles("Blue", 5));
            //foreach (Shape sh in shapes)
            // {
            //     Console.WriteLine(sh);
            //     sh.Draw();
            // }
            shapes[0].Draw();
            shapes[2].Draw();
            shapes[1].Draw();
        }
    }
}
