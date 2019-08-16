using COMP123_2019_Assignment05.Forms;
using COMP123_2019_Assignment05.Models;
using System;
using System.Windows.Forms;

/// <summary>
/// Program Title: Dollar Computers
/// Author: Trent B Minia tm- | Student #: 301041132
/// Date Last Modified: 2019-08-16
/// 
/// Description: A windows form that allows users to order computers from Dollar Computers.
/// 
/// Revision History:
///  * 2019-08-02: Basic UI completed
///  * 2019-08-10: Connected the Products table from the DollarComputers database
///  * 2019-08-11: Added the ability for the ProductInfoForm and OrderForm forms to display 
///                product information based on the computer selected in the SelectForm
///  * 2019-08-12: Added the ability to caluclate and display total price
///  *             Added the ability to save and load product text files
///  * 2019-08-15: Added logos, splash screen and icon. Added theme colours to the forms
///                Updated about form
///  * 2019-08-16: Completed internal documentation.
///                Added banner for About Form.
///  
/// All stock images were taking from Pixabay and modified by me to add Dollar Computers-related
/// visuals. All company logos belong to their respective manufacturers.
/// 
/// </summary>
namespace COMP123_2019_Assignment05 {
    public static class Program {
        // Forms
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        // Models
        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instantiate Forms
            splashScreen = new SplashScreen();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            // Instantiate Products
            product = new Product();
            
            Application.Run(splashScreen);
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