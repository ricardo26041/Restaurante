using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Clientes_Form2 : Form
    {

        public Clientes_Form2()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void fnt_Nuevo()
        {
            txt_ID1.Clear();
            txt_Nombre.Clear();
            txt_Contacto.Clear();
            txt_Direccion.Clear();

            txt_ID1.Focus();


        }
        private void btn_Nuevo1_Click(object sender, EventArgs e)
        {
            fnt_Nuevo();
        }

        private void btn_Guardar1_Click(object sender, EventArgs e)
        {



            cls_Agregar_Clientes objagregarclientes = new cls_Agregar_Clientes(
                txt_ID1.Text, txt_Nombre.Text, txt_Contacto.Text, txt_Direccion.Text);
            MessageBox.Show("" + objagregarclientes.getMsn());
            fnt_Nuevo();
        }
        private void fnt_Consultar1(string Id)
        {
            cls_Consultar_Clientes obj_Consultar = new cls_Consultar_Clientes();
            obj_Consultar.fnt_Consultar1(Id);
            txt_Nombre.Text = obj_Consultar.getNombre();
            txt_Contacto.Text = obj_Consultar.getContacto();
            txt_Direccion.Text = obj_Consultar.getDireccion();



        }
        private void btn_Consultar1_Click(object sender, EventArgs e)
        {
            fnt_Consultar1(txt_ID1.Text);
        }

        private void ptb_Foto1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar1_Click(object sender, EventArgs e)
        {
            cls_Actualizar_Clientes objactualizar = new cls_Actualizar_Clientes(
             txt_ID1.Text, txt_Nombre.Text, txt_Contacto.Text, txt_Direccion.Text);
            MessageBox.Show("" + objactualizar.getMsn(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_Nuevo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
} 
