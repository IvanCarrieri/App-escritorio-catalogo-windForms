using Dominio;
using Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Presentación
{
    public partial class FormAgregar : Form
    {

        private OpenFileDialog archivo = null;
        public FormAgregar()
        {
            InitializeComponent();
        }

        private Articulo objArticulo = null;

        public FormAgregar(Articulo obj)
        {
            InitializeComponent();
            objArticulo = obj;

        }


        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CategoriaRegistro objCategoriaRegistro= new CategoriaRegistro();
            MarcaRegistro objMarcaRegistro= new MarcaRegistro();
            try
            {
                //cargo el combo box con las distintas categorias y marcas, de esta forma cargar para tomar del combobox un objeto y no un string

                comboBoxCategoria.DataSource = objCategoriaRegistro.listar();
                comboBoxCategoria.ValueMember = "Id";
                comboBoxCategoria.DisplayMember = "Descripcion";

                comboBoxMarca.DataSource = objMarcaRegistro.listar();
                comboBoxMarca.ValueMember = "Id";
                comboBoxMarca.DisplayMember = "Descripcion";

                if (objArticulo != null)
                {
                    textBoxCodigo.Text= objArticulo.Codigo;
                    textBoxNombre.Text= objArticulo.Nombre;
                    textBoxDescripcion.Text= objArticulo.Descripcion;
                    comboBoxCategoria.Text= objArticulo.Categoria.Descripcion.ToString();
                    comboBoxMarca.Text=objArticulo.Marca.Descripcion.ToString();
                    textBoxImagenUrl.Text= objArticulo.ImagenUrl;
                    cargarImagen(objArticulo.ImagenUrl);
                    textBoxPrecio.Text= objArticulo.Precio.ToString();

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarCampos()
        {
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxDescripcion.Text == "" || textBoxImagenUrl.Text == "" || textBoxPrecio.Text == "" || comboBoxCategoria.SelectedIndex < 0 || comboBoxMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Hay campos sin rellenar");
                return true;
            }

            if (textBoxPrecio.Text != null)
            {
                if (validarPrecio(textBoxPrecio.Text) == true)
                {
                    return true;
                }

            }

            return false;
        }

        private bool validarPrecio(string p)
        {
            decimal precio;
           

            if(decimal.TryParse(p, out precio) == false)
            {
                MessageBox.Show("Ingrese el precio de forma numérica, puede usar decimales");
                return true;
            }

            return false;
        }


        private void buttonCancelarAgregar_Click(object sender, EventArgs e)
        {
            
            Close();
        }


        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxAgregarImagen.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxAgregarImagen.Load("https://www.shutterstock.com/image-vector/webpage-search-find-icon-vector-600w-1998604469.jpg");

            }

        }

        private void buttonAceptarAgregarModificar_Click_1(object sender, EventArgs e)
        {
            ArticuloRegistro objAcceso = new ArticuloRegistro();

            try
            {
                if (validarCampos() == true)
                {
                    return;
                }
                if (objArticulo == null)
                {
                    objArticulo = new Articulo();
                }
                objArticulo.Codigo = textBoxCodigo.Text;
                objArticulo.Nombre = textBoxNombre.Text;
                objArticulo.Descripcion = textBoxDescripcion.Text;
                objArticulo.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                objArticulo.Marca = (Marca)comboBoxMarca.SelectedItem;
                objArticulo.ImagenUrl = textBoxImagenUrl.Text;
                objArticulo.Precio = decimal.Parse(textBoxPrecio.Text);


                if (objArticulo.Id != 0)
                {
                    objAcceso.modificar(objArticulo);
                    MessageBox.Show("Artículo modificado exitosamente");
                    this.Close();
                }
                else
                {
                    objAcceso.agregar(objArticulo);
                    MessageBox.Show("Artículo agregado exitosamente");
                    
                }
                if (archivo != null && !(textBoxImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    

                   File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-imagenes"] + Path.GetFileNameWithoutExtension(DateTime.Now.ToString("yMdHms") + archivo.SafeFileName) + Path.GetExtension(archivo.SafeFileName));
                }

                Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            cargarImagen(textBoxImagenUrl.Text);
        }

        private void pictureBoxVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAgregarImagen_Click(object sender, EventArgs e)
        {
             archivo = new OpenFileDialog();

            try
            {
              archivo.Filter = "png|*.png|gif|*.gif|jpg|*.jpg";
              if( archivo.ShowDialog()== DialogResult.OK)
              {
                textBoxImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                
              }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
