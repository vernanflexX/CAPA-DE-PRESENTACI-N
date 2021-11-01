
namespace CAPA_DE_PRESENTACIÓN
{
    partial class Paint
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
            this.paletaColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // paletaColor
            // 
            this.paletaColor.Location = new System.Drawing.Point(241, 171);
            this.paletaColor.Name = "paletaColor";
            this.paletaColor.Size = new System.Drawing.Size(150, 50);
            this.paletaColor.TabIndex = 0;
            this.paletaColor.Text = "PALETA DE COLOR";
            this.paletaColor.UseVisualStyleBackColor = true;
            this.paletaColor.Click += new System.EventHandler(this.paletaColor_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 422);
            this.Controls.Add(this.paletaColor);
            this.Name = "Paint";
            this.Text = "Paint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button paletaColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}