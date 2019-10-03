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
            long[] validar = new long[2];
            validar = cliente.ValidarDni(dniTeclado);
            if (validar[0]!=0)
            {
               // en caso de estar el valor en la bdlo mando a datosGanador para precargar los datos 
                Response.Redirect("DatosGanador.aspx?dniTeclado=" + dniTeclado + "&Id=" + validar[1]);
            }
            else
            {
                // si el valor no esta solo precarga el dni
                Response.Redirect("DatosGanador.aspx?dniTeclado=" + dniTeclado + "&Bandera=" + 0);
            }
        }
    }
}