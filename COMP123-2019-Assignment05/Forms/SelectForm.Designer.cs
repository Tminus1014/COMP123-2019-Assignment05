namespace COMP123_2019_Assignment05.Forms {
    partial class SelectForm {
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
            this.lblListofComputers = new System.Windows.Forms.Label();
            this.datDollarComputersList = new System.Windows.Forms.DataGridView();
            this.lblSelectedComputer = new System.Windows.Forms.Label();
            this.txtSelectedComputer = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datDollarComputersList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListofComputers
            // 
            this.lblListofComputers.AutoSize = true;
            this.lblListofComputers.Location = new System.Drawing.Point(15, 17);
            this.lblListofComputers.Name = "lblListofComputers";
            this.lblListofComputers.Size = new System.Drawing.Size(138, 21);
            this.lblListofComputers.TabIndex = 0;
            this.lblListofComputers.Text = "List of Computers:";
            // 
            // datDollarComputersList
            // 
            this.datDollarComputersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datDollarComputersList.Location = new System.Drawing.Point(19, 41);
            this.datDollarComputersList.Name = "datDollarComputersList";
            this.datDollarComputersList.ReadOnly = true;
            this.datDollarComputersList.RowHeadersWidth = 51;
            this.datDollarComputersList.RowTemplate.Height = 24;
            this.datDollarComputersList.Size = new System.Drawing.Size(751, 436);
            this.datDollarComputersList.TabIndex = 1;
            // 
            // lblSelectedComputer
            // 
            this.lblSelectedComputer.AutoSize = true;
            this.lblSelectedComputer.Location = new System.Drawing.Point(15, 504);
            this.lblSelectedComputer.Name = "lblSelectedComputer";
            this.lblSelectedComputer.Size = new System.Drawing.Size(147, 21);
            this.lblSelectedComputer.TabIndex = 2;
            this.lblSelectedComputer.Text = "Selected Computer:";
            // 
            // txtSelectedComputer
            // 
            this.txtSelectedComputer.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedComputer.Location = new System.Drawing.Point(168, 501);
            this.txtSelectedComputer.Name = "txtSelectedComputer";
            this.txtSelectedComputer.ReadOnly = true;
            this.txtSelectedComputer.Size = new System.Drawing.Size(387, 27);
            this.txtSelectedComputer.TabIndex = 3;
            this.txtSelectedComputer.Text = "Selected Computer";
            this.txtSelectedComputer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(678, 501);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 40);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(580, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtSelectedComputer);
            this.Controls.Add(this.lblSelectedComputer);
            this.Controls.Add(this.datDollarComputersList);
            this.Controls.Add(this.lblListofComputers);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer - Dollar Computers";
            ((System.ComponentModel.ISupportInitialize)(this.datDollarComputersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListofComputers;
        private System.Windows.Forms.DataGridView datDollarComputersList;
        private System.Windows.Forms.Label lblSelectedComputer;
        private System.Windows.Forms.TextBox txtSelectedComputer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
    }
}