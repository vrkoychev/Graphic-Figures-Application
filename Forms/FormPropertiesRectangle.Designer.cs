
namespace GraphicFiguresApp
{
    partial class FormPropertiesRectangle
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 150);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 15;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(12, 130);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(41, 17);
            this.labelColor.TabIndex = 14;
            this.labelColor.Text = "Color";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(15, 29);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(342, 22);
            this.textBoxWidth.TabIndex = 13;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(12, 87);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(345, 22);
            this.textBoxHeight.TabIndex = 12;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(12, 67);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(49, 17);
            this.labelHeight.TabIndex = 11;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(12, 9);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(44, 17);
            this.labelWidth.TabIndex = 10;
            this.labelWidth.Text = "Width";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(282, 234);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(192, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormPropertiesRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Name = "FormPropertiesRectangle";
            this.Text = "ShapeProperties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}