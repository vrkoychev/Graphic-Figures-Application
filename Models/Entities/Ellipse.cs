using CourseProject.Forms;
using System;
using System.Drawing;

namespace GraphicFiguresApp
{
    [Serializable]
    public class Ellipse : Shape
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override string Type => nameof(Ellipse);

        public override void Paint(IGraphics g)
        {
            var borderedColor = Selected
                ? Color.Red
                : Color;

            g.DrawEllipse(borderedColor, Fill ? Color.FromArgb(100, Color) : (Color?)null, Location.X, Location.Y, Width, Height);
        }

        public override bool Contains(Point p)
        {
            Point center = new Point(
                Location.X + (Width / 2),
                Location.Y + (Height / 2));

            Point normalized = new Point(
                p.X - center.X,
                p.Y - center.Y);

            double xRadius = Width / 2;
            double yRadius = Height / 2;

            return ((double)normalized.X * normalized.X) / (xRadius * xRadius) +
                   ((double)normalized.Y * normalized.Y) / (yRadius * yRadius) <= 1;
        }

        public override bool Intersects(Rectangle rectangle)
        {
            return
               this.Location.X < rectangle.Location.X + rectangle.Width &&
               rectangle.Location.X < this.Location.X + this.Width &&
               this.Location.Y < rectangle.Location.Y + rectangle.Height &&
               rectangle.Location.Y < this.Location.Y + this.Height;
        }

        public override double CalculateArea() => Height * Width * Math.PI;

        public override double CalculatePerimeter() => Math.PI * 2 * Math.Sqrt((Height * Height + Width * Width) / 2);

        public override void MoveTo(Point location)
        {
            location.X -= Width / 2;
            location.Y -= Height / 2;

            Location = new Point(location.X, location.Y);
        }

        public override void UpdateProperties(FormProperties formProperties)
        {
            var fc = formProperties as FormPropertiesRectangle;

            Width = fc.Width;
            Height = fc.Height;
            Color = fc.Color;
        }
    }
}
