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
    public partial class SelectForm : Form {
        public SelectForm() {
            InitializeComponent();
        }

        /* ------------ */
        /* -= Events =- */
        /* ------------ */

        private void BtnNext_Click(object sender, EventArgs e) {
            Program.selectForm.Hide();
            Program.productInfoForm.Show();
        }
        private void BtnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
