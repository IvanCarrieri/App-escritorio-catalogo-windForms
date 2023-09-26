using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Registro
{
    public class CategoriaRegistro
    {
        public List<Categoria> listar()
        {
            List<Categoria> objCategorias = new List<Categoria>();
            AccesoRegistro objAcceso = new AccesoRegistro();

            try
            {
                objAcceso.setearConsulta("select Id, Descripcion from CATEGORIAS");
                objAcceso.ejecutarLectura();

                while (objAcceso.lector.Read())
                {
                    Categoria objCategoria = new Categoria();

                    objCategoria.Id = (int)objAcceso.lector["Id"];
                    objCategoria.Descripcion = (string)objAcceso.lector["Descripcion"];

                    objCategorias.Add(objCategoria);
                }

                return objCategorias;
            }
            catch (Exception)
            {

                throw ;
            }
            finally
            {
                objAcceso.cerrarConexion();
            }
        }
    }
}

