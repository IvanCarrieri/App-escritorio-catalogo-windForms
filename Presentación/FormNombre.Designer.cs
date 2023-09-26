namespace Presentación
{
    partial class FormNombre
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
            this.labelIvan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIvan
            // 
            this.labelIvan.AutoSize = true;
            this.labelIvan.Font = new System.Drawing.Font("Lucida Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIvan.Location = new System.Drawing.Point(69, 16);
            this.labelIvan.Name = "labelIvan";
            this.labelIvan.Size = new System.Drawing.Size(110, 18);
            this.labelIvan.TabIndex = 0;
            this.labelIvan.Text = "Iván Carrieri";
            // 
            // FormNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 51);
            this.Controls.Add(this.labelIvan);
            this.Name = "FormNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Quién soy?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIvan;
    }
}