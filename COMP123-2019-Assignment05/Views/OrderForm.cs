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
            CalculateTotalCost((double) Program.product.cost);
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

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e) {
            printOrder();
        }

        /* ------------- */
        /* -= Methods =- */
        /* ------------- */

        private void DisplayProductInformation() {
            txtCondition.Text = $"{Program.product.condition}";
            txtCost.Text = $"{Program.product.cost:C}";

            // Product Icon
            picProductIcon.SizeMode = PictureBoxSizeMode.Zoom;
            switch (Program.product.manufacturer) {
                case "Acer":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/acer.png");
                    break;
                case "Apple":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/apple.jpg");
                    break;
                case "Asus ":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/asus.png");
                    break;
                case "CybertronPC":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/cybertron.jpg");
                    break;
                case "Gateway ":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/gateway.png");
                    break;
                case "HP ":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/hp.jpg");
                    break;
                case "iBUYPOWER ":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/ibuypower.png");
                    break;
                case "Lenovo ":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/lenovo.jpg");
                    break;
                case "Toshiba ":
                    picProductIcon.Image = Image.FromFile("../../Views/images/comp-logo/toshiba.jpg");
                    break;
            }

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

        private void CalculateTotalCost(double basePrice) {
            const double salesTax = 0.13;
            double salesTaxPrice = basePrice * salesTax;
            double totalPrice = basePrice + salesTaxPrice;
            DisplayPrices(salesTaxPrice, totalPrice);
        }

        private void DisplayPrices(double salesTaxPrice, double totalPrice) {
            txtSalesTax.Text = $"{salesTaxPrice:C}";
            txtTotalPrice.Text = $"{totalPrice:C}";
        }

        private void printOrder() {
            MessageBox.Show("Printing your order...", "Printing");
        }
    }
}
