using System;


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
         int numberOfPoints = Convert.ToInt32(radius * 2)+1;
            double[,] coordinates = new double[numberOfPoints,2];
            for (int i = 0; i < numberOfPoints; i++)
            {
                coordinates[i, 0] = i - radius;
                coordinates[i, 1] = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(coordinates[i, 0], 2));
            }
            return coordinates;
        }
        public override void DrawCoordinates()
        {
           // int rows = Coordinates.GetUpperBound(0) + 1;
           // int columns = Coordinates.GetUpperBound(1) + 1;
           // for (int i = 0; i < rows; i++)
           // {
           //     Console.Write("[ ");
           //     for (int j = 0; j < columns; j++)
           //     {
           //         Console.Write($"{Coordinates[i, j]} ");
           //     }
           //     Console.Write("]");
           //     Console.WriteLine();
           // }
        }
        public override void Draw()
        {
            //for (int i = 0; i < Coordinates.GetUpperBound(0); i++)
            //{
            //   Console.SetCursorPosition(Convert.ToInt32(Coordinates[i, 0]), Convert.ToInt32(Coordinates[i, 1]));
            //   Console.Write("*"); 
            //    
            //}
        }
    }
}
