using CourseProject.Forms;
using System;
using System.Drawing;

namespace GraphicFiguresApp
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public override string Type => nameof(Rectangle);

        public override void Paint(IGraphics g)
        {
            
            var borderedColor = Selected
                ? Color.Red
                : Color;

            g.DrawRectangle(borderedColor, Fill ? Color.FromArgb(100, Color) : (Color?)null, Location.X, Location.Y, Width, Height);
        }

        public override double CalculateArea() => Width * Height;

        public override bool Contains(Point p)
        {
            return
                Location.X < p.X && p.X < Location.X + Width &&
                Location.Y < p.Y && p.Y < Location.Y + Height;
        }

        public override bool Intersects(Rectangle rectangle)
        {
            return
                this.Location.X < rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X < this.Location.X + this.Width &&
                this.Location.Y < rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y < this.Location.Y + this.Height;
        }

        public override double CalculatePerimeter() => (Width + Height) * 2;

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
