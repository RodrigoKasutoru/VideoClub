﻿using System;
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
    public partial class PanelDeControl : MetroFramework.Forms.MetroForm
    {
        Conexion con;
        int cantidad;
        int Id;
        public PanelDeControl()
        {
            InitializeComponent();
            
        }
        public PanelDeControl(int id)
        {
            InitializeComponent();
            Id = id;

        }

        private void PanelDeControl_Load(object sender, EventArgs e)
        {
            con = new Conexion("Data Source = DESKTOP-5QTHLQM\\CASTOR;" + "Initial Catalog = VideoClub ; Integrated Security = true;");
                ObtenerDatosLogeado();
                Trabajadores.TileCount = ObtenerCantidadTrabajadores();
                Miembros.TileCount = ObtenerCantidadMiembros();
                Alquiler.TileCount = ObtenerCantidadAlquiler();
                Peliculas.TileCount = ObtenerCantidadPeliculas();
                Accesorios.TileCount = ObtenerCantidadAccesorios();
                Ventas.TileCount = obtenerVentas();
            
        }
  
        private void Trabajadores_Click(object sender, EventArgs e)
        {
           RegistroTrabajadores t = new RegistroTrabajadores();
            t.Show();
        }

        private void CerrarSeccion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Trabajadores.TileCount = ObtenerCantidadTrabajadores();
            Miembros.TileCount = ObtenerCantidadMiembros();
            Alquiler.TileCount = ObtenerCantidadAlquiler();
            Peliculas.TileCount = ObtenerCantidadPeliculas();
            Accesorios.TileCount = ObtenerCantidadAccesorios();
            Ventas.TileCount = obtenerVentas();
            monitoreoImagen();
            Trabajadores.Refresh();
            Miembros.Refresh();
            Alquiler.Refresh();
            Peliculas.Refresh();
            Accesorios.Refresh();
            obtenerSaldos();
        }
        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        public int ObtenerCantidadTrabajadores()
        {

            try
            {
                con.AbrirConexion();
                SqlDataReader reader = con.obtenerConsulta("select COUNT(Id_Trabajador)from Trabajadores");
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
                SqlDataReader reader = con.obtenerConsulta("select COUNT(id_alquiler)from Alquiler  where devuelta='no'");
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

        
        public void ObtenerDatosLogeado()
        {
            string P_Default = "contra";
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("SELECT Nombre,ApellidoP,ApellidoM,foto,password From Trabajadores Where Id_Trabajador=" + Id);
                while (reder.Read())
                {
                    p_User.ImageLocation = reder[3].ToString();
                    ml_Nombre.Text = reder[0].ToString() + " " + reder[1].ToString() + " " + reder[2].ToString();
                    P_Default = reder[4].ToString();
                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al cargar los datos del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            if (P_Default == "123")
            {
                MetroMessageBox.Show(this, "Tu cuenta es nueva deves de cambiar la contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }
        public void monitoreoImagen()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("Select foto from Trabajadores where Id_Trabajador=" + Id + "");
                if (reder.Read())
                {
                    p_User.ImageLocation = reder[0].ToString();
                }
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "Error al cargar los datos del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.CerrarConexion();
            }
            p_User.Refresh();
        }

        private void ml_config_Click(object sender, EventArgs e)
        {
            ConfigUsuario configUsu = new ConfigUsuario(Id);
            configUsu.Show();
        }
        public void obtenerSaldos()
        {
            try
            {
                con.AbrirConexion();
                SqlDataReader reder = con.obtenerConsulta("select TOP 1 * FROM caja order by Id_caja desc");
                if (reder.Read())
                {
                    ml_SAP.Text = reder[1].ToString();
                    ml_sa.Text = reder[2].ToString();
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
            ml_SAP.Refresh();
            ml_sa.Refresh();
        }
    }
}
