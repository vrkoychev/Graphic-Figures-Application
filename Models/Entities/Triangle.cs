﻿using CourseProject.Forms;
using System;
using System.Drawing;


namespace GraphicFiguresApp
{
    [Serializable]
    public class Triangle : Shape
    {
        public Point[] points;
    
        public override string Type => nameof(Triangle);
    
        public override void Paint(IGraphics g)
        {
            var borderedColor = Selected
                ? Color.Red
                : Color;
    
            g.DrawTriangle(borderedColor, Fill ? Color.FromArgb(100, Color) : (Color?)null, points);
        }
    
        public override bool Contains(Point p)
        {
            double l1 = (p.X - points[0].X) * (points[2].Y - points[0].Y) - (points[2].X - points[0].X) * (p.Y - points[0].Y);
            double l2 = (p.X - points[1].X) * (points[0].Y - points[1].Y) - (points[0].X - points[1].X) * (p.Y - points[1].Y);
            double l3 = (p.X - points[2].X) * (points[1].Y - points[2].Y) - (points[1].X - points[2].X) * (p.Y - points[2].Y);
    
            return (l1 >= 0 && l2 >= 0 && l3 >= 0) || (l1 <= 0 && l2 <= 0 && l3 <= 0);
        }
    
        public override bool Intersects(Rectangle rectangle)
        {
            return
                (points[0].X < rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X < points[0].X &&
                points[0].Y < rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y < points[0].Y)
                ||
                (points[1].X < rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X < points[1].X &&
                points[1].Y < rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y < points[1].Y)
                ||
                (points[2].X < rectangle.Location.X + rectangle.Width &&
                rectangle.Location.X < points[2].X &&
                points[2].Y < rectangle.Location.Y + rectangle.Height &&
                rectangle.Location.Y < points[2].Y);
        }
    
        public override double CalculateArea()
        {
            double b = Math.Sqrt(Math.Pow(Math.Abs(points[0].X - points[1].X), 2) + Math.Pow(Math.Abs(points[0].Y - points[1].Y), 2));
            double a = Math.Sqrt(Math.Pow(Math.Abs(points[1].X - points[2].X), 2) + Math.Pow(Math.Abs(points[1].Y - points[2].Y), 2));
            double c = Math.Sqrt(Math.Pow(Math.Abs(points[2].X - points[0].X), 2) + Math.Pow(Math.Abs(points[2].Y - points[0].Y), 2));
            double p = (a + b + c) / 2;
    
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double CalculatePerimeter()
        {
            double b = Math.Sqrt(Math.Pow(Math.Abs(points[0].X - points[1].X), 2) + Math.Pow(Math.Abs(points[0].Y - points[1].Y), 2));
            double a = Math.Sqrt(Math.Pow(Math.Abs(points[1].X - points[2].X), 2) + Math.Pow(Math.Abs(points[1].Y - points[2].Y), 2));
            double c = Math.Sqrt(Math.Pow(Math.Abs(points[2].X - points[0].X), 2) + Math.Pow(Math.Abs(points[2].Y - points[0].Y), 2));
            return (a + b + c) / 2;
        }
    
        public override void MoveTo(Point location)
        {
            location.Y -= (points[1].Y - points[0].Y) / 2;
        
            points[2].X += location.X - points[0].X;
            points[2].Y += location.Y - points[0].Y;
            points[1].X += location.X - points[0].X;
            points[1].Y += location.Y - points[0].Y;
            points[0].X = location.X;
            points[0].Y = location.Y;
        }

        public override void UpdateProperties(FormProperties formProperties)
        {
            var fc = formProperties as FormPropertiesTriangle;

            points[0].X = fc.AX;
            points[0].Y = fc.AY;
            points[1].X = fc.BX;
            points[1].Y = fc.BY;
            points[2].X = fc.CX;
            points[2].Y = fc.CY;
            Color = fc.Color;
        }
    }
}
