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
        public string MostrarCodigo()
        {
            AccesoDatos datos = new AccesoDatos();
            Voucher voucher = new Voucher();
            string aux = "";

            try
            {

                
                datos.setearQuery("select v.CodigoVoucher from vouchers as v where v.codigoVoucher='D6B978405819F7291A772AD481523E90'");
                //datos.agregarParametro("cod", cod);
                datos.ejecutarLector();
                if(datos.lector.Read())
                {
                    voucher.CodigoVoucher = datos.lector.GetString(0);
                    aux = Convert.ToString(voucher.CodigoVoucher);
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
