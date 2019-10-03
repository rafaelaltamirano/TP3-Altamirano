using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using Modelo;

namespace Controlador
{
    public class ProductoControlador
    {
        public List<Producto> ListarProducto()
        {
            Producto aux;
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select p.id,p.titulo,p.descripcion,p.UrlImagen from productos as p ");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Producto();
                    aux.Id = datos.lector.GetInt64(0);
                    aux.Titulo = datos.lector.GetString(1);
                    aux.Descripcion = datos.lector.GetString(2);
                    aux.Imagen = datos.lector.GetString(3);

                    lista.Add(aux);
                }
                return lista;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
    }
    
}
