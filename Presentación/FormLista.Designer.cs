namespace Presentación
{
    partial class FormLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLista));
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBusquedaPrecio = new System.Windows.Forms.TextBox();
            this.buttonVerDetalle = new System.Windows.Forms.Button();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.buttonReestablecer = new System.Windows.Forms.Button();
            this.toolTipvolver = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewLista.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Location = new System.Drawing.Point(12, 290);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLista.Size = new System.Drawing.Size(490, 267);
            this.dataGridViewLista.TabIndex = 0;
            this.dataGridViewLista.SelectionChanged += new System.EventHandler(this.dataGridViewLista_SelectionChanged);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Location = new System.Drawing.Point(528, 290);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(294, 267);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(122, 73);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 2;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(122, 131);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMarca.TabIndex = 3;
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Location = new System.Drawing.Point(122, 187);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrecio.TabIndex = 4;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(51, 76);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(52, 13);
            this.labelCategoria.TabIndex = 5;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(51, 134);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 6;
            this.labelMarca.Text = "Marca";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(51, 190);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 7;
            this.labelPrecio.Text = "Precio";
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrar.Location = new System.Drawing.Point(140, 26);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(50, 20);
            this.labelFiltrar.TabIndex = 8;
            this.labelFiltrar.Text = "Filtro";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonBuscar.Location = new System.Drawing.Point(76, 240);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(80, 28);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBusquedaPrecio
            // 
            this.textBoxBusquedaPrecio.Location = new System.Drawing.Point(265, 188);
            this.textBoxBusquedaPrecio.Name = "textBoxBusquedaPrecio";
            this.textBoxBusquedaPrecio.Size = new System.Drawing.Size(73, 20);
            this.textBoxBusquedaPrecio.TabIndex = 10;
            // 
            // buttonVerDetalle
            // 
            this.buttonVerDetalle.Location = new System.Drawing.Point(54, 592);
            this.buttonVerDetalle.Name = "buttonVerDetalle";
            this.buttonVerDetalle.Size = new System.Drawing.Size(80, 28);
            this.buttonVerDetalle.TabIndex = 11;
            this.buttonVerDetalle.Text = "Ver detalle";
            this.buttonVerDetalle.UseVisualStyleBackColor = true;
            this.buttonVerDetalle.Click += new System.EventHandler(this.buttonVerDetalle_Click);
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(767, 569);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVolver.TabIndex = 12;
            this.pictureBoxVolver.TabStop = false;
            this.toolTipvolver.SetToolTip(this.pictureBoxVolver, "Volver");
            this.pictureBoxVolver.Click += new System.EventHandler(this.pictureBoxVolver_Click);
            // 
            // buttonReestablecer
            // 
            this.buttonReestablecer.Location = new System.Drawing.Point(196, 240);
            this.buttonReestablecer.Name = "buttonReestablecer";
            this.buttonReestablecer.Size = new System.Drawing.Size(80, 28);
            this.buttonReestablecer.TabIndex = 13;
            this.buttonReestablecer.Text = "Mostrar todos";
            this.buttonReestablecer.UseVisualStyleBackColor = true;
            this.buttonReestablecer.Click += new System.EventHandler(this.buttonReestablecer_Click);
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 636);
            this.Controls.Add(this.buttonReestablecer);
            this.Controls.Add(this.pictureBoxVolver);
            this.Controls.Add(this.buttonVerDetalle);
            this.Controls.Add(this.textBoxBusquedaPrecio);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.dataGridViewLista);
            this.Name = "FormLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de artículos";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBusquedaPrecio;
        private System.Windows.Forms.Button buttonVerDetalle;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Button buttonReestablecer;
        private System.Windows.Forms.ToolTip toolTipvolver;
    }
}