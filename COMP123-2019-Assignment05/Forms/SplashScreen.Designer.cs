namespace COMP123_2019_Assignment05.Forms {
    partial class SplashScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblSplashScreenPlaceholder = new System.Windows.Forms.Label();
            this.tmrSplashScreen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSplashScreenPlaceholder
            // 
            this.lblSplashScreenPlaceholder.AutoSize = true;
            this.lblSplashScreenPlaceholder.Location = new System.Drawing.Point(13, 13);
            this.lblSplashScreenPlaceholder.Name = "lblSplashScreenPlaceholder";
            this.lblSplashScreenPlaceholder.Size = new System.Drawing.Size(206, 105);
            this.lblSplashScreenPlaceholder.TabIndex = 0;
            this.lblSplashScreenPlaceholder.Text = "Dollar Computers\r\nWe sell for less!\r\n\r\n© 2019 Trent B Minia tm-\r\nDeveloped for As" +
    "signment 5";
            // 
            // tmrSplashScreen
            // 
            this.tmrSplashScreen.Enabled = true;
            this.tmrSplashScreen.Interval = 3000;
            this.tmrSplashScreen.Tick += new System.EventHandler(this.TmrSplashScreen_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.lblSplashScreenPlaceholder);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSplashScreenPlaceholder;
        private System.Windows.Forms.Timer tmrSplashScreen;
    }
}