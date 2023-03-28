using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperProyecto
{
    public partial class LoginApp : Form
    {
        Form2 Vendedor = new Form2();
        Form3 Elegir = new Form3();
        public LoginApp()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void LoginApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vendedor.Show();
            Elegir.ShowDialog();
        }
    }
}
