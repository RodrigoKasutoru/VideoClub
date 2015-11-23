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
    public partial class P_Trabajadores : MetroFramework.Forms.MetroForm
    {
        Conexion con;
        Dictionary<string, int> val = new Dictionary<string, int>();
        int BuscarCuenta;
        int id;

        public P_Trabajadores()
        {
            InitializeComponent();
            con = new Conexion("VideoClub");
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            ObtenerDatosDataGrid();
            ObtenerRoles();
            LimpiarCajasTexto();


        }

        private void mb_Registrar_Click(object sender, EventArgs e)
        {
            if (mtb_Nombre.Text != ""&& mtb_ApellidoP.Text != "" && mtb_ApellidoM.Text != "" && mtb_RFC.Text != "" && mtb_Direccion.Text != "" && mtb_Colonia.Text != "" && mtb_CodigoP.Text != "" && mtb_Telefono.Text != "" && mtb_Celular.Text != "" && mtb_Usuario.Text != "" )
            {
                if (BuscarUsuario() == 0)
                {
                    InsertarTrabajador();
                }
                else
                {
                    MetroMessageBox.Show(this, "Trabajador ya existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "No se puedes dejar campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mg_Trabajadores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
                mtb_Nombre.Text = (string)mg_Trabajadores.CurrentRow.Cells["Nombre"].Value;
                mtb_ApellidoP.Text = (string)mg_Trabajadores.CurrentRow.Cells["Apellido paterno"].Value;
                mtb_ApellidoM.Text = (string)mg_Trabajadores.CurrentRow.Cells["Apellido materno"].Value;
                mtb_Edad.Text = (string)mg_Trabajadores.CurrentRow.Cells["Edad"].Value;
                md_Fecha.Text = (string)mg_Trabajadores.CurrentRow.Cells["Fecha de nacimiento"].Value;
                mtb_Direccion.Text = (string)mg_Trabajadores.CurrentRow.Cells["Direccion"].Value;
                mtb_Colonia.Text = (string)mg_Trabajadores.CurrentRow.Cells["Colonia"].Value;
                mtb_CodigoP.Text = (string)mg_Trabajadores.CurrentRow.Cells["Codigo postal"].Value;
                mtb_Telefono.Text = (string)mg_Trabajadores.CurrentRow.Cells["Telefono"].Value;
                mtb_Celular.Text = (string)mg_Trabajadores.CurrentRow.Cells["Celular"].Value;
                mtb_RFC.Text = (string)mg_Trabajadores.CurrentRow.Cells["RFC"].Value;
                mtb_Usuario.Text = (string)mg_Trabajadores.CurrentRow.Cells["usuario"].Value;
                mtb_Password.Text = (string)mg_Trabajadores.CurrentRow.Cells["password"].Value;
                mb_Rol.SelectedItem = (string)mg_Trabajadores.CurrentRow.Cells["Cargo"].Value;
                pic_Foto.ImageLocation = (string)mg_Trabajadores.CurrentRow.Cells["foto"].Value;
                id = (int)mg_Trabajadores.CurrentRow.Cells["Id_Trabajador"].Value;
                pic_Foto.ImageLocation = (string)mg_Trabajadores.CurrentRow.Cells["foto"].Value;
            }
            catch(Exception)
            {

            }
            mb_Registrar.Enabled = false;
            mb_Modificar.Enabled = true;
            mb_Eliminar.Enabled = true;
            mb_SubirFoto.Enabled = false;
        }
        
        private void mb_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCajasTexto();
        }

        private void mb_SubirFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pic_Foto.ImageLocation = openFileDialog1.FileName;
        }
       
        private void mb_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexion();
                con.BorrarDatos("DELETE FROM Trabajadores WHERE Id_Trabajador=" + id);
                con.EjecutarComando();
                MetroMessageBox.Show(this,"Datos eliminados correctamente","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al intentar borrar los  datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            ObtenerDatosDataGrid();

        }

        private void mb_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexion();
               
                    con.ActualizarDatos("UPDATE Trabajadores SET Nombre='" + mtb_Nombre.Text + "',ApellidoP='" + mtb_ApellidoP.Text + "',ApellidoM='" + mtb_ApellidoM.Text + "',Edad='" + mtb_Edad.Value.ToString() + "',FechaNacimiento='" + md_Fecha.Text + "',Direccion='" + mtb_Direccion.Text + "',Colonia='" + mtb_Colonia.Text + "',codigoPostal='" + mtb_CodigoP.Text + "',Telefono='" + mtb_Telefono.Text + "',Celular='" + mtb_Celular.Text + "',RFC='" + mtb_RFC.Text + "',usuario='" + mtb_Usuario.Text + "',password='" + mtb_Password.Text + "',foto='" + pic_Foto.ImageLocation + "',fk_rol=" + int.Parse(val[mb_Rol.Text].ToString()) + " WHERE Id_Trabajador=" + id + "");

                con.EjecutarComando();
                    MetroMessageBox.Show(this, "Trabajador Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al intentar actualizar la informacion del trabajador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            ObtenerDatosDataGrid();
        }

        public void ObtenerDatosDataGrid()
        {
            mg_Trabajadores.Columns.Clear();
            try
            {
                mg_Trabajadores.DataSource = con.obtenerTabla("Select Id_Trabajador,Nombre,ApellidoP as 'Apellido paterno',ApellidoM as 'Apellido materno',Edad,FechaNacimiento as 'Fecha de nacimiento',Direccion,Colonia,codigoPostal as 'Codigo postal',Telefono,Celular,RFC,usuario,password,Rol.descripcion_rol as 'Cargo',foto from Trabajadores INNER JOIN Rol on Trabajadores.fk_rol = Rol.Id_rol ORDER BY Trabajadores.Id_Trabajador");
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "No se pudieron obtener los datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ObtenerRoles()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("Select * from Rol order by Id_rol");
                while (reder.Read())
                {
                    mb_Rol.Items.Add(reder[1].ToString());
                    val.Add(reder[1].ToString(), int.Parse(reder[0].ToString()));
                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "No se pudieron obtener los datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            mb_Rol.SelectedIndex = 0;
        }
        public void InsertarTrabajador()
        {

            try
            {
                con.AbrirConexion();
                con.InsertarDatos("Insert into Trabajadores(Nombre,ApellidoP,ApellidoM,Edad,FechaNacimiento,Direccion,Colonia,codigoPostal,Telefono,Celular,RFC,usuario,password,foto,fk_rol) VALUES('" + mtb_Nombre.Text + "','" + mtb_ApellidoP.Text + "','" + mtb_ApellidoM.Text + "','" + mtb_Edad.Text + "','" + md_Fecha.Text + "','" + mtb_Direccion.Text + "','" + mtb_Colonia.Text + "','" + mtb_CodigoP.Text + "','" + mtb_Telefono.Text + "','" + mtb_Celular.Text + "','" + mtb_RFC.Text + "','" + mtb_Usuario.Text + "','" + mtb_Password.Text + "','foto/" + openFileDialog1.SafeFileName + "'," + int.Parse(val[mb_Rol.Text].ToString()) + ")");
                con.EjecutarComando();



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
                MetroMessageBox.Show(this, "Trabajador Insertado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                proc.Close();
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "No se pudieron introducir los datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {

                con.CerrarConexion();
            }
            ObtenerDatosDataGrid();

        }
        public void LimpiarCajasTexto()
        {
            mtb_Nombre.Text = string.Empty;
            mtb_ApellidoP.Text = string.Empty;
            mtb_ApellidoM.Text = string.Empty;
            mtb_Edad.Text = "0";
            md_Fecha.Refresh();
            mtb_Direccion.Text = string.Empty;
            mtb_Colonia.Text = string.Empty;
            mtb_CodigoP.Text = string.Empty;
            mtb_Telefono.Text = string.Empty;
            mtb_Celular.Text = string.Empty;
            mtb_RFC.Text = string.Empty;
            mtb_Usuario.Text = string.Empty;
            mtb_Password.Text = "123";
            mb_Rol.SelectedIndex = 0;
            pic_Foto.ImageLocation = @"foto/fondo.png";
            mb_Registrar.Enabled = true;
            mb_Modificar.Enabled = false;
            mb_Eliminar.Enabled = false;
            id = 0;
            openFileDialog1.Reset();
            mb_SubirFoto.Enabled = true;
        }
        public int BuscarUsuario()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("SELECT count(Id_Trabajador) from Trabajadores Where Nombre='" + mtb_Nombre.Text + "' and ApellidoP='" + mtb_ApellidoP.Text + "' and ApellidoM='" + mtb_ApellidoM.Text + "'");
                if (reder.Read())
                {
                    if (int.Parse(reder[0].ToString()) == 0)
                    {
                        BuscarCuenta = 0;
                    }
                    else
                    {
                        BuscarCuenta = 1;
                    }
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "No se pudo obtener informacion de la cuenta seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return BuscarCuenta;
        }
    }
}
