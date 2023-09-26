using Dominio;
using Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FormEliminar : Form
    {

        private List<Articulo> objLista;
        public FormEliminar()
        {
            InitializeComponent();
        }

        private void FormEliminar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloRegistro objArticuloRegistro = new ArticuloRegistro();

            try
            {
                objLista = objArticuloRegistro.listar();
                dataGridViewEliminar.DataSource = objLista;
                dataGridViewEliminar.Columns["Id"].Visible = false;
                dataGridViewEliminar.Columns["Descripcion"].Visible = false;
                dataGridViewEliminar.Columns["ImagenUrl"].Visible = false;
                dataGridViewEliminar.Columns["Precio"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Articulo objArticuloSeleccionado = new Articulo();
            ArticuloRegistro objR = new ArticuloRegistro();
            try
            {
                 DialogResult = MessageBox.Show("Esta seguro de eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult == DialogResult.Yes)
                {

                    objArticuloSeleccionado = (Articulo)dataGridViewEliminar.CurrentRow.DataBoundItem;
                    objR.eliminar(objArticuloSeleccionado);

                    cargar();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
