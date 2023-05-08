using System.Drawing;

namespace GraphicFiguresApp
{
    public interface IGraphics
    { 
        void DrawRectangle(Color borderColor, Color? fillColor, int x, int y, int width, int height);

        void DrawEllipse(Color borderColor, Color? fillColor, int x, int y, int width, int height);

        void DrawTriangle(Color borderColor, Color? fillColor, Point[] points);
    }
}
