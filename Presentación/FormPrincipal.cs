using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Registro;



namespace Presentación
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonListarArticulos_Click(object sender, EventArgs e)
        {
            FormLista objFormLista = new FormLista();
            objFormLista.ShowDialog();
        }

        private void buttonAgregarArticulos_Click(object sender, EventArgs e)
        {
            FormAgregar objFormAgregar = new FormAgregar();
            objFormAgregar.ShowDialog();
        }

        private void buttonModificarArticulos_Click(object sender, EventArgs e)
        {
            FormModificar objFormModificar = new FormModificar();
            objFormModificar.ShowDialog();
        }

        private void buttonEliminararticulos_Click(object sender, EventArgs e)
        {
            FormEliminar objFormEliminar = new FormEliminar();
            objFormEliminar.ShowDialog();
        }

        private void toolStripButtonQuienSoy_Click(object sender, EventArgs e)
        {
            FormNombre objForm = new FormNombre();
            objForm.ShowDialog();
        }
    }
}
