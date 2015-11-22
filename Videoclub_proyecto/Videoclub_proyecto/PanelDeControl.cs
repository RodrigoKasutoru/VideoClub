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
    public partial class PanelDeControl : MetroFramework.Forms.MetroForm
    {
        public PanelDeControl()
        {
            InitializeComponent();
            
        }
        Conexion con;
        int cantidad;

        private void PanelDeControl_Load(object sender, EventArgs e)
        {
            con = new Conexion("VideoClub");
            
                Trabajadores.TileCount = ObtenerCantidadTrabajadores();
                Miembros.TileCount = ObtenerCantidadMiembros();
                Roles.TileCount = ObtenerCantidadRol();
                Alquiler.TileCount = ObtenerCantidadAlquiler();
                Peliculas.TileCount = ObtenerCantidadPeliculas();
                Accesorios.TileCount = ObtenerCantidadAccesorios();
                Ventas.TileCount = obtenerVentas();
            
        }
       public int ObtenerCantidadTrabajadores()
        {
            
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(Id_Trabajador)from Trabajadores");
                if(reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this,"Error al obtener datos de la base de datos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
       public int ObtenerCantidadMiembros()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(Id_miembro)from Miembros");
                if (reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
        public int ObtenerCantidadRol()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(Id_rol)from Rol");
                if (reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
        public int ObtenerCantidadAlquiler()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(id_alquiler)from Alquiler");
                if (reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
        public int ObtenerCantidadPeliculas()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(Id_pelicula)from Peliculas");
                if (reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
        public int ObtenerCantidadAccesorios()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(Id_accesorio)from Accesorios");
                if (reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
        public int obtenerVentas()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select count(Id_ventaAccesorios)from VentaAccesorios ");
                if (reader.Read())
                {
                    cantidad = int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select count(Id_ventaPelicula)from VentasPeliculas");
                if (reader.Read())
                {
                    cantidad += int.Parse(reader[0].ToString());
                }

            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al obtener datos de la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            return cantidad;
        }
        private void Trabajadores_Click(object sender, EventArgs e)
        {

        }

        private void CerrarSeccion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Trabajadores.TileCount = ObtenerCantidadTrabajadores();
            Miembros.TileCount = ObtenerCantidadMiembros();
            Roles.TileCount = ObtenerCantidadRol();
            Alquiler.TileCount = ObtenerCantidadAlquiler();
            Peliculas.TileCount = ObtenerCantidadPeliculas();
            Accesorios.TileCount = ObtenerCantidadAccesorios();
            Ventas.TileCount = obtenerVentas();
            Trabajadores.Refresh();
            Miembros.Refresh();
            Roles.Refresh();
            Alquiler.Refresh();
            Peliculas.Refresh();
            Accesorios.Refresh();
            Ventas.Refresh();

        }
    }
}
