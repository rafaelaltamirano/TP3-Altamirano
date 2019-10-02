using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Controlador;

namespace VoucherWeb
{
    public partial class CargarCodigo : System.Web.UI.Page
    {
        VoucherControlador algo = new VoucherControlador();// control . hace referencia 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var codigo = this.inputCodigo.Text.ToString();

            if (algo.ValidarCodigo(codigo))
            {
                Response.Redirect("ElegirPremio.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "message", "alert('No se encontraron datos');", true);

            }
        }

    }
}
    
