using COMP123_2019_Assignment05.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private void SelectForm_Load(object sender, EventArgs e) {
            using (var db = new DollarComputersContext()) {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }
    }
}
