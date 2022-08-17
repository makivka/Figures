using System;


namespace Figures
{
    class Circles : Shape
    {
        public double Radius { get; set; }
        public double[,] Coordinates { get; set; }
        public void CircleCoordinates()
        {
            int numberOfPoints = Convert.ToInt32(Radius * 2)+1;
            Coordinates = new double[numberOfPoints,2];
            for (int i = 0; i <= numberOfPoints - 1; i++)
            {
                Coordinates[i, 0] = i - Radius;
                Coordinates[i, 1] = Math.Sqrt(Math.Pow(Radius, 2) - Math.Pow(Coordinates[i, 0], 2));
            }
        }
        public override void Draw()
        {
            if (Coordinates == null) { CircleCoordinates(); }

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
    }
}
