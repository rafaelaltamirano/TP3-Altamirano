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
    public partial class WebForm2 : System.Web.UI.Page
    {
        public ProductoControlador producto = new ProductoControlador();

        public void Page_Load(object sender, EventArgs e)
        {

           //foreach (var producto in producto.ListarProducto())
           // {

           //     Imagen1.ImageUrl = producto.Imagen;
           // }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["PremioSeleccion"] = ElegirPremio3.Text;

        }
    }
}