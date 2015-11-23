using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using ConexionBaseDeDatos;
using System.Data.SqlClient;
namespace Videoclub_proyecto
{
    public partial class PanelVendedor : MetroFramework.Forms.MetroForm
    {
        Conexion con;
        int Id = 34;
        public PanelVendedor()
        {
            InitializeComponent();
            con = new Conexion("VideoClub");
        }
        public PanelVendedor(int id)
        {
            InitializeComponent();
            con = new Conexion("VideoClub");
            Id = id;
        }

        private void PanelVendedor_Load(object sender, EventArgs e)
        {
            ObtenerDatosLogeado();
        }
        public void ObtenerDatosLogeado()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("SELECT Nombre,ApellidoP,ApellidoM,foto From Trabajadores Where Id_Trabajador="+Id);
                while (reder.Read())
                {
                    p_User.ImageLocation = reder[3].ToString();
                    ml_Nombre.Text = reder[0].ToString()+ " "+ reder[1].ToString()+ " "+ reder[2].ToString(); ;
                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this,"Error al cargar los datos del usuario","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
