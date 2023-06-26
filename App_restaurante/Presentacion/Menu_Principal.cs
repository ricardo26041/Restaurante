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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clientes_Form2 f1 = new Clientes_Form2();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           Form1 f2 = new Form1();
            f2.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Personal_Form2 f3 = new Personal_Form2();
            f3.Show();
        }

        
    }
}
