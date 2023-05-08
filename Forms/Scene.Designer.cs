
namespace GraphicFiguresApp
{
    partial class Scene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPerimeter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(149, 12);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(93, 21);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.TabStop = true;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(248, 11);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(70, 21);
            this.radioButtonEllipse.TabIndex = 2;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.AutoSize = true;
            this.radioButtonTriangle.Location = new System.Drawing.Point(324, 12);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(81, 21);
            this.radioButtonTriangle.TabIndex = 3;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = "Triangle";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButtonTriangle);
            this.panel1.Controls.Add(this.radioButtonRectangle);
            this.panel1.Controls.Add(this.radioButtonEllipse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1513, 40);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose shape:";
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(1105, 10);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(93, 32);
            this.buttonArea.TabIndex = 5;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1204, 10);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 32);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(1304, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(93, 32);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1403, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 32);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonPerimeter);
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.buttonArea);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1513, 54);
            this.panel2.TabIndex = 9;
            // 
            // buttonPerimeter
            // 
            this.buttonPerimeter.Location = new System.Drawing.Point(1006, 10);
            this.buttonPerimeter.Name = "buttonPerimeter";
            this.buttonPerimeter.Size = new System.Drawing.Size(93, 32);
            this.buttonPerimeter.TabIndex = 9;
            this.buttonPerimeter.Text = "Perimeter";
            this.buttonPerimeter.UseVisualStyleBackColor = true;
            this.buttonPerimeter.Click += new System.EventHandler(this.buttonPerimeter_Click);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "Scene";
            this.Text = "Scene";
            this.DoubleClick += new System.EventHandler(this.Scene_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scene_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPerimeter;
    }
}

