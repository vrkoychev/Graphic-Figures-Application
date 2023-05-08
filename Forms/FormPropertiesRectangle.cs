using CourseProject.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicFiguresApp
{
    public partial class FormPropertiesRectangle : FormProperties
    {
        public FormPropertiesRectangle()
        {
            InitializeComponent();
        }

        private int width;
        private int height;
        private Color color;

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                textBoxWidth.Text = width.ToString();
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                textBoxHeight.Text = height.ToString();
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                buttonColor.BackColor = color;
            }
        }

        public override void SetShapeProperties(Shape shape)
        {
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;

                Width = rectangle.Width;
                Height = rectangle.Height;
                Color = rectangle.Color;
            }
            else
            {
                Ellipse ellipse = (Ellipse)shape;

                Width = ellipse.Width;
                Height = ellipse.Height;
                Color = ellipse.Color;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxWidth.Text, out int width))
            {
                this.width = width;
            }

            if (int.TryParse(textBoxHeight.Text, out int height))
            {
                this.height = height;
            }
            
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Color = cd.Color;
            }
        }
    }
}
