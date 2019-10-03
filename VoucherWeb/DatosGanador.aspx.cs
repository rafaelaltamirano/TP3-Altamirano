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
        //private Articul articulo = null;

        //public frmAgregarArticulo()
        //{
        //    InitializeComponent();
        //}
    
        ClienteControlador cliente = new ClienteControlador();
        private Cliente aux = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //es la mejor forma que encontre para enviar esto, consultar por otra mejor
            int DniTeclado =Convert.ToInt32(Request.QueryString["dniTeclado"]);
            long id = Convert.ToInt64(Request.QueryString["id"]);
            //lblPrueba.Text = DniTeclado;
            // si el id es distinto de 0 osea es existente precargo los datos
            if (id!=0)
            {
                aux=cliente.TraerCliente(DniTeclado);

                
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

        protected void Registrar_Click(object sender, EventArgs e)
        {
            int DniTeclado = Convert.ToInt32(Request.QueryString["dniTeclado"]);
            long id= Convert.ToInt64(Request.QueryString["Id"]);
            string prueba;

            if (id == 0)
            {
                aux = new Cliente();
                // traigo del form los valores ingresados o precargados y se los asigno a una variable cliente
                aux.Id = id;
                aux.Apellido = tbApellido.Text.ToString();
                aux.Apellido = tbApellido.Text.ToString();
               
                aux.Nombre = tbNombre.Text.ToString();
                aux.Dni = Convert.ToInt32(tbDni.Text.ToString());
                aux.Email = this.tbEmail.Text.ToString();
                aux.Direccion = this.tbDireccion.Text.ToString();
                aux.Ciudad = this.tbCiudad.Text.ToString();
                aux.CodPostal = this.tbCodPostal.Text.ToString();
            }
            else if (id > 0)
            {
                prueba = aux.Apellido;
                cliente.Modificar(aux);
            }
             

                Response.Write("<script>alert('piola')</script>");
                Response.Redirect("ElegirPremio.aspx");

        

                //TODO: actualizar
            
          // validar datos o dni
          // llamar al controlador
          // si registo bien true o false 
        }
    }
}