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
        //}// hacer variante a esto en web
    
        ClienteControlador cliente = new ClienteControlador();
        private Cliente aux = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //es la mejor forma que encontre para enviar esto, consultar por otra mejor
            //int DniTeclado =Convert.ToInt32(Request.QueryString["dniTeclado"]);
            //long id = Convert.ToInt64(Request.QueryString["id"]);
            try
            {

                long id = (long)Session["idTeclado"];
                int DniTeclado = Convert.ToInt32(Session["dniTeclado"]);
                //lblPrueba.Text = DniTeclado;
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
            catch(Exception ex)         
            {
                // Response.Write("<script>alert('ex')</script>");
                throw ex;
            }

        }

        protected void Registrar_Click(object sender, EventArgs e)//modificar
        {
            //TODO: esto hacerlo bien desde su respectivo boton modificar o agregar
            //int DniTeclado = Convert.ToInt32(Request.QueryString["dniTeclado"]);
            long id= Convert.ToInt64(Request.QueryString["Id"]);
            string prueba;

            
            
                prueba = aux.Apellido;
                cliente.Modificar(aux);
            
             

                Response.Write("<script>alert('piola')</script>");
                Response.Redirect("ElegirPremio.aspx");

        

                //TODO: actualizar
            
          // validar datos o dni
          // llamar al controlador
          // si registo bien true o false 
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            aux = new Cliente();
            // traigo del form los valores ingresados o precargados y se los asigno a una variable cliente
            try
            {
                aux.Dni = Convert.ToInt32(tbDni.Text.ToString());
                aux.Nombre = tbNombre.Text.ToString();
                aux.Apellido = tbApellido.Text.ToString();
                aux.Email = this.tbEmail.Text.ToString();
                aux.Direccion = this.tbDireccion.Text.ToString();
                aux.Ciudad = this.tbCiudad.Text.ToString();
                aux.CodPostal = this.tbCodPostal.Text.ToString();

                cliente.Agregar(aux);

                Response.Redirect("Index.aspx");
            }
            catch (Exception ex)
            {
                throw ex;// tira error cerca de @fecha registroo
            }
        }
    }
}