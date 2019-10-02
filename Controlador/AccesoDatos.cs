using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controlador
{
    public class AccesoDatos
    {
        //establezco la conexion
        public SqlDataReader lector { get; set; }// donde se guardara el resultado de la consulta
        public SqlConnection cn { get; set; }
        public SqlCommand cm { get; set; }

        public AccesoDatos()
        {// initial catalgo es el nombre de la bd
            //inicializar la conexion
            cn = new SqlConnection("Data source=desktop-evqhp8a\\sqlexpress; initial catalog=TP_WEB;integrated security=sspi");
            cm = new SqlCommand();
            cm.Connection = cn;
        }


        //metodo para setear la consulta
        public void setearQuery(string consulta)
        {
            cm.CommandType = System.Data.CommandType.Text;
            // cargo la consulta enviada por parametro
            cm.CommandText = consulta;
        }

        public void agregarParametro(string nombre, object valor)
        {
            cm.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarLector()
        {

            try
            {
                //abro coneccion
                cn.Open();
                lector = cm.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //cn.Close();
            }
           
        }
        public void cerrarConexion()
        {
            cn.Close();

        }
    }
}
