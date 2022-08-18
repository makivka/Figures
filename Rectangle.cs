using System;

namespace Figures
{
    class Rectangle : Shape
    {
        public double[,] Coordinates { get; set; }
        public Rectangle (string color, double[,] coordinates) : base(color)
        {
            Coordinates = coordinates;
        }
        public override void DrawCoordinates()
        {
            int rows = Coordinates.GetUpperBound(0) + 1;
            int columns = Coordinates.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)          //4
            {
                Console.Write("[ ");
                for (int j = 0; j < columns; j++)   //2
                {
                    Console.Write($"{Coordinates[i, j]} ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
         public override void Draw()
        {
            for (int i = Convert.ToInt32(Coordinates[0, 0]); i <= Convert.ToInt32(Coordinates[1, 0]); i++)
            {
                for (int j = Convert.ToInt32(Coordinates[0, 1]); j <= Convert.ToInt32(Coordinates[2, 1]); j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write("*");

                }
            }
        }
    }
 }
