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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //Establese una instancia a la clase de conexion a la base de datos
        Conexion con;
       
        public Form1()
        {
            InitializeComponent();
            //Selecciona la base de datos VideoClub
            con = new Conexion("VideoClub");
        }
        //Variable que servira para ocultar el texbox de mostrar contraseña
        bool pasVidible = false;
        private void mtl_eye_Click(object sender, EventArgs e)
        {
            // si la variable de ocultar es falsa
            if (pasVidible == false)
            {
                //mostrara el texbox oculto y le asicnaremos el texto del texbox  password para mostrarlo ensima del texbox del password
                mtb_passwordVisible.Visible = true;
                mtb_passwordVisible.Text = mtb_password.Text;
                pasVidible = true;
            }
            else
            {
                //De lo contrario ocultara este texbox y lo limpiara
                mtb_passwordVisible.Visible = false;
                mtb_password.Text = mtb_passwordVisible.Text;
                pasVidible = false;
            }
        }
        //boton que limpiara los textbox
        private void mtb_borrar_Click(object sender, EventArgs e)
        {
            mtb_usuario.Clear();
            mtb_password.Text = string.Empty;
            mtb_passwordVisible.Text = string.Empty;
        }
        //boton de iniciar seccion
        private void mtb_ingresar_Click(object sender, EventArgs e)
        {
            PanelAdmin(IngresarAlSistema());
        }
        #region IniciarPanelAdministrador
        int ban;
        public int IngresarAlSistema()
        {
          
            //captura algun error que se produsca al momento de realizar la conexion a la base de datos
            try
            {
                //Abre una nueva conexion
                con.AbrirConexion();
                SqlDataReader reader;
                //Obtine los datos procedientes de la consulta sql
                if (mtb_passwordVisible.Visible == false)
                {
                    reader = con.obtenerConsulta("select COUNT(usuario) from Trabajadores where usuario='" + mtb_usuario.Text + "' and password='" + mtb_password.Text + "'");
                }
                else
                {
                     reader = con.obtenerConsulta("select COUNT(usuario) from Trabajadores where usuario='" + mtb_usuario.Text + "' and password='" + mtb_passwordVisible.Text + "'");
                }
                //Sentencia que retorna un valor booleano si hay datos por mostrar
                if (reader.Read())
                {
                    //si elvalor obtenido y evaluado es uno abrira el panel del administrador
                    if (reader[0].ToString() == "1")
                    {

                        ban = 1;
                    }
                    //de lo contrario mostrara un mensaje de error de inicio de session
                    else if (reader[0].ToString() == "0")
                    {
                        MetroMessageBox.Show(this,"Usuario o contraseña incorrectos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        ban = 0;
                    }
                }

            }
            //mostrara un mensaje de error al conectarse a la base de datos
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Problemas en la conexion a la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtb_usuario.Clear();
                mtb_password.Clear();
            }
            //cerrara la conexion a la base de datos
            finally
            {
                con.CerrarConexion();
            }
            return ban;
            
        }
        
        public void PanelAdmin(int bandera)
        {
            if (bandera == 1)
            {
                try
                {
                    con.AbrirConexion();
                    SqlDataReader reader = con.obtenerConsulta("select fk_rol from Trabajadores where usuario='" + mtb_usuario.Text + "'");
                    if (reader.Read())
                    {
                        if (reader[0].ToString() == "1")
                        {
                            PanelDeControl panel = new PanelDeControl();
                            panel.Show();
                        }
                        else
                        {
                            PanelVendedor panel = new PanelVendedor();
                            panel.Show();
                        }
                    }
                }
                catch (Exception)
                {

                    MetroMessageBox.Show(this, "Problemas al abrir el panel de control", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.CerrarConexion();
                }
            }
            else
            {

            }
        }
        #endregion
        private void mtb_passwordVisible_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                IngresarAlSistema();
            }
        }

        private void mtb_password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                IngresarAlSistema();
            }
        }
    }
}
