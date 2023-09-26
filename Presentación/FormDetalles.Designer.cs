namespace Presentación
{
    partial class FormDetalles
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalles));
            this.richTextBoxDetalles = new System.Windows.Forms.RichTextBox();
            this.pictureBoxDetalle = new System.Windows.Forms.PictureBox();
            this.labelDetalles = new System.Windows.Forms.Label();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.toolTipvolver = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxDetalles
            // 
            this.richTextBoxDetalles.Location = new System.Drawing.Point(63, 72);
            this.richTextBoxDetalles.Name = "richTextBoxDetalles";
            this.richTextBoxDetalles.Size = new System.Drawing.Size(324, 266);
            this.richTextBoxDetalles.TabIndex = 0;
            this.richTextBoxDetalles.Text = "";
            this.richTextBoxDetalles.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxDetalles_LinkClicked);
            // 
            // pictureBoxDetalle
            // 
            this.pictureBoxDetalle.Location = new System.Drawing.Point(415, 72);
            this.pictureBoxDetalle.Name = "pictureBoxDetalle";
            this.pictureBoxDetalle.Size = new System.Drawing.Size(307, 266);
            this.pictureBoxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetalle.TabIndex = 1;
            this.pictureBoxDetalle.TabStop = false;
            // 
            // labelDetalles
            // 
            this.labelDetalles.AutoSize = true;
            this.labelDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalles.Location = new System.Drawing.Point(319, 26);
            this.labelDetalles.Name = "labelDetalles";
            this.labelDetalles.Size = new System.Drawing.Size(146, 16);
            this.labelDetalles.TabIndex = 2;
            this.labelDetalles.Text = "Detalles del artículo";
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(667, 356);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVolver.TabIndex = 13;
            this.pictureBoxVolver.TabStop = false;
            this.toolTipvolver.SetToolTip(this.pictureBoxVolver, "Volver");
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // FormDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 423);
            this.Controls.Add(this.pictureBoxVolver);
            this.Controls.Add(this.labelDetalles);
            this.Controls.Add(this.pictureBoxDetalle);
            this.Controls.Add(this.richTextBoxDetalles);
            this.Name = "FormDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del artículo";
            this.Load += new System.EventHandler(this.FormDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDetalles;
        private System.Windows.Forms.PictureBox pictureBoxDetalle;
        private System.Windows.Forms.Label labelDetalles;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.ToolTip toolTipvolver;
    }
}