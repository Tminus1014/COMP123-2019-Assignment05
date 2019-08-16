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
    public partial class ProductInfoForm : Form {
        public ProductInfoForm() {
            InitializeComponent();
        }

        /* ------------ */
        /* -= Events =- */
        /* ------------ */

        /// <summary>
        /// Event handler for the Product Info Form on load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e) {
            DisplayProductInformation();
        }

        /// <summary>
        /// Event handler for Select Another Product button. Allows the user to go back to the SelectForm and select another product. Shared with the Select Another Product menu strip item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProduct_Click(object sender, EventArgs e) {
            Program.productInfoForm.Hide();
            Program.selectForm.Show();
        }

        /// <summary>
        /// Event handler for the Next button. Hides the Product Info Form and shows the Order Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e) {
            Program.productInfoForm.Hide();
            Program.orderForm.Show();
        }

        /// <summary>
        /// Event handler for the Cancel button. Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// Event handler for the Save menu item. Runs saveProductOrder()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            saveProductOrder();
        }

        /// <summary>
        /// Event handler for the Open menu item. Runs openProductOrder() and displays the product information after loading.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            openProductOrder();
            DisplayProductInformation();
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

        private void saveProductOrder() {
            saveProductDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveProductDialog.FileName = "Product.txt";
            saveProductDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveProductDialog.ShowDialog() != DialogResult.Cancel) {
                using (StreamWriter outputString = new StreamWriter(File.Open(saveProductDialog.FileName, FileMode.Create))) {
                    outputString.WriteLine(Program.product.productID);
                    outputString.WriteLine(Program.product.cost);
                    outputString.WriteLine(Program.product.manufacturer);
                    outputString.WriteLine(Program.product.model);
                    outputString.WriteLine(Program.product.RAM_type);
                    outputString.WriteLine(Program.product.RAM_size);
                    outputString.WriteLine(Program.product.displaytype);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.resolution);
                    outputString.WriteLine(Program.product.CPU_Class);
                    outputString.WriteLine(Program.product.CPU_brand);
                    outputString.WriteLine(Program.product.CPU_type);
                    outputString.WriteLine(Program.product.CPU_speed);
                    outputString.WriteLine(Program.product.CPU_number);
                    outputString.WriteLine(Program.product.condition);
                    outputString.WriteLine(Program.product.OS);
                    outputString.WriteLine(Program.product.platform);
                    outputString.WriteLine(Program.product.HDD_size);
                    outputString.WriteLine(Program.product.GPU_Type);
                    outputString.WriteLine(Program.product.optical_drive);
                    outputString.WriteLine(Program.product.Audio_type);
                    outputString.WriteLine(Program.product.LAN);
                    outputString.WriteLine(Program.product.WIFI);
                    outputString.WriteLine(Program.product.width);
                    outputString.WriteLine(Program.product.height);
                    outputString.WriteLine(Program.product.moust_type);
                    outputString.WriteLine(Program.product.power);
                    outputString.WriteLine(Program.product.webcam);
                }
                MessageBox.Show("File Saved Successfully!", "File Saved");
            }
        }

        /// <summary>
        /// Opens a product order from a txt files and loads them.
        /// </summary>
        public void openProductOrder() {
            openProductDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openProductDialog.FileName = "Product.txt";
            openProductDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            try {
                if (openProductDialog.ShowDialog() != DialogResult.Cancel) {
                    using (StreamReader inputStream = new StreamReader(File.Open(openProductDialog.FileName, FileMode.Open))) {
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_type = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.displaytype = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.resolution = inputStream.ReadLine();
                        Program.product.CPU_Class = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.optical_drive = inputStream.ReadLine();
                        Program.product.Audio_type = inputStream.ReadLine();
                        Program.product.LAN = inputStream.ReadLine();
                        Program.product.WIFI = inputStream.ReadLine();
                        Program.product.width = inputStream.ReadLine();
                        Program.product.height = inputStream.ReadLine();
                        Program.product.moust_type = inputStream.ReadLine();
                        Program.product.power = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();
                    }
                }
            } catch {
                MessageBox.Show("Invalid Products file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
