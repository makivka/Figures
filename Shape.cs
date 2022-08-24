

namespace Figures
{
    abstract class Shape
    {
        public string Color { get; set; }
        public Shape(string color)
        {
            Color = color;
        }
        public abstract void Draw();
        public abstract void DrawCoordinates();
    }
}
