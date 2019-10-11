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

        public Voucher ValidarCodigo(string cod)    
        {
            Voucher voucher = new Voucher();

            try
            {
                datos.setearQuery("select id,CodigoVoucher,Estado from vouchers where codigoVoucher = @cod");
                datos.agregarParametro("cod", cod);
                datos.ejecutarLector();
                if (datos.lector.Read())
                {
                    voucher.Id = datos.lector.GetInt64(0);
                    voucher.CodigoVoucher = datos.lector.GetString(1);
                    voucher.Estado = datos.lector.GetBoolean(2);
                } //TODO: Falta hacer que si el voucher ya fue usado muestre cartel o marque en rojo
                else voucher = null;
                return voucher;

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
