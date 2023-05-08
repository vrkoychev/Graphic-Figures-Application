using CourseProject.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace GraphicFiguresApp
{
    public partial class Scene : Form, IGraphics
    {
        private List<Shape> shapes;
        private Graphics onPaintGraphics;
        private bool captureMouse;
        private Point capturelocation;
        private Shape frame;
        private Rectangle rectangleFrame;
        private bool rectangleFramePaint;

        public Scene()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer,
                     true);

            shapes = new List<Shape>();
        }

        private void DrawShape(Color borderColor, Color? fillColor, Action<Brush> fillAction, Action<Pen> drawAction)
        {
            if (onPaintGraphics != null)
            {
                if (fillColor.HasValue)
                {
                    using (var brush = new SolidBrush(fillColor.Value))
                    {
                        fillAction(brush);
                    }
                }

                using (Pen pen = new Pen(borderColor, 2))
                {
                    drawAction(pen);
                }
            }
        }

        public void DrawRectangle(Color borderColor, Color? fillColor, int x, int y, int width, int height)
        {
            DrawShape(borderColor, fillColor,
                brush => onPaintGraphics.FillRectangle(brush, x, y, width, height),
                pen => onPaintGraphics.DrawRectangle(pen, x, y, width, height));
        }

        public void DrawEllipse(Color borderColor, Color? fillColor, int x, int y, int width, int height)
        {
            DrawShape(borderColor, fillColor,
                brush => onPaintGraphics.FillEllipse(brush, x, y, width, height),
                pen => onPaintGraphics.DrawEllipse(pen, x, y, width, height));
        }

        public void DrawTriangle(Color borderColor, Color? fillColor, Point[] points)
        {
            DrawShape(borderColor, fillColor,
                brush => onPaintGraphics.FillPolygon(brush, points),
                pen => onPaintGraphics.DrawPolygon(pen, points));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            onPaintGraphics = e.Graphics;

            for (int i = shapes.Count - 1; i >= 0; i--)
            {
                shapes[i].Paint(this);
            }

            if (captureMouse && frame != null)
            {
                frame.Paint(this);
            }

            if (captureMouse && rectangleFrame != null)
            {
                rectangleFrame.Paint(this);
            }

            onPaintGraphics = null;
        }

        private void Scene_MouseDown(object sender, MouseEventArgs e)
        {
            captureMouse = true;
            capturelocation = e.Location;
            frame = null;
            rectangleFrame = null;

            foreach (var shape in shapes)
            {
                shape.Selected = false;
            }

            var selectedShapes = shapes
                .FirstOrDefault(s => s.Contains(e.Location));

            if (selectedShapes != null)
            {
                selectedShapes.Selected = true;
            }

            Invalidate();
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e)
        {
            if (!captureMouse)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                var selectedShape = shapes
                    .FirstOrDefault(s => s.Selected == true);

                if (selectedShape != null && !rectangleFramePaint)
                {
                    MoveShapes(selectedShape, e.Location);
                }
                else
                {
                    rectangleFramePaint = true;

                    rectangleFrame = CreateRectangleFrame(e.Location);
                    rectangleFrame.Fill = false;
                    rectangleFrame.Color = Color.LightGray;

                    foreach (var shape in shapes
                        .Where(s => s.Intersects(rectangleFrame)))
                    {
                        shape.Selected = true;
                    }

                    foreach (var shape in shapes
                        .Where(s => !s.Intersects(rectangleFrame)))
                    {
                        shape.Selected = false;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                frame = CreateFrame(e.Location);
                frame.Fill = false;

                frame.Color = Color.Gray;
        
            }
            Invalidate();
        }

        private void Scene_MouseUp(object sender, MouseEventArgs e)
        {
            if (!captureMouse)
            {
                return;
            }
            if (e.Button == MouseButtons.Right && frame != null)
            {
                frame.Fill = true;
                frame.Selected = true;
                var r = new Random();
                frame.Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)); 
                shapes.Insert(0, frame);
            }
            else if (e.Button == MouseButtons.Left)
            {
                rectangleFramePaint = false;
            }

            captureMouse = false;

            Invalidate();
        }

        private void MoveShapes(Shape shape, Point location)
        {
            shape.MoveTo(location);
        }

        private Rectangle CreateRectangleFrame(Point location)
        {
            Rectangle frame = new Rectangle
            {
                Location = new Point(
                    Math.Min(capturelocation.X, location.X),
                    Math.Min(capturelocation.Y, location.Y)),
                Width = Math.Abs(capturelocation.X - location.X),
                Height = Math.Abs(capturelocation.Y - location.Y)
            };

            return frame;
        }

        private Shape CreateFrame(Point location)
        {
            Shape frame;
            if (radioButtonTriangle.Checked)
            {
                if (capturelocation.X <= location.X)
                {
                    frame = new Triangle
                    {
                        points = new Point[]
                        {
                        new Point(capturelocation.X, capturelocation.Y),
                        new Point(location.X, location.Y),
                        new Point(capturelocation.X - Math.Abs(capturelocation.X - location.X), location.Y)
                        }
                    };
                }
                else
                {
                    frame = new Triangle
                    {
                        points = new Point[]
                        {
                        new Point(capturelocation.X, capturelocation.Y),
                        new Point(location.X, location.Y),
                        new Point(capturelocation.X + Math.Abs(capturelocation.X - location.X), location.Y)
                        }
                    };
                }
            }
            else if (radioButtonEllipse.Checked)
            {
                frame = new Ellipse
                {
                    Location = new Point(
                        Math.Min(capturelocation.X, location.X),
                        Math.Min(capturelocation.Y, location.Y)),
                    Width = Math.Abs(capturelocation.X - location.X),
                    Height = Math.Abs(capturelocation.Y - location.Y)
                };
            }
            else
            {
                frame = new Rectangle
                {
                    Location = new Point(
                        Math.Min(capturelocation.X, location.X),
                        Math.Min(capturelocation.Y, location.Y)),
                    Width = Math.Abs(capturelocation.X - location.X),
                    Height = Math.Abs(capturelocation.Y - location.Y)
                };
            }

            return frame;
        }
        private void DeleteSelected()
        {
            for (int i = shapes.Count - 1; i >= 0; i--)
            {
                if (shapes[i].Selected)
                {
                    shapes.RemoveAt(i);
                }
            }

            Invalidate();
        }

        private void Scene_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Delete)
            {
                return;
            }

            DeleteSelected();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void Scene_DoubleClick(object sender, EventArgs e)
        {
            var shape = shapes.FirstOrDefault(s => s.Selected);

            if (shape != null)
            {
                FormProperties formProperties = ShapeFormPropertiesFactory.CreateFormProperties(shape);
                formProperties.SetShapeProperties(shape);

                if (formProperties.ShowDialog() == DialogResult.OK)
                {
                    shape.UpdateProperties(formProperties);
                }

                Invalidate();
            }
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            var selectedShapesArea = shapes
               .Where(s => s.Selected)
               .Sum(s => s.CalculateArea());

            MessageBox.Show($"Shape Area = {selectedShapesArea:F2}", "Shape Area", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPerimeter_Click(object sender, EventArgs e)
        {
            var selectedShapesPerimeter = shapes
               .Where(s => s.Selected)
               .Sum(s => s.CalculatePerimeter());

            MessageBox.Show($"Shape perimeter = {selectedShapesPerimeter:F2}", "Shape perimeter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var formatter = new BinaryFormatter();
            var sfd = new SaveFileDialog();
            sfd.FileName = "saved_data";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    formatter.Serialize(stream, shapes);
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.FileName = "saved_data";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();

                using (var stream = new FileStream(ofd.FileName, FileMode.Open))
                {
                    shapes = (List<Shape>)formatter.Deserialize(stream);
                }
            }

            Invalidate();
        }
    }
}
