using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;


namespace Videoclub_proyecto
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool pasVidible = false;
        private void mtl_eye_Click(object sender, EventArgs e)
        {
            if (pasVidible == false)
            {
                mtb_passwordVisible.Visible = true;
                mtb_passwordVisible.Text = mtb_password.Text;
                pasVidible = true;
            }
            else
            {
                mtb_passwordVisible.Visible = false;
                mtb_passwordVisible.Text = string.Empty;
                pasVidible = false;
            }
        }

        private void mtb_borrar_Click(object sender, EventArgs e)
        {
            mtb_usuario.Text = string.Empty;
            mtb_password.Text = string.Empty;
            mtb_passwordVisible.Text = string.Empty;
        }
    }
}
