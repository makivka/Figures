

namespace Figures
{
    abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public abstract void Draw();
    }
}
