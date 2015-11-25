namespace Videoclub_proyecto
{
    partial class PanelVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.ml_Nombre = new MetroFramework.Controls.MetroLink();
            this.metroLink5 = new MetroFramework.Controls.MetroLink();
            this.metroLink6 = new MetroFramework.Controls.MetroLink();
            this.ml_sa = new MetroFramework.Controls.MetroLink();
            this.ml_SAP = new MetroFramework.Controls.MetroLink();
            this.ml_config = new MetroFramework.Controls.MetroLink();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.p_User = new System.Windows.Forms.PictureBox();
            this.Alquiler = new MetroFramework.Controls.MetroTile();
            this.Ventas = new MetroFramework.Controls.MetroTile();
            this.Accesorios = new MetroFramework.Controls.MetroTile();
            this.Peliculas = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.p_User)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLink3
            // 
            this.metroLink3.Location = new System.Drawing.Point(110, 27);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(64, 23);
            this.metroLink3.TabIndex = 17;
            this.metroLink3.Text = "Vendedor:";
            this.metroLink3.UseSelectable = true;
            // 
            // ml_Nombre
            // 
            this.ml_Nombre.Location = new System.Drawing.Point(110, 51);
            this.ml_Nombre.Name = "ml_Nombre";
            this.ml_Nombre.Size = new System.Drawing.Size(383, 23);
            this.ml_Nombre.TabIndex = 18;
            this.ml_Nombre.Text = "Nombre:";
            this.ml_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ml_Nombre.UseSelectable = true;
            this.ml_Nombre.Click += new System.EventHandler(this.ml_Nombre_Click);
            // 
            // metroLink5
            // 
            this.metroLink5.Location = new System.Drawing.Point(165, 10);
            this.metroLink5.Name = "metroLink5";
            this.metroLink5.Size = new System.Drawing.Size(115, 23);
            this.metroLink5.TabIndex = 19;
            this.metroLink5.Text = "Saldo de apertura:";
            this.metroLink5.UseSelectable = true;
            // 
            // metroLink6
            // 
            this.metroLink6.Location = new System.Drawing.Point(363, 10);
            this.metroLink6.Name = "metroLink6";
            this.metroLink6.Size = new System.Drawing.Size(115, 23);
            this.metroLink6.TabIndex = 20;
            this.metroLink6.Text = "Saldo actual:";
            this.metroLink6.UseSelectable = true;
            // 
            // ml_sa
            // 
            this.ml_sa.Location = new System.Drawing.Point(474, 10);
            this.ml_sa.Name = "ml_sa";
            this.ml_sa.Size = new System.Drawing.Size(99, 23);
            this.ml_sa.TabIndex = 21;
            this.ml_sa.Text = "0";
            this.ml_sa.UseSelectable = true;
            // 
            // ml_SAP
            // 
            this.ml_SAP.Location = new System.Drawing.Point(286, 10);
            this.ml_SAP.Name = "ml_SAP";
            this.ml_SAP.Size = new System.Drawing.Size(85, 23);
            this.ml_SAP.TabIndex = 22;
            this.ml_SAP.Text = "0";
            this.ml_SAP.UseSelectable = true;
            // 
            // ml_config
            // 
            this.ml_config.Image = global::Videoclub_proyecto.Properties.Resources._1443556794_services;
            this.ml_config.ImageSize = 40;
            this.ml_config.Location = new System.Drawing.Point(579, 10);
            this.ml_config.Name = "ml_config";
            this.ml_config.Size = new System.Drawing.Size(45, 40);
            this.ml_config.TabIndex = 16;
            this.ml_config.UseSelectable = true;
            this.ml_config.Click += new System.EventHandler(this.ml_config_Click);
            // 
            // ml_Close
            // 
            this.ml_Close.Image = global::Videoclub_proyecto.Properties.Resources._1443558808_close_window;
            this.ml_Close.ImageSize = 40;
            this.ml_Close.Location = new System.Drawing.Point(630, 10);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(45, 40);
            this.ml_Close.TabIndex = 15;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // p_User
            // 
            this.p_User.Image = global::Videoclub_proyecto.Properties.Resources._1447375343_photo;
            this.p_User.Location = new System.Drawing.Point(23, 10);
            this.p_User.Name = "p_User";
            this.p_User.Size = new System.Drawing.Size(81, 64);
            this.p_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_User.TabIndex = 14;
            this.p_User.TabStop = false;
            // 
            // Alquiler
            // 
            this.Alquiler.ActiveControl = null;
            this.Alquiler.Location = new System.Drawing.Point(23, 229);
            this.Alquiler.Name = "Alquiler";
            this.Alquiler.Size = new System.Drawing.Size(319, 142);
            this.Alquiler.Style = MetroFramework.MetroColorStyle.Blue;
            this.Alquiler.TabIndex = 13;
            this.Alquiler.Text = "Alquiler";
            this.Alquiler.TileImage = global::Videoclub_proyecto.Properties.Resources._1448158627_checked_checklist_notepad;
            this.Alquiler.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Alquiler.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Alquiler.UseSelectable = true;
            this.Alquiler.UseTileImage = true;
            // 
            // Ventas
            // 
            this.Ventas.ActiveControl = null;
            this.Ventas.Location = new System.Drawing.Point(348, 229);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(309, 142);
            this.Ventas.Style = MetroFramework.MetroColorStyle.Blue;
            this.Ventas.TabIndex = 12;
            this.Ventas.Text = "Ventas";
            this.Ventas.TileImage = global::Videoclub_proyecto.Properties.Resources._1447375862_sales_performance;
            this.Ventas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ventas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Ventas.UseSelectable = true;
            this.Ventas.UseTileImage = true;
            // 
            // Accesorios
            // 
            this.Accesorios.ActiveControl = null;
            this.Accesorios.Location = new System.Drawing.Point(348, 80);
            this.Accesorios.Name = "Accesorios";
            this.Accesorios.Size = new System.Drawing.Size(309, 143);
            this.Accesorios.Style = MetroFramework.MetroColorStyle.Blue;
            this.Accesorios.TabIndex = 11;
            this.Accesorios.Text = "Accesorios";
            this.Accesorios.TileImage = global::Videoclub_proyecto.Properties.Resources._1448157415_joypad;
            this.Accesorios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Accesorios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Accesorios.UseSelectable = true;
            this.Accesorios.UseTileImage = true;
            // 
            // Peliculas
            // 
            this.Peliculas.ActiveControl = null;
            this.Peliculas.Location = new System.Drawing.Point(23, 80);
            this.Peliculas.Name = "Peliculas";
            this.Peliculas.Size = new System.Drawing.Size(319, 143);
            this.Peliculas.Style = MetroFramework.MetroColorStyle.Blue;
            this.Peliculas.TabIndex = 10;
            this.Peliculas.Text = "Peliculas";
            this.Peliculas.TileImage = global::Videoclub_proyecto.Properties.Resources._1447373000_38;
            this.Peliculas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Peliculas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Peliculas.UseSelectable = true;
            this.Peliculas.UseTileImage = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 9999;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 383);
            this.Controls.Add(this.ml_SAP);
            this.Controls.Add(this.ml_sa);
            this.Controls.Add(this.metroLink6);
            this.Controls.Add(this.metroLink5);
            this.Controls.Add(this.ml_Nombre);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.ml_config);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.p_User);
            this.Controls.Add(this.Alquiler);
            this.Controls.Add(this.Ventas);
            this.Controls.Add(this.Accesorios);
            this.Controls.Add(this.Peliculas);
            this.Name = "PanelVendedor";
            this.Load += new System.EventHandler(this.PanelVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Accesorios;
        private MetroFramework.Controls.MetroTile Peliculas;
        private MetroFramework.Controls.MetroTile Alquiler;
        private MetroFramework.Controls.MetroTile Ventas;
        private System.Windows.Forms.PictureBox p_User;
        private MetroFramework.Controls.MetroLink ml_Close;
        private MetroFramework.Controls.MetroLink ml_config;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink ml_Nombre;
        private MetroFramework.Controls.MetroLink metroLink5;
        private MetroFramework.Controls.MetroLink metroLink6;
        private MetroFramework.Controls.MetroLink ml_sa;
        private MetroFramework.Controls.MetroLink ml_SAP;
        private System.Windows.Forms.Timer timer1;
    }
}