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
using static System.Net.Mime.MediaTypeNames;

namespace Presentacion
{
    public partial class frm_cajero : Form
    {
        public frm_cajero()
        {
            InitializeComponent();
            fnt_mediospagos();

        }

        private void txt_ID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_Consultar_Cliente1 obj_Consultar = new cls_Consultar_Cliente1();
                obj_Consultar.fnt_Consultar(txt_ID.Text);
                txt_Nombre.Text = obj_Consultar.getNombre();
                txt_Contacto.Text = obj_Consultar.getContacto();
                txt_Direccion.Text = obj_Consultar.getDireccion();
                if (obj_Consultar.getMsn() != "")
                {
                    MessageBox.Show("" + obj_Consultar.getMsn(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_Funciones_pla obj_Consultar = new cls_Funciones_pla();
                obj_Consultar.fnt_Consultarplatos(txt_Codigo.Text);
                txt_Nombre1.Text = obj_Consultar.getNombre();
                txt_precio_und.Text = Convert.ToString(obj_Consultar.getValorU());
                txt_ingredientes.Text = obj_Consultar.getIngredientes();
                if (obj_Consultar.getmensaje() != "")
                {
                    MessageBox.Show("" + obj_Consultar.getmensaje(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_Nombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnt_CalcularSubtotal()
        {
            double suma = 0;
            for (int i = 0; i < dtg_Datos.RowCount; i++)
            {
                suma += Convert.ToDouble(dtg_Datos.Rows[i].Cells[1].Value) * Convert.ToInt16(dtg_Datos.Rows[i].Cells[2].Value);
            }
            lbl_Subtotal.Text = Convert.ToString(suma);
            lbl_Iva.Text = Convert.ToString(suma * 0.19);
            lbl_Total.Text = Convert.ToString(Convert.ToDouble(lbl_Subtotal.Text) + Convert.ToDouble(lbl_Iva.Text));
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo.Text == "" || txt_precio_und.Text == "" || txt_cantidad.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO Y CANTIDAD DEL PRODCUTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean sw = false;
                int posi = 0;
                for (int i = 0; i < dtg_Datos.Rows.Count; i++)
                {
                    if (txt_Codigo.Text == Convert.ToString(dtg_Datos.Rows[i].Cells[0].Value))
                    {
                        posi = i;
                        sw = true;
                        break;

                    }
                }
                if (sw == true)
                {
                    int cant = Convert.ToInt16(dtg_Datos.Rows[posi].Cells[2].Value);
                    int new_cant = +Convert.ToInt16(txt_cantidad.Text);
                    dtg_Datos.Rows[posi].Cells[2].Value = new_cant;
                    fnt_CalcularSubtotal();
                }
                else
                {
                    dtg_Datos.Rows.Add(txt_Codigo.Text, txt_precio_und.Text, txt_cantidad.Text);
                    fnt_CalcularSubtotal();
                }

            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fnt_mediospagos()
        {
            cls_mediospagos obj_Dt = new cls_mediospagos();
            obj_Dt.fnt_mediopagos();
            cbx_mediospagos.ValueMember = "PKCodigo";
            cbx_mediospagos.DisplayMember = "Nombre";
            cbx_mediospagos.DataSource = obj_Dt.getDt();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {


        }
    }
}
