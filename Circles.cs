using System;
#---

namespace Figures
{
    class Circles : Shape
    {
        public double[,] Coordinates { get; set; }
        public Circles (string color, double radius):base(color)
        {
            Coordinates =CircleCoordinates(radius);
        }
        private double[,] CircleCoordinates(double radius)
        {
         int numberOfPoints = Convert.ToInt32(radius * 2);
            double[,] coordinates = new double[numberOfPoints*2,2];
            for (int i = 0; i < numberOfPoints+1; i++)
            {
                coordinates[i, 0] = i ;
                coordinates[i, 1] = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(coordinates[i, 0]-radius, 2) )+radius;
            }
            int counter = numberOfPoints+1;
            for (int i = numberOfPoints-1; i >0 ; i--)
            {
                coordinates[counter, 0] = i;
                coordinates[counter, 1] = radius*2 -(Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(coordinates[counter, 0] - radius, 2)) + radius);
                counter++;
            }
            return coordinates;
        }
        public override void DrawCoordinates()
        {
            int rows = Coordinates.GetUpperBound(0) + 1;
            int columns = Coordinates.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{Coordinates[i, j]} ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
        public override void Draw()
        {

            double radius = Coordinates.GetUpperBound(0) / 2;
            double thickness = 0.4;
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                    Console.WriteLine();
                
            }
            
        }
    }
}
