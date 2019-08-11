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

        private void ProductInfoForm_Load(object sender, EventArgs e) {
            DisplayProductInformation();
        }

        /// <summary>
        /// Allows the user to go back to the SelectForm and select another product. Shared by btnSelectAnotherProduct and selectAnotherProductToolStripMenuItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProduct_Click(object sender, EventArgs e) {
            Program.productInfoForm.Hide();
            Program.selectForm.Show();
        }

        private void BtnNext_Click(object sender, EventArgs e) {
            Program.productInfoForm.Hide();
            Program.orderForm.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /* ------------- */
        /* -= Methods =- */
        /* ------------- */

        /// <summary>
        /// Retrieves and displays product information into the text boxes
        /// </summary>
        private void DisplayProductInformation() {
            txtProductId.Text = $"{Program.product.productID}";
            txtCondition.Text = $"{Program.product.condition}";
            txtCost.Text = $"{Program.product.cost:C}";

            // Product Information
            txtPlatform.Text = $"{Program.product.platform}";
            txtOperatingSystem.Text = $"{Program.product.OS}";
            txtManufacturer.Text = $"{Program.product.manufacturer}";
            txtModel.Text = $"{Program.product.model}";

            // Technical Specifications
            txtMemory.Text = $"{Program.product.RAM_size}";
            txtLcdSize.Text = $"{Program.product.screensize}";
            txtHddSize.Text = $"{Program.product.HDD_size}";
            txtCpuBrand.Text = $"{Program.product.CPU_brand}";
            txtCpuNumber.Text = $"{Program.product.CPU_number}";
            txtGpuType.Text = $"{Program.product.GPU_Type}";
            txtCpuType.Text = $"{Program.product.CPU_type}";
            txtCpuSpeed.Text = $"{Program.product.CPU_speed}";
            txtWebcam.Text = $"{Program.product.webcam}";
        }
    }
}
