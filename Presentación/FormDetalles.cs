using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FormDetalles : Form
    {

        private Articulo objArticulo;
       

        public FormDetalles (Articulo objArticulo)
        {
            InitializeComponent();
            this.objArticulo = objArticulo;
        }


        private void cargarImagen(string imagen)
        {
            try
            {

                pictureBoxDetalle.Load(imagen);

            }
            catch (Exception)
            {

                pictureBoxDetalle.Load("https://www.shutterstock.com/image-vector/webpage-search-find-icon-vector-600w-1998604469.jpg");

            }

        }

        private void FormDetalles_Load(object sender, EventArgs e)
        {
            

            try
            {
                richTextBoxDetalles.Clear();
                richTextBoxDetalles.AppendText("Código: " + objArticulo.Codigo+Environment.NewLine +"\n");
                richTextBoxDetalles.AppendText("Nombre: " + objArticulo.Nombre + Environment.NewLine + "\n");
                richTextBoxDetalles.AppendText("Descripción: " + objArticulo.Descripcion + Environment.NewLine + "\n");
                richTextBoxDetalles.AppendText("Categoría: " + objArticulo.Categoria.Descripcion + Environment.NewLine + "\n");
                richTextBoxDetalles.AppendText("Marca: " + objArticulo.Marca.Descripcion + Environment.NewLine + "\n");
                richTextBoxDetalles.AppendText("Url de la Imagen: " + objArticulo.ImagenUrl + Environment.NewLine + "\n");
                richTextBoxDetalles.AppendText("Precio: " + objArticulo.Precio.ToString("N2") + Environment.NewLine +"\n");


                cargarImagen(objArticulo.ImagenUrl);



            }
            catch (Exception)
            {

                throw;
            }


        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBoxDetalles_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
