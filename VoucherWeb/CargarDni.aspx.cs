using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
using Controlador;
namespace VoucherWeb
{
    public partial class CargarDni : System.Web.UI.Page
    {
        ClienteControlador cliente = new ClienteControlador();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDni_Click(object sender, EventArgs e)
        {
            var dniTeclado = this.inputCodigo.Text.ToString();

            if (cliente.ValidarDni(dniTeclado)!=0)
            {
                Response.Redirect("DatosGanador.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "message", "alert('No se encontraron datos');", true);

            }
        }
    }
}