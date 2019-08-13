using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_2019_Assignment05.Forms {
    public partial class StartForm : Form {
        public StartForm() {
            InitializeComponent();
        }

        /* ------------ */
        /* -= Events =- */
        /* ------------ */

        /// <summary>
        /// Hides the start form and show the select form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartOrder_Click(object sender, EventArgs e) {
            Program.startForm.Hide();
            Program.selectForm.Show();
        }
        private void BtnLoadOrder_Click(object sender, EventArgs e) {
            Program.productInfoForm.openProductOrder();

            // Trying to open OpenOrder form without actually selecting a product will cause the program to crash
            // because the method to calculate and display total price will be executed. Checking if cost has a 
            // value will determine whether the productInfoForm will be shown.
            if (Program.product.cost.HasValue) {
                Program.startForm.Hide();
                Program.productInfoForm.Show();
            }
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
