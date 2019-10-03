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
        VoucherControlador voucher = new VoucherControlador();// control . hace referencia 

        public void Page_Load(object sender, EventArgs e)
        {

            lblAux.Text = voucher.MostrarCodigo();
        }
        // evento click trae el codigo ingresado y lo guarda en la var codigo 
        protected void Button1_Click(object sender, EventArgs e)
        {
            var codigo = this.inputCodigo.Text.ToString();

            if (voucher.ValidarCodigo(codigo))
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
    
