using GraphicFiguresApp;
using System;

namespace CourseProject.Forms
{
    public class ShapeFormPropertiesFactory
    {
        public static FormProperties CreateFormProperties(Shape shape)
        {
            if (shape is Triangle)
            {
                return new FormPropertiesTriangle();
            }
            else if (shape is Rectangle || shape is Ellipse)
            {
                return new FormPropertiesRectangle();
            }
            else
            {
                throw new NotSupportedException($"Unsupported shape type: {shape.Type}");
            }
        }
    }

}
