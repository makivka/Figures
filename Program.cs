using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new ();
            shapes.Add ( new Circles("Red", 5));
            shapes.Add ( new Rectangle ("Red", new double [4,2] { { 1, 3 }, { 5, 3 }, { 1, 8 }, { 5, 8 } }));
            shapes.Add ( new Circles("Blue", 6));
            //foreach (Shape sh in shapes)
            // {
            //     Console.WriteLine(sh);
            //     sh.Draw();
            // }
            shapes[0].Draw();
            
        }
    }
}
