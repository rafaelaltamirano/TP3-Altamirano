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
                Session.Add("dniTeclado", dniTeclado);
                Session.Add("idTeclado", validar[1]);
                Response.Redirect("DatosGanador.aspx");
                //Response.Redirect("DatosGanador.aspx?dniTeclad=" + dniTeclado + "&Id=" + validar[1]); esta forma pasa todo de una y redirecciona, consultar
            }
            else
            {
                // si el valor no esta solo precarga el dni
               // Response.Redirect("DatosGanador.aspx?dniTeclado=" + dniTeclado + "&Bandera=" + 0); esta forma pasa todo de una y redirecciona 
                Session.Add("dniTeclado", dniTeclado);
                validar[1] = 0;
                Session.Add("idTeclado",validar[1]);
                Response.Redirect("DatosGanador.aspx");
            }
        }
    }
}