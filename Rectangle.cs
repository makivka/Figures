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

            int x1 = Convert.ToInt32(Coordinates[0, 0]);
            int x2 = Convert.ToInt32(Coordinates[1, 0]);
            int y1 = Convert.ToInt32(Coordinates[0, 1]);
            int y2 = Convert.ToInt32(Coordinates[2, 1]);

            int numberX = x2-x1;
            int numberY = y2 - y1;
            for (int i = 0; i <= numberY; i++)
            {
                if (i == 0 || i == numberY)
                {
                    for (int j = 0; j < numberX; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 1 && i <= numberY-1)
                {
                    for (int j = 0; j <= numberX; j++)
                    {
                        if (j == 0 || j == numberX)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= numberX-1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            
        }
           
            


        
    }
 }
