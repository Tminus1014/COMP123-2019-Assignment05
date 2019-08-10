using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_2019_Assignment05.Forms {
    public partial class ProductInfoForm : Form {
        public ProductInfoForm() {
            InitializeComponent();
        }

        /* ------------ */
        /* -= Events =- */
        /* ------------ */

        private void BtnNext_Click(object sender, EventArgs e) {
            Program.productInfoForm.Hide();
            Program.orderForm.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnSelectAnotherProduct_Click(object sender, EventArgs e) {
            Program.productInfoForm.Hide();
            Program.selectForm.Show();
        }
    }
}
