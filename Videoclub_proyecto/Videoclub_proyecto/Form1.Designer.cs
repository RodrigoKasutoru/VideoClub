namespace Videoclub_proyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtl_titulo = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.mtb_password = new MetroFramework.Controls.MetroTextBox();
            this.mtb_usuario = new MetroFramework.Controls.MetroTextBox();
            this.mtb_passwordVisible = new MetroFramework.Controls.MetroTextBox();
            this.mtb_ingresar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.mtb_borrar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.mtl_eye = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // mtl_titulo
            // 
            this.mtl_titulo.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mtl_titulo.Location = new System.Drawing.Point(48, 25);
            this.mtl_titulo.Name = "mtl_titulo";
            this.mtl_titulo.Size = new System.Drawing.Size(187, 51);
            this.mtl_titulo.TabIndex = 0;
            this.mtl_titulo.Text = "Video club  UTT";
            this.mtl_titulo.UseSelectable = true;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(23, 82);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(75, 23);
            this.metroLink2.TabIndex = 1;
            this.metroLink2.Text = "Usuario:";
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink3
            // 
            this.metroLink3.Location = new System.Drawing.Point(23, 111);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(75, 23);
            this.metroLink3.TabIndex = 2;
            this.metroLink3.Text = "Password:";
            this.metroLink3.UseSelectable = true;
            // 
            // mtb_password
            // 
            // 
            // 
            // 
            this.mtb_password.CustomButton.Image = null;
            this.mtb_password.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtb_password.CustomButton.Name = "";
            this.mtb_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtb_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_password.CustomButton.TabIndex = 1;
            this.mtb_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_password.CustomButton.UseSelectable = true;
            this.mtb_password.CustomButton.Visible = false;
            this.mtb_password.Lines = new string[0];
            this.mtb_password.Location = new System.Drawing.Point(104, 111);
            this.mtb_password.MaxLength = 32767;
            this.mtb_password.Name = "mtb_password";
            this.mtb_password.PasswordChar = '*';
            this.mtb_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_password.SelectedText = "";
            this.mtb_password.SelectionLength = 0;
            this.mtb_password.SelectionStart = 0;
            this.mtb_password.Size = new System.Drawing.Size(163, 23);
            this.mtb_password.TabIndex = 4;
            this.mtb_password.UseSelectable = true;
            this.mtb_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtb_usuario
            // 
            // 
            // 
            // 
            this.mtb_usuario.CustomButton.Image = null;
            this.mtb_usuario.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtb_usuario.CustomButton.Name = "";
            this.mtb_usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtb_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_usuario.CustomButton.TabIndex = 1;
            this.mtb_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_usuario.CustomButton.UseSelectable = true;
            this.mtb_usuario.CustomButton.Visible = false;
            this.mtb_usuario.Lines = new string[0];
            this.mtb_usuario.Location = new System.Drawing.Point(104, 82);
            this.mtb_usuario.MaxLength = 32767;
            this.mtb_usuario.Name = "mtb_usuario";
            this.mtb_usuario.PasswordChar = '\0';
            this.mtb_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_usuario.SelectedText = "";
            this.mtb_usuario.SelectionLength = 0;
            this.mtb_usuario.SelectionStart = 0;
            this.mtb_usuario.Size = new System.Drawing.Size(163, 23);
            this.mtb_usuario.TabIndex = 5;
            this.mtb_usuario.UseSelectable = true;
            this.mtb_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtb_passwordVisible
            // 
            // 
            // 
            // 
            this.mtb_passwordVisible.CustomButton.Image = null;
            this.mtb_passwordVisible.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.mtb_passwordVisible.CustomButton.Name = "";
            this.mtb_passwordVisible.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtb_passwordVisible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_passwordVisible.CustomButton.TabIndex = 1;
            this.mtb_passwordVisible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_passwordVisible.CustomButton.UseSelectable = true;
            this.mtb_passwordVisible.CustomButton.Visible = false;
            this.mtb_passwordVisible.Lines = new string[0];
            this.mtb_passwordVisible.Location = new System.Drawing.Point(104, 111);
            this.mtb_passwordVisible.MaxLength = 32767;
            this.mtb_passwordVisible.Name = "mtb_passwordVisible";
            this.mtb_passwordVisible.PasswordChar = '\0';
            this.mtb_passwordVisible.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_passwordVisible.SelectedText = "";
            this.mtb_passwordVisible.SelectionLength = 0;
            this.mtb_passwordVisible.SelectionStart = 0;
            this.mtb_passwordVisible.Size = new System.Drawing.Size(163, 23);
            this.mtb_passwordVisible.TabIndex = 6;
            this.mtb_passwordVisible.UseSelectable = true;
            this.mtb_passwordVisible.Visible = false;
            this.mtb_passwordVisible.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_passwordVisible.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtb_ingresar
            // 
            this.mtb_ingresar.Image = null;
            this.mtb_ingresar.Location = new System.Drawing.Point(105, 148);
            this.mtb_ingresar.Name = "mtb_ingresar";
            this.mtb_ingresar.Size = new System.Drawing.Size(75, 23);
            this.mtb_ingresar.TabIndex = 7;
            this.mtb_ingresar.Text = "Ingresar";
            this.mtb_ingresar.UseSelectable = true;
            this.mtb_ingresar.UseVisualStyleBackColor = true;
            // 
            // mtb_borrar
            // 
            this.mtb_borrar.Image = null;
            this.mtb_borrar.Location = new System.Drawing.Point(186, 148);
            this.mtb_borrar.Name = "mtb_borrar";
            this.mtb_borrar.Size = new System.Drawing.Size(75, 23);
            this.mtb_borrar.TabIndex = 8;
            this.mtb_borrar.Text = "Borrar";
            this.mtb_borrar.UseSelectable = true;
            this.mtb_borrar.UseVisualStyleBackColor = true;
            this.mtb_borrar.Click += new System.EventHandler(this.mtb_borrar_Click);
            // 
            // mtl_eye
            // 
            this.mtl_eye.Image = global::Videoclub_proyecto.Properties.Resources._1448149372_view_01_1_;
            this.mtl_eye.ImageSize = 30;
            this.mtl_eye.Location = new System.Drawing.Point(273, 110);
            this.mtl_eye.Name = "mtl_eye";
            this.mtl_eye.Size = new System.Drawing.Size(27, 23);
            this.mtl_eye.TabIndex = 9;
            this.mtl_eye.UseSelectable = true;
            this.mtl_eye.Click += new System.EventHandler(this.mtl_eye_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 194);
            this.Controls.Add(this.mtl_eye);
            this.Controls.Add(this.mtb_borrar);
            this.Controls.Add(this.mtb_ingresar);
            this.Controls.Add(this.mtb_passwordVisible);
            this.Controls.Add(this.mtb_usuario);
            this.Controls.Add(this.mtb_password);
            this.Controls.Add(this.metroLink3);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.mtl_titulo);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mtl_titulo;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroTextBox mtb_password;
        private MetroFramework.Controls.MetroTextBox mtb_usuario;
        private MetroFramework.Controls.MetroTextBox mtb_passwordVisible;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton mtb_ingresar;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton mtb_borrar;
        private MetroFramework.Controls.MetroLink mtl_eye;
    }
}

