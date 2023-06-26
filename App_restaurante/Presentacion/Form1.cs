using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        string ruta_directorio_Raiz;
        public Form1()
        {
            InitializeComponent();
            fnt_Cargartipo();
            fnt_cargarEstadoG();
            ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\Imagenes");
            fnt_limpiar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        // Funcion Gardar-Registrar**********************************************************************************

        
        //Cargar tipo ****************************************************************************************
        private void fnt_Cargartipo()
        {
            cls_cargar_tipo1 obj_Dt = new Negocio.cls_cargar_tipo1();
            obj_Dt.fnt_CargarTipo1();
            cbx_Tipo.ValueMember = "PKCodigo";
            cbx_Tipo.DisplayMember = "Nombre";
            cbx_Tipo.DataSource = obj_Dt.getDt();
        }

        // image **********************************************************************************************
        private void ptb_Foto_Click(object sender, EventArgs e)
        {
            try
            {
                ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\mesa");
                OpenFileDialog File = new OpenFileDialog();
                File.Filter = "Archivo JPG|*.jpg";

                if (File.ShowDialog() == DialogResult.OK)
                {
                    ptb_Foto.Image = Image.FromFile(File.FileName);
                }
            }
            catch { }

        }
        // Funcion Limpiar ************************************************************************************************
        private void fnt_limpiar() { 
            txt_Codigo.Clear();
            txt_Ingredientes.Clear();
            txt_Nombre.Clear();
            txt_Valor.Clear();
            ptb_Foto.Image = Image.FromFile(ruta_directorio_Raiz + "\\mesa.png");
            txt_Codigo.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fnt_limpiar();
        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Cargar Estado *********************************************************************************************
        private void fnt_cargarEstadoG()
        {
            cls_cargar_estado1 obj_Dt = new cls_cargar_estado1();
            obj_Dt.fnt_CargarEstado1();
            cbx_Estado.ValueMember = "PKCodigo";
            cbx_Estado.DisplayMember = "Descripcion";
            cbx_Estado.DataSource = obj_Dt.getDt();
        }
        private void cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            fnt_limpiar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            ptb_Foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] aByte = ms.ToArray();


            cls_agreagarplatos objagregarpaltos = new cls_agreagarplatos(
                txt_Codigo.Text, txt_Nombre.Text, txt_Ingredientes.Text, txt_Valor.Text,cbx_Tipo.SelectedIndex + 1, cbx_Estado.SelectedIndex + 1,  aByte);
            MessageBox.Show("" + objagregarpaltos.getMsn());
            fnt_limpiar();
        }
        private void fnt_Consultar(string cod)
        {
            cls_consulta_plato1 obj_Consultar = new cls_consulta_plato1();
            obj_Consultar.fnt_consultar(cod);
            ptb_Foto.Image = obj_Consultar.getBmp();
            txt_Nombre.Text = obj_Consultar.getNombre();
            txt_Ingredientes.Text = obj_Consultar.getIngredientes();
            txt_Valor.Text = obj_Consultar.getValor();
            cbx_Tipo.SelectedIndex = obj_Consultar.getTipo() - 1;
            cbx_Estado.SelectedIndex = obj_Consultar.getEstado() - 1;
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            fnt_Consultar(txt_Codigo.Text);
        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            cls_actulaiza_plato1 objAgregarCandidato = new cls_actulaiza_plato1(
                txt_Codigo.Text, txt_Nombre.Text, txt_Ingredientes.Text, txt_Valor.Text,
                cbx_Tipo.SelectedIndex + 1, cbx_Estado.SelectedIndex + 1);
            MessageBox.Show("" + objAgregarCandidato.getMsn(), "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fnt_limpiar();
        }

        private void ptb_Foto_Click_1(object sender, EventArgs e)
        {
            try
            {
                ruta_directorio_Raiz = Path.Combine(Application.StartupPath + "\\Imagenes");
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Archivo JPG|*.jpg";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    ptb_Foto.Image = Image.FromFile(file.FileName);
                }
            }
            catch { }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
