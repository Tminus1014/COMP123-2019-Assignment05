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

        /// <summary>
        /// Event handler for the Dollar Computers list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatDollarComputersList_SelectionChanged(object sender, EventArgs e) {
            // Collect data of selected computer
            CollectProductInformation();

            // Display select selected information on computer
            DisplayShortProductInformation();

        }

        /// <summary>
        /// Event handler for the Select Form upon loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e) {
            using (var db = new DollarComputersContext()) {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        /// <summary>
        /// Event handler for the Next button. Hides the Select Form and runs the Product Info Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e) {
            Program.selectForm.Hide();
            Program.productInfoForm.Show();
        }

        /// <summary>
        /// Event handler for the Cancel button. Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /* ------------- */
        /* -= Methods =- */
        /* ------------- */

        /// <summary>
        /// Displays the selected product's manufacturer, model, and cost.
        /// </summary>
        private void DisplayShortProductInformation() {
            txtSelectedComputer.Text = $"{Program.product.manufacturer} {Program.product.model} ({Program.product.cost:C})";
        }
        
        /// <summary>
        /// Collects the selected product information and loads them into the model fields.
        /// </summary>
        private void CollectProductInformation() {
            // Local scope aliases
            var rowIndex = datDollarComputersList.CurrentCell.RowIndex;
            var rows = datDollarComputersList.Rows;
            var columnCount = datDollarComputersList.ColumnCount;
            var cells = rows[rowIndex].Cells;

            // Collect the data
            Program.product.productID = short.Parse(cells[0].Value.ToString());
            Program.product.cost = decimal.Parse(cells[1].Value.ToString());
            Program.product.manufacturer = cells[2].Value.ToString();
            Program.product.model = cells[3].Value.ToString();
            Program.product.RAM_type = cells[4].Value.ToString();
            Program.product.RAM_size = cells[5].Value.ToString();
            Program.product.displaytype = cells[6].Value.ToString();
            Program.product.screensize = cells[7].Value.ToString();
            Program.product.resolution = cells[8].Value.ToString();
            Program.product.CPU_Class = cells[9].Value.ToString();
            Program.product.CPU_brand = cells[10].Value.ToString();
            Program.product.CPU_type = cells[11].Value.ToString();
            Program.product.CPU_speed = cells[12].Value.ToString();
            Program.product.CPU_number = cells[13].Value.ToString();
            Program.product.condition = cells[14].Value.ToString();
            Program.product.OS = cells[15].Value.ToString();
            Program.product.platform = cells[16].Value.ToString();
            Program.product.HDD_size = cells[17].Value.ToString();
            Program.product.GPU_Type = cells[18].Value.ToString();
            Program.product.optical_drive = cells[19].Value.ToString();
            Program.product.Audio_type = cells[20].Value.ToString();
            Program.product.LAN = cells[21].Value.ToString();
            Program.product.WIFI = cells[22].Value.ToString();
            Program.product.width = cells[23].Value.ToString();
            Program.product.height = cells[24].Value.ToString();
            Program.product.moust_type = cells[25].Value.ToString();
            Program.product.power = cells[26].Value.ToString();
            Program.product.webcam = cells[27].Value.ToString();
        }

    }
}

/*
    .          
   _|________________         
    |  .--.--. 
    |  |  |  | 
  `-`--'  '  `-

*/
