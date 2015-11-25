using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace Videoclub_proyecto
{
    public partial class ConfigUsuario : MetroFramework.Forms.MetroForm
    {
        int ID;
        Conexion con;
        public ConfigUsuario()
        {
            InitializeComponent();
            
        }
        public ConfigUsuario(int id)
        {
            InitializeComponent();
            ID = id;
            con = new Conexion("Data Source = DESKTOP-5QTHLQM\\CASTOR;" + "Initial Catalog = VideoClub ; Integrated Security = true;");
        }

        private void ConfigUsuario_Load(object sender, EventArgs e)
        {
            ObtenerDatosTrabajador();
        }

        private void mb_SubirImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                con.AbrirConexion();
                con.Query("UPDATE Trabajadores SET foto='foto/"+openFileDialog1.SafeFileName+"' where Id_Trabajador="+ID+"");
                
                string comando = "xcopy " + openFileDialog1.FileName + "  foto   /s /c /y /H ";
                //Indicamos que deseamos inicializar el proceso cmd.exe junto a un comando de arranque. 
                //(/C, le indicamos al proceso cmd que deseamos que cuando termine la tarea asignada se cierre el proceso).
                //Para mas informacion consulte la ayuda de la consola con cmd.exe /? 
                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + comando);
                // Indicamos que la salida del proceso se redireccione en un Stream
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                //Indica que el proceso no despliegue una pantalla negra (El proceso se ejecuta en background)
                procStartInfo.CreateNoWindow = false;
                //Inicializa el proceso
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                MetroMessageBox.Show(this, "Trabajador Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                proc.Close();
                MetroMessageBox.Show(this, "Foto actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                p_User.ImageLocation = @"foto/" + openFileDialog1.SafeFileName;

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al intentar actualizar la informacion del trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        private void mb_Guardar_Click(object sender, EventArgs e)
        {
            try
            { 
                con.AbrirConexion();
                con.Query("UPDATE Trabajadores SET password='" + mtb_Password.Text + "' where Id_Trabajador=" + ID + "");
                
                MetroMessageBox.Show(this, "Contraseña actualizada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al intentar actualizar la informacion del trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }

        }
        public void ObtenerDatosTrabajador()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("SELECT Nombre,ApellidoP,ApellidoM,Edad,FechaNacimiento,Direccion,Colonia,codigoPostal,Telefono,Celular,RFC,usuario,password,foto,descripcion_rol from Trabajadores inner join Rol on Trabajadores.fk_rol = Rol.Id_rol where Id_Trabajador ="+ID);
                while (reder.Read())
                {
                    mtb_Id.Text = ID.ToString();
                    mtb_Nombre.Text = reder[0].ToString();
                    mtb_ApellidoP.Text = reder[1].ToString();
                    Mtb_ApellidoM.Text = reder[2].ToString();
                    mtb_Edad.Text = reder[3].ToString();
                    md_Fecha.Text = reder[4].ToString(); 
                    mtb_Direccion.Text = reder[5].ToString();
                    mtb_Colonia.Text = reder[6].ToString();
                    mtb_CodigoP.Text = reder[7].ToString();
                    mtb_Telefono.Text = reder[8].ToString();
                    mtb_Celular.Text = reder[9].ToString();
                    mtb_RFC.Text = reder[10].ToString();
                    mtb_Usuario.Text = reder[11].ToString();
                    mtb_Password.Text = reder[12].ToString();
                    p_User.ImageLocation = reder[13].ToString();
                    mtb_Cargo.Text = reder[14].ToString();

                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Imposible cargar los datos del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            
        }
    }
}
