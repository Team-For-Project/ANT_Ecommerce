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
    public partial class ProductsAvailable : Form
    {
        public ProductsAvailable()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AddProducts addprd = new AddProducts();
            addprd.ShowDialog();
        }
    }
}
