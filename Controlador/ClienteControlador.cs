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
        public long[] ValidarDni(string dni)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente cliente = new Cliente();
            long []aux = new long[2];

            try
            {
                datos.setearQuery("select dni,id from clientes where dni=@dni");
                datos.agregarParametro("dni", dni);
                datos.ejecutarLector();
                if (datos.lector.Read())
                {

                   aux[0] = Convert.ToInt32(datos.lector.GetInt32(0));
                   aux[1] = Convert.ToInt64(datos.lector.GetInt64(1));

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

        public Cliente TraerCliente(int dni)
        {
            Cliente aux = new Cliente();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("select id,dni,nombre,apellido,email,direccion,ciudad,codigopostal,fecharegistro from clientes where dni=@dni");
                datos.agregarParametro("dni", dni);
                datos.ejecutarLector();
                datos.lector.Read();
                    
                aux.Id = Convert.ToInt32(datos.lector["Id"]);
                aux.Dni= dni;
                aux.Nombre=(string)datos.lector["Nombre"];                
                aux.Apellido=(string)datos.lector["Apellido"];
                aux.Email= (string)datos.lector["Email"];
                aux.Direccion = (string)datos.lector["Direccion"];
                aux.Ciudad = (string)datos.lector["Ciudad"];
                aux.CodPostal = Convert.ToString(datos.lector["CodigoPostal"]);
                aux.FechaRegistro = (DateTime)datos.lector["FechaRegistro"];
                
                
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
        // hacer agregar
        public void Modificar(Cliente Clie)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("update clientes set nombre = @nombre, apellido = @apellido, email = @email, direccion = @direccion, ciudad = @ciudad, codigoPostal = @codigoPostal where dni = dni");
                datos.agregarParametro("Id", Clie.Id);
                datos.agregarParametro("dni", Clie.Dni);
                datos.agregarParametro("nombre", Clie.Nombre);
                datos.agregarParametro("apellido", Clie.Apellido);
                datos.agregarParametro("email", Clie.Email);
                datos.agregarParametro("direccion", Clie.Direccion);
                datos.agregarParametro("ciudad", Clie.Ciudad);
                datos.agregarParametro("codigoPostal", Clie.CodPostal);

                datos.ejecutarLector();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

    }
}
