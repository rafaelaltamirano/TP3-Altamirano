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
        AccesoDatos datos = new AccesoDatos();

        public bool ValidarCodigo(string cod)    
        {
        

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

        public void CargaVoucher(Voucher voucher)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearQuery("update Vouchers set Estado=@estado,IdCliente=@idCliente,idProducto=@idProducto,FechaRegistro=@fechaReg where CodigoVoucher=@CodigoVoucher");
                datos.agregarParametro("estado", voucher.Estado);
                datos.agregarParametro("idCliente", voucher.IdCliente);
                datos.agregarParametro("idProducto", voucher.IdProducto);
                datos.agregarParametro("FechaReg", voucher.FechaRegistro);
                datos.agregarParametro("CodigoVoucher", voucher.CodigoVoucher);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
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
