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
    public partial class OrderForm : Form {
        public OrderForm() {
            InitializeComponent();
        }

        /* ------------ */
        /* -= Events =- */
        /* ------------ */

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.aboutForm.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e) {
            Program.orderForm.Hide();
            Program.productInfoForm.Show();
        }

        private void BtnFinish_Click(object sender, EventArgs e) {
            MessageBox.Show("Thank you for your business! Your order will be processed within 7-10 business days.", "Order Complete");
            Application.Exit();
        }
    }
}
