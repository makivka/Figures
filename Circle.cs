using System;


namespace Figures
{
    class Circle : Shape
    {
       //private double radius;
        public double Radius { get; set; }
        private double[,] Coordinates;
        public void CircleCoordinates()
        {
            int numberOfPoints = Convert.ToInt32(Radius * 2)+1;
            Coordinates = new double[2, numberOfPoints];
            for (int i = 0; i <= numberOfPoints - 1; i++)
            {
                Coordinates[0, i] = i - Radius;
                Console.WriteLine(Coordinates[0, i]);
            }
            for (int j = 0; j <= numberOfPoints - 1; j++)
            {
                Coordinates[1, j] = Math.Sqrt(Math.Pow(Radius,2)- Math.Pow(Coordinates[0,j], 2));
                Console.WriteLine(Coordinates[1, j]);
            }
            
        }
        public override void Draw()
        {
            CircleCoordinates();

            for (int i = 0; i <= Coordinates.Length-1; i++)
                {
                    Console.WriteLine($"[{Coordinates[0, i/2]} ,{ Coordinates[1, i/2]}]");
                }
            for (int i = Coordinates.Length - 2; i > -1; i--)
            {
                Console.WriteLine($"[{Coordinates[0, i / 2]} ,{ -Coordinates[1, i / 2]}]");
            }

        }
    }
}
