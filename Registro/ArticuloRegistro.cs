using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;


namespace Registro
{
     public class ArticuloRegistro
     {
         public List<Articulo> listar()
         {
             List<Articulo> objLista = new List<Articulo>();
             AccesoRegistro objAcceso = new AccesoRegistro();

             try
             { 
                 objAcceso.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where M.Id = A.IdMarca and C.Id = A.IdCategoria");
                 objAcceso.ejecutarLectura();

                 while (objAcceso.lector.Read())
                 {
                     Articulo objArticulo = new Articulo();

                     objArticulo.Id = (int)objAcceso.lector["Id"];
                     objArticulo.Codigo = (string)objAcceso.lector["Codigo"];
                     objArticulo.Nombre = (string)objAcceso.lector["Nombre"];
                     objArticulo.Descripcion = (string)objAcceso.lector["Descripcion"];

                     objArticulo.Marca = new Marca();
                     objArticulo.Marca.Descripcion = (string)objAcceso.lector["Marca"];

                     objArticulo.Categoria = new Categoria();
                     objArticulo.Categoria.Descripcion = (string)objAcceso.lector["Categoria"];

                     if (objAcceso.lector["ImagenUrl"] != DBNull.Value)
                     {
                         objArticulo.ImagenUrl = (string)objAcceso.lector["ImagenUrl"];
                     }

                     objArticulo.Precio = (decimal)objAcceso.lector["Precio"];

                     objLista.Add(objArticulo);

                 }

                 return objLista;

             }
             catch (Exception ex)
             { 

                 throw ex;
             }
             finally
             {
                 objAcceso.cerrarConexion();
             }


         }

         public List<Articulo> filtrar(string cat, string mar,string pre, string num)

         {
             List<Articulo> objListaFiltrada = new List<Articulo>();
             AccesoRegistro objAcceso = new AccesoRegistro();
             string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where M.Id = A.IdMarca and C.Id = A.IdCategoria and ";
             string consultaC = "A.IdCategoria = ";
             string consultaM = "A.IdMarca = ";
             string precio = " ";

             try
             {
                 switch(cat)
                 {
                     case "Celulares":
                         consultaC += "1";
                         break;
                     case "Televisores":
                         consultaC += "2";
                         break;
                     case "Media":
                         consultaC += "3";
                         break;
                     case "Audio":
                         consultaC += "4";
                         break;
                    default:
                        break;
                 }



                 switch(mar)
                 {
                     case "Samsung":
                         consultaM += "1";
                         break;
                     case "Apple":
                         consultaM += "2";
                         break;
                     case "Sony":
                         consultaM += "3";
                         break;
                     case "Huawei":
                        consultaM += "4";
                         break;
                     case "Motorola":
                         consultaM += "5";
                         break;
                    default:
                        break;
                 }

                 switch (pre)
                 {
                     case "Mayor a":
                         precio += "Precio > " + num;
                         break;
                     case "Menor a":
                         precio += "Precio < " + num;
                         break;
                    default:
                        break;
                 }

                if((string.IsNullOrEmpty(cat)==false) && (string.IsNullOrEmpty(mar)==false) && (string.IsNullOrEmpty(pre)==false))
                 {

                      objAcceso.setearConsulta(consulta += consultaC + " and " + consultaM  + " and" + precio);

                 }
                 if ((string.IsNullOrEmpty(cat) == true) && (string.IsNullOrEmpty(mar) == true) && (string.IsNullOrEmpty(pre) == false))
                 {

                     objAcceso.setearConsulta(consulta += precio);

                 }
                 if ((string.IsNullOrEmpty(cat) == false) && (string.IsNullOrEmpty(mar) == false) && (string.IsNullOrEmpty(pre) == true))
                 {

                     objAcceso.setearConsulta(consulta += consultaC + " and " + consultaM);

                 }
                 if ((string.IsNullOrEmpty(cat) == false) && (string.IsNullOrEmpty(mar) == true) && (string.IsNullOrEmpty(pre) == true))
                 {

                     objAcceso.setearConsulta(consulta += consultaC);
                 }
                 if ((string.IsNullOrEmpty(cat) == true) && (string.IsNullOrEmpty(mar) == false)  && (string.IsNullOrEmpty(pre) == true))
                 {

                     objAcceso.setearConsulta(consulta += consultaM);
                 }
                 if ((string.IsNullOrEmpty(cat) == true) && (string.IsNullOrEmpty(mar) == false) && (string.IsNullOrEmpty(pre) == false))
                 {

                     objAcceso.setearConsulta(consulta += consultaM + " and" + precio);
                 }
                 if ((string.IsNullOrEmpty(cat) == false) && (string.IsNullOrEmpty(mar) == true) && (string.IsNullOrEmpty(pre) == false))
                 {

                     objAcceso.setearConsulta(consulta += consultaC + " and" + precio);
                 }
               
       

                objAcceso.setearConsulta(consulta);
                objAcceso.ejecutarLectura();

                while (objAcceso.lector.Read())
                 {
                     Articulo objArticulo = new Articulo();

                     objArticulo.Id = (int)objAcceso.lector["Id"];
                     objArticulo.Codigo = (string)objAcceso.lector["Codigo"];
                     objArticulo.Nombre = (string)objAcceso.lector["Nombre"];
                     objArticulo.Descripcion = (string)objAcceso.lector["Descripcion"];

                     objArticulo.Marca = new Marca();
                     objArticulo.Marca.Descripcion = (string)objAcceso.lector["Marca"];

                     objArticulo.Categoria = new Categoria();
                     objArticulo.Categoria.Descripcion = (string)objAcceso.lector["Categoria"];

                     if (objAcceso.lector["ImagenUrl"] != DBNull.Value)
                     {
                         objArticulo.ImagenUrl = (string)objAcceso.lector["ImagenUrl"];
                     }

                     objArticulo.Precio = (decimal)objAcceso.lector["Precio"];


                     objListaFiltrada.Add(objArticulo);
                 }

                 return objListaFiltrada;
             }
             catch (Exception ex)
             {

                 throw ex;
             }
             finally
             {
                 objAcceso.cerrarConexion();
             }
         }

