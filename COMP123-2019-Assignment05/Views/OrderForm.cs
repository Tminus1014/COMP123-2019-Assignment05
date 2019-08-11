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

        private void OrderForm_Activated(object sender, EventArgs e) {
            DisplayProductInformation();
            CalculateTotalCost();
        }

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
            MessageBox.Show("Thank you for your business! Your order will be processed within 7-10 business days.", "Order Complete!");
            Application.Exit();
        }

        /* ------------- */
        /* -= Methods =- */
        /* ------------- */

        private void DisplayProductInformation() {
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

        private void CalculateTotalCost() {

        }
    }
}
