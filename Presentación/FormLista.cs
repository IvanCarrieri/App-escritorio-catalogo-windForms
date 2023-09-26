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
    public partial class FormLista : Form
    {
        private List<Articulo> objLista;
        private List<Categoria> objlistaCategorias;
        private List<Marca> objlistaMarcas;
        public FormLista()
        {
            InitializeComponent();
        }

        private void dataGridViewLista_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLista.CurrentRow != null)
            {

                Articulo objArticulo = new Articulo();

                objArticulo = (Articulo)dataGridViewLista.CurrentRow.DataBoundItem;
                cargarImagen(objArticulo.ImagenUrl);

            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {

                pictureBoxImagen.Load(imagen);

            }
            catch (Exception)
            {

                pictureBoxImagen.Load("https://www.shutterstock.com/image-vector/webpage-search-find-icon-vector-600w-1998604469.jpg");

            }

        }

        private void cargar()
        {
            ArticuloRegistro objArticuloRegistro = new ArticuloRegistro();

            try
            {
                objLista = objArticuloRegistro.listar();
                dataGridViewLista.DataSource = objLista;
                dataGridViewLista.Columns["Id"].Visible = false;
                dataGridViewLista.Columns["ImagenUrl"].Visible = false;
                dataGridViewLista.Columns["Precio"].DefaultCellStyle.Format = "N2";
                cargarImagen(objLista[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void FormLista_Load(object sender, EventArgs e)
        {
               MarcaRegistro objMarcaRegistro = new MarcaRegistro();
               CategoriaRegistro objCategoriaRegistro = new CategoriaRegistro();

            try
            {
                cargar();

                // otra forma de cargar los combobox de categoria y Marca

                objlistaCategorias = objCategoriaRegistro.listar();
            
                foreach (var c in objlistaCategorias)
                {
                    comboBoxCategoria.Items.Add(c.ToString());
                }

            
                objlistaMarcas = objMarcaRegistro.listar();
                foreach (var m in objlistaMarcas)
                {
                    comboBoxMarca.Items.Add(m.ToString());
                }


                comboBoxPrecio.Items.Add("Mayor a");
                comboBoxPrecio.Items.Add("Menor a");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            cargar();


        }


        private bool validarFiltro()
        {
            if(comboBoxCategoria.SelectedIndex < 0 && comboBoxMarca.SelectedIndex < 0 && comboBoxPrecio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione al menos un un campo para filtrar");
                return true;
            }

            if (comboBoxPrecio.SelectedIndex >= 0)
            {
                if (validarNumeros(comboBoxPrecio.Text, textBoxBusquedaPrecio.Text) == true)
                {
                    return true;
                }
                
            }

                return false;
        }

        private bool validarNumeros(string p, string fp)
        {

            {
                if (string.IsNullOrEmpty(fp) == true)
                {
                    MessageBox.Show("Ingrese solo números, sin decimales");
                    return true;
                }

                foreach (char letra in fp)
                {
                    if (!Char.IsNumber(letra))
                    {
                        MessageBox.Show("Ingrese solo números, sin decimales");
                        return true;
                    }
                }
            }

            return false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ArticuloRegistro objArticuloRegistro = new ArticuloRegistro();
            string categoria;
            string marca;
            string precio;
            string filtroPrecio;

            try
            {
                if (validarFiltro()==true)
                {
                    return;
                }

                categoria = comboBoxCategoria.Text;
                marca = comboBoxMarca.Text;
                precio = comboBoxPrecio.Text;
                filtroPrecio = textBoxBusquedaPrecio.Text;


                dataGridViewLista.DataSource = objArticuloRegistro.filtrar(categoria, marca, precio, filtroPrecio);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo objArtSeleccionado = new Articulo();

            objArtSeleccionado = (Articulo) dataGridViewLista.CurrentRow.DataBoundItem;

            FormDetalles formDetalles = new FormDetalles(objArtSeleccionado);

            formDetalles.ShowDialog();
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReestablecer_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
    