         public void agregar (Articulo obj)
         {

             AccesoRegistro objAcceso = new AccesoRegistro();
             try
             {
                 objAcceso.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @IdMarca, @ImagenUrl, @Precio)");
                 objAcceso.setearParametros("@Codigo",obj.Codigo);
                 objAcceso.setearParametros("@Nombre", obj.Nombre);
                 objAcceso.setearParametros("@Descripcion", obj.Descripcion);
                 objAcceso.setearParametros("@IdCategoria", obj.Categoria.Id);
                 objAcceso.setearParametros("@IdMarca", obj.Marca.Id);
                 objAcceso.setearParametros("@ImagenUrl", obj.ImagenUrl);
                 objAcceso.setearParametros("@Precio", obj.Precio);

                 objAcceso.ejecutarAccion();
             }
             catch (Exception)
             {

                 throw;
             }
             finally
             {
                 objAcceso.cerrarConexion();
             }
         }

         public void modificar (Articulo obj)
         {
             AccesoRegistro objAcceso = new AccesoRegistro();
             try
             {
                 objAcceso.setearConsulta("update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdCategoria=@IdCategoria, IdMarca=@IdMarca, ImagenUrl=@ImagenUrl, Precio=@Precio where Id=@Id");
                 objAcceso.setearParametros("@Codigo", obj.Codigo);
                 objAcceso.setearParametros("@Nombre", obj.Nombre);
                 objAcceso.setearParametros("@Descripcion", obj.Descripcion);
                 objAcceso.setearParametros("@IdCategoria", obj.Categoria.Id);
                 objAcceso.setearParametros("@IdMarca", obj.Marca.Id);
                 objAcceso.setearParametros("@ImagenUrl", obj.ImagenUrl);
                 objAcceso.setearParametros("@Precio", obj.Precio);
                 objAcceso.setearParametros("@Id", obj.Id);

                 objAcceso.ejecutarAccion();
             }
             catch (Exception)
             {

                 throw;
             }
             finally
             {
                 objAcceso.cerrarConexion();
             }
         }

         public void eliminar(Articulo obj)
         {
             AccesoRegistro objAccesoRegistro = new AccesoRegistro();

             try
             {
                 objAccesoRegistro.setearConsulta("delete from ARTICULOS where Id=@Id");
                 objAccesoRegistro.setearParametros("@Id", obj.Id);
                 objAccesoRegistro.ejecutarAccion();
             }
             catch (Exception)
             {

                 throw;
             }
             finally
             {
                 objAccesoRegistro.cerrarConexion();
             }
         }   
     } 
 }

  