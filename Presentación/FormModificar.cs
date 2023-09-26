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
    public partial class FormModificar : Form
    {

        private List<Articulo> objLista;

        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormAgregarModificar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            ArticuloRegistro objArticuloRegistro = new ArticuloRegistro();

            try
            {
                objLista = objArticuloRegistro.listar();
                dataGridViewAgregarModificar.DataSource = objLista;
                dataGridViewAgregarModificar.Columns["Id"].Visible = false;
                dataGridViewAgregarModificar.Columns["Descripcion"].Visible = false;
                dataGridViewAgregarModificar.Columns["ImagenUrl"].Visible = false;
                dataGridViewAgregarModificar.Columns["Precio"].Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Articulo objArticuloSeleccionado = new Articulo();

            objArticuloSeleccionado = (Articulo)dataGridViewAgregarModificar.CurrentRow.DataBoundItem;

            FormAgregar formAgregar = new FormAgregar(objArticuloSeleccionado);
            formAgregar.ShowDialog();



        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
