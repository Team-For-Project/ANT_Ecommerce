using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANT_Ecommerce
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Focus()) label5.Visible = false;
        }

        private void maskedTextBox1_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void maskedTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            label5.Text = "";
        }

        private void maskedTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "") label5.Text = "PassWord";

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "";
        }
    }
}
