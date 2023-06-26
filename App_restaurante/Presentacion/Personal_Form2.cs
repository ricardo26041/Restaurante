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
    public partial class Personal_Form2 : Form
    {
        public Personal_Form2()
        {
            InitializeComponent();
            fnt_CargarRol();
            fnt_Estado();
        }
        private void fnt_nuevo()
        {
        txt_identi.Clear();
        txt_nombre.Clear();
        txt_contacto.Clear();
        txt_correo.Clear();
        txt_identi.Focus();

        }
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            fnt_nuevo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_Agregar_Personal objagregarpersonal = new cls_Agregar_Personal(
                txt_identi.Text, txt_nombre.Text, txt_contacto.Text, txt_correo.Text);
            MessageBox.Show("" + objagregarpersonal.getMsn());
            fnt_nuevo();
        }
        private void fnt_Consultar1(string Id)
        {
            cls_Consultar_Personal obj_Consultar = new cls_Consultar_Personal();
            obj_Consultar.fnt_Consultar1(Id);
            txt_nombre.Text = obj_Consultar.getNombre();
            txt_contacto.Text = obj_Consultar.getContacto();
            txt_correo.Text = obj_Consultar.getCorreo();

        }
        private void fnt_Estado()
        {
            cls_Agregar_Estado obj_Dt = new cls_Agregar_Estado();
            obj_Dt.fnt_Estado();
            cbx_Estado.ValueMember = "PKCodigo";
            cbx_Estado.DisplayMember = "Descripcion";
            cbx_Estado.DataSource = obj_Dt.getDt();
        }

        private void fnt_CargarRol()
        {
            cls_Agregar_Rol obj_Dt = new cls_Agregar_Rol();
            obj_Dt.fnt_CargarRo1();
            cbx_Rol.ValueMember = "PKCodigo";
            cbx_Rol.DisplayMember = "Nombre";
            cbx_Rol.DataSource = obj_Dt.getDt();
        }
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            fnt_Consultar1(txt_identi.Text);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cls_Actualizar_Personal objactualizar = new cls_Actualizar_Personal(
            txt_identi.Text, txt_nombre.Text, txt_contacto.Text, txt_correo.Text);
            MessageBox.Show("" + objactualizar.getMsn(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_nuevo();
        }
    }
}
