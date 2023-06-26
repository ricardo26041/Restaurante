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
    public partial class Panel_de_acciones : Form
    {
        public Panel_de_acciones()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Menu_Principal f4 = new Menu_Principal();
            f4.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            frm_cajero f5 = new frm_cajero();
            f5.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            frm_Domiciliario f6 = new frm_Domiciliario();
            f6.Show();
        }
    }
}
