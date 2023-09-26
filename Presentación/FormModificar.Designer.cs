namespace Presentación
{
    partial class FormModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificar));
            this.dataGridViewAgregarModificar = new System.Windows.Forms.DataGridView();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.toolTipvolver = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgregarModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAgregarModificar
            // 
            this.dataGridViewAgregarModificar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAgregarModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgregarModificar.Location = new System.Drawing.Point(52, 38);
            this.dataGridViewAgregarModificar.Name = "dataGridViewAgregarModificar";
            this.dataGridViewAgregarModificar.Size = new System.Drawing.Size(336, 263);
            this.dataGridViewAgregarModificar.TabIndex = 0;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(180, 345);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(80, 28);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(358, 354);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVolver.TabIndex = 13;
            this.pictureBoxVolver.TabStop = false;
            this.toolTipvolver.SetToolTip(this.pictureBoxVolver, "Volver");
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 421);
            this.Controls.Add(this.pictureBoxVolver);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewAgregarModificar);
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar artículos";
            this.Load += new System.EventHandler(this.FormAgregarModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgregarModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAgregarModificar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.ToolTip toolTipvolver;
    }
}