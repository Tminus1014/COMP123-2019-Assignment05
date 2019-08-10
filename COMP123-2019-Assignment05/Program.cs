using COMP123_2019_Assignment05.Forms;
using COMP123_2019_Assignment05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Program Title: Dollar Computers
/// Author: Trent B Minia tm- | Student #: 301041132
/// Date Last Modified: 2019-08-02
/// 
/// Description: A windows form that allows users to order computers from Dollar Computers.
/// 
/// Revision History:
///  * 2019-08-02: Basic UI completed
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
