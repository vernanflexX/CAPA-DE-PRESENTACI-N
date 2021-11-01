
namespace CAPA_DE_PRESENTACIÓN
{
    partial class MultiAPP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.editorTexto = new System.Windows.Forms.Button();
            this.paint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editorTexto
            // 
            this.editorTexto.Location = new System.Drawing.Point(88, 101);
            this.editorTexto.Name = "editorTexto";
            this.editorTexto.Size = new System.Drawing.Size(100, 100);
            this.editorTexto.TabIndex = 0;
            this.editorTexto.Text = "EDITOR DE TEXTO";
            this.editorTexto.UseVisualStyleBackColor = true;
            this.editorTexto.Click += new System.EventHandler(this.editorTexto_Click);
            // 
            // paint
            // 
            this.paint.Location = new System.Drawing.Point(256, 101);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(100, 100);
            this.paint.TabIndex = 1;
            this.paint.Text = "PAINT";
            this.paint.UseVisualStyleBackColor = true;
            this.paint.Click += new System.EventHandler(this.paint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONE LA OPCIÓN DESEADA:";
            // 
            // MultiAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paint);
            this.Controls.Add(this.editorTexto);
            this.Name = "MultiAPP";
            this.Text = "MultiAPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editorTexto;
        private System.Windows.Forms.Button paint;
        private System.Windows.Forms.Label label1;
    }
}

