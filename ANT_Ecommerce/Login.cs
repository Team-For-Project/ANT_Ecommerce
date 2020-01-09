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
        bool colorTXT = false;
        public Login()
        {
            InitializeComponent();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Visible = false;
            bunifuGradientPanel3.Visible = true;
            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            maskedTextBox1.Text = "";

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Visible = false;
            bunifuGradientPanel2.Visible = true;
            pictureBox1.Visible = true;
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel3.Visible = false;
            bunifuGradientPanel2.Visible = true;
            pictureBox1.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void bunifuMaterialTextbox2_MouseDown(object sender, MouseEventArgs e)
        {
            label5.Text += "";
        }

        private void maskedTextBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            label5.Text = "";
        }

        private void maskedTextBox1_MouseLeave_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "") label5.Text = "PassWord";
        }

        private void bunifuMaterialTextbox2_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            label6.Text = "Hello ," + bunifuMaterialTextbox1.Text;
            this.BackColor = Color.FromArgb(252, 254, 252);
            panel1.BackColor = Color.FromArgb(252, 254, 252);
            pictureBox1.Visible = false;
        }
    }
}
