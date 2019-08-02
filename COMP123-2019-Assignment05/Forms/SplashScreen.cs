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
    public partial class SplashScreen : Form {
        public SplashScreen() {
            InitializeComponent();
        }

        /// <summary>
        /// Splash screen timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmrSplashScreen_Tick(object sender, EventArgs e) {
            // Disable timer
            tmrSplashScreen.Enabled = false;

            // Change displayed forms
            Program.splashScreen.Hide();
            Program.startForm.Show();
        }
    }
}
