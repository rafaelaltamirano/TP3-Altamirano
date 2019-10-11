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

    public partial class CargarCodigo : System.Web.UI.Page
    {
        public Voucher voucher;
        VoucherControlador voucherControlador = new VoucherControlador();// control . hace referencia 

        // evento click trae el codigo ingresado y lo guarda en la var codigo 
        protected void Button1_Click(object sender, EventArgs e)
        {
            var codigo = this.inputCodigo.Text.ToString();
            voucher = voucherControlador.ValidarCodigo(codigo);
            if (voucher == null)// no existe
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "message", "alert('El voucher ingresado no existe o es incorrecto');", true);
            }
            else if(voucher.Estado == false)//esta para usar, existe en la bd esta disponible
            {
                Session.Add("codVoucherElegido", codigo);
                Response.Redirect("ElegirPremio.aspx");
            }
            else if(voucher.Estado == true)// ya fue usado
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "message", "alert('El voucher ya fue usado, ingrese otro voucher');", true);
            }
        }

    }
}
    
