using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Circles circle1= new Circles
            { 
                Color="Red",
                Radius=5
            };
            Rectangle rectangle1 = new Rectangle
            {
                Color = "Red",
                Coordinates = new double[4,2] { { 1, 2 }, { 4, 5}, { 3, 6 }, { 7, 8 } }
            };
            Circles circle2 = new Circles
            {
                Color = "Blue",
                Radius = 6,
                Coordinates = new double[6, 2] { { 9, 9 }, { 8, 8 }, { 7, 7 }, { 6, 6 }, { 5, 5 }, { 4, 4 } }
            };
            Shape[] shapes = new Shape[3];
            shapes[0] = circle1;
            shapes[1] = rectangle1;
            shapes[2] = circle2;
            for (int i = 0; i < shapes.Length; i++)
            {
                Shape sh = shapes[i];
                Console.WriteLine(sh);
                sh.Draw();
            }
        }
    }
}
