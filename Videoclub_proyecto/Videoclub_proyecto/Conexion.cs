using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Videoclub_proyecto
{
   public class Conexion
    {
        SqlConnection con;
        SqlCommand comando;

        public Conexion(string cadena)
        {
            con = new SqlConnection();

            con.ConnectionString = cadena;
        }
        public Conexion(string db, string server)
        {
            con = new SqlConnection();
            DatosConexion datos = new DatosConexion(db, server);
            con.ConnectionString = datos.RetornarCadenaConexion();
        }
      
        
        public void AbrirConexion()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas al conectarse a la base de datos");
            }
        }
        public void CerrarConexion()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Problemas al cerrar la conexion");
            }
        }
        public SqlDataReader obtenerConsulta(string query)
        {
            comando = con.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = query;

            return comando.ExecuteReader();

        }
        public DataTable obtenerTabla(string query)
        {

            AbrirConexion();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, con);
            System.Data.SqlClient.SqlDataAdapter reader = new System.Data.SqlClient.SqlDataAdapter(cmd);
            System.Data.DataTable dtabla = new System.Data.DataTable();
            reader.Fill(dtabla);
            CerrarConexion();
            return dtabla;


        }
        public void Query(string sentenciaSQL)
        {
            try
            {
                comando = con.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sentenciaSQL;
                comando.ExecuteNonQuery();
                comando = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al cargar el comando");
            }
        }
       
       
    }
}
