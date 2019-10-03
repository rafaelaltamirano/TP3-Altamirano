using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using Modelo;

namespace Controlador
{
    public class VoucherControlador
    {
       
        public bool ValidarCodigo(string cod)    
        {
        AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery( "select v.id from vouchers as v where v.codigoVoucher=@cod");
                datos.agregarParametro("cod", cod);
                datos.ejecutarLector();
                if (datos.lector.Read()) return true;
                else return false;

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
