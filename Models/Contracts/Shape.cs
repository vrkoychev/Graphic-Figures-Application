using CourseProject.Forms;
using System;
using System.Drawing;

namespace GraphicFiguresApp
{
    [Serializable]
    public abstract class Shape
    {
        public Color Color { get; set; }
        public bool Fill { get; set; } = true;
        public bool Selected { get; set; }
        public abstract string Type { get; }

        public abstract void Paint(IGraphics g);
        public abstract double CalculateArea();
        public abstract bool Contains(Point p);
        public abstract bool Intersects(Rectangle rectangle);
        public abstract double CalculatePerimeter();
        public abstract void MoveTo(Point location);
        public abstract void UpdateProperties(FormProperties formProperties);
    }
}
