using CourseProject.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicFiguresApp
{
    public partial class FormPropertiesTriangle : FormProperties
    {
        public FormPropertiesTriangle()
        {
            InitializeComponent();
        }

        private int ax;
        private int ay;
        private int bx;
        private int by;
        private int cx;
        private int cy;
        private Color color;

        public int AX
        {
            get
            {
                return ax;
            }
            set
            {
                ax = value;
                textBoxAX.Text = ax.ToString();
            }
        }

        public int AY
        {
            get
            {
                return ay;
            }
            set
            {
                ay = value;
                textBoxAY.Text = ay.ToString();
            }
        }

        public int BX
        {
            get
            {
                return bx;
            }
            set
            {
                bx = value;
                textBoxBX.Text = bx.ToString();
            }
        }

        public int BY
        {
            get
            {
                return by;
            }
            set
            {
                by = value;
                textBoxBY.Text = by.ToString();
            }
        }

        public int CX
        {
            get
            {
                return cx;
            }
            set
            {
                cx = value;
                textBoxCX.Text = cx.ToString();
            }
        }

        public int CY
        {
            get
            {
                return cy;
            }
            set
            {
                cy = value;
                textBoxCY.Text = cy.ToString();
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
            Triangle triangle = (Triangle)shape;

            AX = triangle.points[0].X;
            AY = triangle.points[0].Y;
            BX = triangle.points[1].X;
            BY = triangle.points[1].Y;
            CX = triangle.points[2].X;
            CY = triangle.points[2].Y;
            Color = triangle.Color;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAX.Text, out int ax))
            {
                this.ax = ax;
            }

            if (int.TryParse(textBoxAY.Text, out int ay))
            {
                this.ay = ay;
            }

            if (int.TryParse(textBoxBX.Text, out int bx))
            {
                this.bx = bx;
            }

            if (int.TryParse(textBoxBY.Text, out int by))
            {
                this.by = by;
            }

            if (int.TryParse(textBoxCX.Text, out int cx))
            {
                this.cx = cx;
            }

            if (int.TryParse(textBoxCY.Text, out int cy))
            {
                this.cy = cy;
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
