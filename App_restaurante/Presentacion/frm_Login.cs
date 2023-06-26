using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
            lbl_mensaje.Visible = true;
            
        }
        private void fnt_Login(string user, string password)
        {
            cls_Login obj_Login = new cls_Login(user,password);
            MessageBox.Show("" + obj_Login.getRol());
            if (obj_Login.getRol() == "ADMINISTRADOR")
            {
                Panel_de_acciones obj_Admin = new Panel_de_acciones();
                obj_Admin.Visible = true;
                obj_Admin.lbl_Encargado.Text = obj_Login.getNombre();
                obj_Admin.lbl_Estado.Text = obj_Login.getEstado();
                obj_Admin.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            if (obj_Login.getRol() == "CAJERO")
            {
                Panel_de_acciones obj_cajero = new Panel_de_acciones();
                obj_cajero.Visible = true;
                obj_cajero.lbl_Encargado.Text = obj_Login.getNombre();
                obj_cajero.lbl_Estado.Text = obj_Login.getEstado();
                obj_cajero.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            if (obj_Login.getRol() == "DOMICILIARIO")
            {
                Panel_de_acciones obj_Domiciliario = new Panel_de_acciones();
                obj_Domiciliario.Visible = true;
                obj_Domiciliario.lbl_Encargado.Text = obj_Login.getNombre();
                obj_Domiciliario.lbl_Estado.Text = obj_Login.getEstado();
                obj_Domiciliario.lbl_Rol.Text = obj_Login.getRol();
                Visible = false;
            }
            
            lbl_mensaje.ForeColor = Color.Red;
            lbl_mensaje.Text = obj_Login.getMsn();
            lbl_mensaje.Visible = true;
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click_1(object sender, EventArgs e)
        {
            fnt_Login(txt_Usuario.Text,txt_Contraseña.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_mensaje_Click(object sender, EventArgs e)
        {

        }

        private void pbmostrar_Click(object sender, EventArgs e)
        {
            pbocultar.BringToFront();
            txt_Contraseña.PasswordChar = '\0';
        }

        private void pbocultar_Click(object sender, EventArgs e)
        {
            pbmostrar.BringToFront();
            txt_Contraseña.PasswordChar = '*';
        }
    }
}


