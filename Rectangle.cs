using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Shape
    {
        public double[,] Coordinates { get; set; }
        public override void Draw()
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
    }
}
