using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;
using Modelo;

namespace VoucherWeb
{
    public partial class DatosGanador : System.Web.UI.Page
    {

        ClienteControlador cliente = new ClienteControlador();
        private Cliente aux = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                if (Page.IsPostBack == false)
                {
                    long id = (long)Session["idTeclado"];
                    int DniTeclado = Convert.ToInt32(Session["dniTeclado"]);                
                    // si el id es distinto de 0 osea es existente precargo los datos
                    if (id != 0)
                    {
                        aux = cliente.TraerCliente(DniTeclado);
                        tbApellido.Text = aux.Apellido;
                        tbNombre.Text = aux.Nombre;
                        tbDni.Text = Convert.ToString(aux.Dni);
                        tbEmail.Text = aux.Email;
                        tbDireccion.Text = aux.Direccion;
                        tbCiudad.Text = aux.Ciudad;
                        tbCodPostal.Text = aux.CodPostal;
                    }
                    else
                    {
                        tbDni.Text = Convert.ToString(DniTeclado);
                    }
                }
            }
            catch(Exception ex)         
            {
                // Response.Write("<script>alert('ex')</script>");
                throw ex;
            }

        }

      
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            aux = new Cliente();
            //long id = 
            Voucher auxVoucher = new Voucher();
            VoucherControlador voucher = new VoucherControlador();
            long id = Convert.ToInt64(Session["idTeclado"]);
            try
            {

                
                    aux.Dni = Convert.ToInt32(tbDni.Text.ToString());
                    aux.Nombre = tbNombre.Text.ToString();
                    aux.Apellido = tbApellido.Text.ToString();
                    aux.Email = this.tbEmail.Text.ToString();
                    aux.Direccion = this.tbDireccion.Text.ToString();
                    aux.Ciudad = this.tbCiudad.Text.ToString();
                    aux.CodPostal = this.tbCodPostal.Text.ToString();
              
                
                if(id != 0)// si el id tiene datos los precargo
                {
                    cliente.Modificar(aux);
                    // si esta todo bien mando un cargo o para la pagina del idex que muestra un mensaje
                    
                    // doy de baja el voucher y lo cargo a la vez
                    auxVoucher.IdCliente = id;
                    // el producto elegido es traido deelegir premio
                    auxVoucher.IdProducto = Convert.ToInt64(Session["idProductoElegido"]);
                    //cambio el estado del voucher para que ya no sea valido 
                    auxVoucher.Estado = true;
                    //DateTime myDateTime = DateTime.Now;
                    //string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    auxVoucher.FechaRegistro = DateTime.Now; ;
                    // traigo el voucher elegido desde la pesta;a de cargarCodigo.aspx
                    auxVoucher.CodigoVoucher =Convert.ToString(Session["codVoucherElegido"]);
                    voucher.CargaVoucher(auxVoucher);


                    Session.Add("cargadoOk", 1);
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    cliente.Agregar(aux);
                    Session.Add("cargadoOk", 1);
                    Response.Redirect("Index.aspx");
                }    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}