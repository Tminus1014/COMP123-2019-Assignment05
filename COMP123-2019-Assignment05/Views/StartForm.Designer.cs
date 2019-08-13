namespace COMP123_2019_Assignment05.Forms {
    partial class StartForm {
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.btnLoadOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.Location = new System.Drawing.Point(13, 266);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(250, 26);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Order your computer today!";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartOrder.Location = new System.Drawing.Point(55, 295);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(162, 40);
            this.btnStartOrder.TabIndex = 0;
            this.btnStartOrder.Text = "Start New Order";
            this.btnStartOrder.UseVisualStyleBackColor = true;
            this.btnStartOrder.Click += new System.EventHandler(this.BtnStartOrder_Click);
            // 
            // btnLoadOrder
            // 
            this.btnLoadOrder.Location = new System.Drawing.Point(55, 341);
            this.btnLoadOrder.Name = "btnLoadOrder";
            this.btnLoadOrder.Size = new System.Drawing.Size(162, 40);
            this.btnLoadOrder.TabIndex = 1;
            this.btnLoadOrder.Text = "Load Saved Order";
            this.btnLoadOrder.UseVisualStyleBackColor = true;
            this.btnLoadOrder.Click += new System.EventHandler(this.BtnLoadOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(55, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 462);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadOrder);
            this.Controls.Add(this.btnStartOrder);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start - Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Button btnLoadOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}