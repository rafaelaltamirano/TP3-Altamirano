using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Controlador
{
     public class ClienteControlador
    {
        public int ValidarDni(string dni)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente cliente = new Cliente();
            int aux=0;

            try
            {
                datos.setearQuery("select dni from clientes where dni=@dni");
                datos.agregarParametro("dni", dni);
                datos.ejecutarLector();
                if (datos.lector.Read())
                {

                    aux = datos.lector.GetInt32(0);
                }
                return aux;

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
