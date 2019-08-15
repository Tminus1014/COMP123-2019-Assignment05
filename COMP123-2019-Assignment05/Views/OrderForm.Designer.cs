namespace COMP123_2019_Assignment05.Forms {
    partial class OrderForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.mnuOrder = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpSystemComponents = new System.Windows.Forms.GroupBox();
            this.tblComponentsSubII = new System.Windows.Forms.TableLayoutPanel();
            this.lblLcdSize = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblCpuBrand = new System.Windows.Forms.Label();
            this.lblCpuType = new System.Windows.Forms.Label();
            this.lblCpuNumber = new System.Windows.Forms.Label();
            this.txtLcdSize = new System.Windows.Forms.TextBox();
            this.lblCpuSpeed = new System.Windows.Forms.Label();
            this.lblHddSize = new System.Windows.Forms.Label();
            this.lblGpuType = new System.Windows.Forms.Label();
            this.lblWebcam = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.txtCpuBrand = new System.Windows.Forms.TextBox();
            this.txtCpuType = new System.Windows.Forms.TextBox();
            this.txtCpuNumber = new System.Windows.Forms.TextBox();
            this.txtCpuSpeed = new System.Windows.Forms.TextBox();
            this.txtHddSize = new System.Windows.Forms.TextBox();
            this.txtGpuType = new System.Windows.Forms.TextBox();
            this.txtWebcam = new System.Windows.Forms.TextBox();
            this.txtOperatingSystem = new System.Windows.Forms.TextBox();
            this.tblComponentsSubI = new System.Windows.Forms.TableLayoutPanel();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpYourPrice = new System.Windows.Forms.GroupBox();
            this.tblTotalPrice = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.tblPrices = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.mnuOrder.SuspendLayout();
            this.grpSystemComponents.SuspendLayout();
            this.tblComponentsSubII.SuspendLayout();
            this.tblComponentsSubI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpYourPrice.SuspendLayout();
            this.tblTotalPrice.SuspendLayout();
            this.tblPrices.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOrder
            // 
            this.mnuOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.mnuOrder.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuOrder.Location = new System.Drawing.Point(0, 0);
            this.mnuOrder.Name = "mnuOrder";
            this.mnuOrder.Size = new System.Drawing.Size(782, 28);
            this.mnuOrder.TabIndex = 0;
            this.mnuOrder.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(580, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.btnFinish.Location = new System.Drawing.Point(678, 501);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(92, 40);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(482, 501);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(92, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // grpSystemComponents
            // 
            this.grpSystemComponents.Controls.Add(this.tblComponentsSubII);
            this.grpSystemComponents.Controls.Add(this.tblComponentsSubI);
            this.grpSystemComponents.Controls.Add(this.shapeContainer1);
            this.grpSystemComponents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.grpSystemComponents.Location = new System.Drawing.Point(13, 31);
            this.grpSystemComponents.Name = "grpSystemComponents";
            this.grpSystemComponents.Size = new System.Drawing.Size(561, 464);
            this.grpSystemComponents.TabIndex = 10;
            this.grpSystemComponents.TabStop = false;
            this.grpSystemComponents.Text = "System Components";
            // 
            // tblComponentsSubII
            // 
            this.tblComponentsSubII.ColumnCount = 2;
            this.tblComponentsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.97802F));
            this.tblComponentsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.02198F));
            this.tblComponentsSubII.Controls.Add(this.lblLcdSize, 0, 0);
            this.tblComponentsSubII.Controls.Add(this.lblMemory, 0, 1);
            this.tblComponentsSubII.Controls.Add(this.lblCpuBrand, 0, 2);
            this.tblComponentsSubII.Controls.Add(this.lblCpuType, 0, 3);
            this.tblComponentsSubII.Controls.Add(this.lblCpuNumber, 0, 4);
            this.tblComponentsSubII.Controls.Add(this.txtLcdSize, 1, 0);
            this.tblComponentsSubII.Controls.Add(this.lblCpuSpeed, 0, 5);
            this.tblComponentsSubII.Controls.Add(this.lblHddSize, 0, 6);
            this.tblComponentsSubII.Controls.Add(this.lblGpuType, 0, 7);
            this.tblComponentsSubII.Controls.Add(this.lblWebcam, 0, 8);
            this.tblComponentsSubII.Controls.Add(this.lblOperatingSystem, 0, 9);
            this.tblComponentsSubII.Controls.Add(this.txtMemory, 1, 1);
            this.tblComponentsSubII.Controls.Add(this.txtCpuBrand, 1, 2);
            this.tblComponentsSubII.Controls.Add(this.txtCpuType, 1, 3);
            this.tblComponentsSubII.Controls.Add(this.txtCpuNumber, 1, 4);
            this.tblComponentsSubII.Controls.Add(this.txtCpuSpeed, 1, 5);
            this.tblComponentsSubII.Controls.Add(this.txtHddSize, 1, 6);
            this.tblComponentsSubII.Controls.Add(this.txtGpuType, 1, 7);
            this.tblComponentsSubII.Controls.Add(this.txtWebcam, 1, 8);
            this.tblComponentsSubII.Controls.Add(this.txtOperatingSystem, 1, 9);
            this.tblComponentsSubII.Location = new System.Drawing.Point(9, 133);
            this.tblComponentsSubII.Name = "tblComponentsSubII";
            this.tblComponentsSubII.RowCount = 10;
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblComponentsSubII.Size = new System.Drawing.Size(546, 325);
            this.tblComponentsSubII.TabIndex = 2;
            // 
            // lblLcdSize
            // 
            this.lblLcdSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLcdSize.AutoSize = true;
            this.lblLcdSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblLcdSize.Location = new System.Drawing.Point(49, 5);
            this.lblLcdSize.Name = "lblLcdSize";
            this.lblLcdSize.Size = new System.Drawing.Size(67, 21);
            this.lblLcdSize.TabIndex = 2;
            this.lblLcdSize.Text = "LCD Size";
            this.lblLcdSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMemory
            // 
            this.lblMemory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMemory.AutoSize = true;
            this.lblMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblMemory.Location = new System.Drawing.Point(46, 37);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(70, 21);
            this.lblMemory.TabIndex = 2;
            this.lblMemory.Text = "Memory";
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuBrand
            // 
            this.lblCpuBrand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuBrand.AutoSize = true;
            this.lblCpuBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblCpuBrand.Location = new System.Drawing.Point(32, 69);
            this.lblCpuBrand.Name = "lblCpuBrand";
            this.lblCpuBrand.Size = new System.Drawing.Size(84, 21);
            this.lblCpuBrand.TabIndex = 2;
            this.lblCpuBrand.Text = "CPU Brand";
            this.lblCpuBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuType
            // 
            this.lblCpuType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuType.AutoSize = true;
            this.lblCpuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblCpuType.Location = new System.Drawing.Point(41, 101);
            this.lblCpuType.Name = "lblCpuType";
            this.lblCpuType.Size = new System.Drawing.Size(75, 21);
            this.lblCpuType.TabIndex = 2;
            this.lblCpuType.Text = "CPU Type";
            this.lblCpuType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuNumber
            // 
            this.lblCpuNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuNumber.AutoSize = true;
            this.lblCpuNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblCpuNumber.Location = new System.Drawing.Point(16, 133);
            this.lblCpuNumber.Name = "lblCpuNumber";
            this.lblCpuNumber.Size = new System.Drawing.Size(100, 21);
            this.lblCpuNumber.TabIndex = 2;
            this.lblCpuNumber.Text = "CPU Number";
            this.lblCpuNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLcdSize
            // 
            this.txtLcdSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLcdSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtLcdSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLcdSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtLcdSize.Location = new System.Drawing.Point(122, 3);
            this.txtLcdSize.Name = "txtLcdSize";
            this.txtLcdSize.ReadOnly = true;
            this.txtLcdSize.Size = new System.Drawing.Size(421, 25);
            this.txtLcdSize.TabIndex = 2;
            this.txtLcdSize.TabStop = false;
            // 
            // lblCpuSpeed
            // 
            this.lblCpuSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuSpeed.AutoSize = true;
            this.lblCpuSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblCpuSpeed.Location = new System.Drawing.Point(31, 165);
            this.lblCpuSpeed.Name = "lblCpuSpeed";
            this.lblCpuSpeed.Size = new System.Drawing.Size(85, 21);
            this.lblCpuSpeed.TabIndex = 2;
            this.lblCpuSpeed.Text = "CPU Speed";
            this.lblCpuSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHddSize
            // 
            this.lblHddSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHddSize.AutoSize = true;
            this.lblHddSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblHddSize.Location = new System.Drawing.Point(75, 197);
            this.lblHddSize.Name = "lblHddSize";
            this.lblHddSize.Size = new System.Drawing.Size(41, 21);
            this.lblHddSize.TabIndex = 2;
            this.lblHddSize.Text = "HDD";
            this.lblHddSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGpuType
            // 
            this.lblGpuType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGpuType.AutoSize = true;
            this.lblGpuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblGpuType.Location = new System.Drawing.Point(39, 229);
            this.lblGpuType.Name = "lblGpuType";
            this.lblGpuType.Size = new System.Drawing.Size(77, 21);
            this.lblGpuType.TabIndex = 2;
            this.lblGpuType.Text = "GPU Type";
            this.lblGpuType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWebcam
            // 
            this.lblWebcam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWebcam.AutoSize = true;
            this.lblWebcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblWebcam.Location = new System.Drawing.Point(46, 261);
            this.lblWebcam.Name = "lblWebcam";
            this.lblWebcam.Size = new System.Drawing.Size(70, 21);
            this.lblWebcam.TabIndex = 2;
            this.lblWebcam.Text = "Webcam";
            this.lblWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblOperatingSystem.Location = new System.Drawing.Point(87, 296);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(29, 21);
            this.lblOperatingSystem.TabIndex = 2;
            this.lblOperatingSystem.Text = "OS";
            this.lblOperatingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemory
            // 
            this.txtMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtMemory.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtMemory.Location = new System.Drawing.Point(122, 35);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(421, 25);
            this.txtMemory.TabIndex = 2;
            this.txtMemory.TabStop = false;
            // 
            // txtCpuBrand
            // 
            this.txtCpuBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtCpuBrand.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtCpuBrand.Location = new System.Drawing.Point(122, 67);
            this.txtCpuBrand.Name = "txtCpuBrand";
            this.txtCpuBrand.ReadOnly = true;
            this.txtCpuBrand.Size = new System.Drawing.Size(421, 25);
            this.txtCpuBrand.TabIndex = 2;
            this.txtCpuBrand.TabStop = false;
            // 
            // txtCpuType
            // 
            this.txtCpuType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtCpuType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtCpuType.Location = new System.Drawing.Point(122, 99);
            this.txtCpuType.Name = "txtCpuType";
            this.txtCpuType.ReadOnly = true;
            this.txtCpuType.Size = new System.Drawing.Size(421, 25);
            this.txtCpuType.TabIndex = 2;
            this.txtCpuType.TabStop = false;
            // 
            // txtCpuNumber
            // 
            this.txtCpuNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtCpuNumber.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtCpuNumber.Location = new System.Drawing.Point(122, 131);
            this.txtCpuNumber.Name = "txtCpuNumber";
            this.txtCpuNumber.ReadOnly = true;
            this.txtCpuNumber.Size = new System.Drawing.Size(421, 25);
            this.txtCpuNumber.TabIndex = 2;
            this.txtCpuNumber.TabStop = false;
            // 
            // txtCpuSpeed
            // 
            this.txtCpuSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtCpuSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtCpuSpeed.Location = new System.Drawing.Point(122, 163);
            this.txtCpuSpeed.Name = "txtCpuSpeed";
            this.txtCpuSpeed.ReadOnly = true;
            this.txtCpuSpeed.Size = new System.Drawing.Size(421, 25);
            this.txtCpuSpeed.TabIndex = 2;
            this.txtCpuSpeed.TabStop = false;
            // 
            // txtHddSize
            // 
            this.txtHddSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHddSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtHddSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHddSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtHddSize.Location = new System.Drawing.Point(122, 195);
            this.txtHddSize.Name = "txtHddSize";
            this.txtHddSize.ReadOnly = true;
            this.txtHddSize.Size = new System.Drawing.Size(421, 25);
            this.txtHddSize.TabIndex = 2;
            this.txtHddSize.TabStop = false;
            // 
            // txtGpuType
            // 
            this.txtGpuType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGpuType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtGpuType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtGpuType.Location = new System.Drawing.Point(122, 227);
            this.txtGpuType.Name = "txtGpuType";
            this.txtGpuType.ReadOnly = true;
            this.txtGpuType.Size = new System.Drawing.Size(421, 25);
            this.txtGpuType.TabIndex = 2;
            this.txtGpuType.TabStop = false;
            // 
            // txtWebcam
            // 
            this.txtWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebcam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtWebcam.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebcam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtWebcam.Location = new System.Drawing.Point(122, 259);
            this.txtWebcam.Name = "txtWebcam";
            this.txtWebcam.ReadOnly = true;
            this.txtWebcam.Size = new System.Drawing.Size(421, 25);
            this.txtWebcam.TabIndex = 2;
            this.txtWebcam.TabStop = false;
            // 
            // txtOperatingSystem
            // 
            this.txtOperatingSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperatingSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtOperatingSystem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperatingSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtOperatingSystem.Location = new System.Drawing.Point(122, 294);
            this.txtOperatingSystem.Name = "txtOperatingSystem";
            this.txtOperatingSystem.ReadOnly = true;
            this.txtOperatingSystem.Size = new System.Drawing.Size(421, 25);
            this.txtOperatingSystem.TabIndex = 2;
            this.txtOperatingSystem.TabStop = false;
            // 
            // tblComponentsSubI
            // 
            this.tblComponentsSubI.ColumnCount = 4;
            this.tblComponentsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.16091F));
            this.tblComponentsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83968F));
            this.tblComponentsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.15974F));
            this.tblComponentsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83968F));
            this.tblComponentsSubI.Controls.Add(this.txtCondition, 1, 0);
            this.tblComponentsSubI.Controls.Add(this.lblManufacturer, 0, 1);
            this.tblComponentsSubI.Controls.Add(this.lblCondition, 0, 0);
            this.tblComponentsSubI.Controls.Add(this.lblModel, 2, 1);
            this.tblComponentsSubI.Controls.Add(this.lblPlatform, 2, 0);
            this.tblComponentsSubI.Controls.Add(this.txtManufacturer, 1, 1);
            this.tblComponentsSubI.Controls.Add(this.txtPlatform, 3, 0);
            this.tblComponentsSubI.Controls.Add(this.txtModel, 3, 1);
            this.tblComponentsSubI.Location = new System.Drawing.Point(9, 24);
            this.tblComponentsSubI.Name = "tblComponentsSubI";
            this.tblComponentsSubI.RowCount = 2;
            this.tblComponentsSubI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComponentsSubI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComponentsSubI.Size = new System.Drawing.Size(546, 82);
            this.tblComponentsSubI.TabIndex = 1;
            // 
            // txtCondition
            // 
            this.txtCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtCondition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtCondition.Location = new System.Drawing.Point(123, 8);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(146, 25);
            this.txtCondition.TabIndex = 2;
            this.txtCondition.TabStop = false;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblManufacturer.Location = new System.Drawing.Point(11, 51);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(106, 21);
            this.lblManufacturer.TabIndex = 2;
            this.lblManufacturer.Text = "Manufacturer";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCondition
            // 
            this.lblCondition.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCondition.AutoSize = true;
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblCondition.Location = new System.Drawing.Point(40, 10);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(77, 21);
            this.lblCondition.TabIndex = 2;
            this.lblCondition.Text = "Condition";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblModel.Location = new System.Drawing.Point(334, 51);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 21);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlatform
            // 
            this.lblPlatform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblPlatform.Location = new System.Drawing.Point(319, 10);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(70, 21);
            this.lblPlatform.TabIndex = 2;
            this.lblPlatform.Text = "Platform";
            this.lblPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtManufacturer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtManufacturer.Location = new System.Drawing.Point(123, 49);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(146, 25);
            this.txtManufacturer.TabIndex = 2;
            this.txtManufacturer.TabStop = false;
            // 
            // txtPlatform
            // 
            this.txtPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlatform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtPlatform.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtPlatform.Location = new System.Drawing.Point(395, 8);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(148, 25);
            this.txtPlatform.TabIndex = 2;
            this.txtPlatform.TabStop = false;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtModel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtModel.Location = new System.Drawing.Point(395, 49);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(148, 25);
            this.txtModel.TabIndex = 2;
            this.txtModel.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 24);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(555, 437);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -8;
            this.lineShape1.X2 = 565;
            this.lineShape1.Y1 = 96;
            this.lineShape1.Y2 = 96;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(605, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // grpYourPrice
            // 
            this.grpYourPrice.Controls.Add(this.tblTotalPrice);
            this.grpYourPrice.Controls.Add(this.tblPrices);
            this.grpYourPrice.Controls.Add(this.shapeContainer2);
            this.grpYourPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.grpYourPrice.Location = new System.Drawing.Point(580, 199);
            this.grpYourPrice.Name = "grpYourPrice";
            this.grpYourPrice.Size = new System.Drawing.Size(190, 290);
            this.grpYourPrice.TabIndex = 12;
            this.grpYourPrice.TabStop = false;
            this.grpYourPrice.Text = "Your Price";
            // 
            // tblTotalPrice
            // 
            this.tblTotalPrice.ColumnCount = 2;
            this.tblTotalPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94382F));
            this.tblTotalPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.05618F));
            this.tblTotalPrice.Controls.Add(this.lblTotalPrice, 0, 0);
            this.tblTotalPrice.Controls.Add(this.txtTotalPrice, 1, 0);
            this.tblTotalPrice.Location = new System.Drawing.Point(6, 160);
            this.tblTotalPrice.Name = "tblTotalPrice";
            this.tblTotalPrice.RowCount = 1;
            this.tblTotalPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblTotalPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblTotalPrice.Size = new System.Drawing.Size(178, 40);
            this.tblTotalPrice.TabIndex = 1;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(3, 11);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(53, 21);
            this.lblTotalPrice.TabIndex = 2;
            this.lblTotalPrice.Text = "TOTAL";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtTotalPrice.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(83, 9);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(92, 25);
            this.txtTotalPrice.TabIndex = 2;
            this.txtTotalPrice.Text = "$0.00";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tblPrices
            // 
            this.tblPrices.ColumnCount = 2;
            this.tblPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.94382F));
            this.tblPrices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.05618F));
            this.tblPrices.Controls.Add(this.lblPrice, 0, 0);
            this.tblPrices.Controls.Add(this.lblSalesTax, 0, 1);
            this.tblPrices.Controls.Add(this.txtCost, 1, 0);
            this.tblPrices.Controls.Add(this.txtSalesTax, 1, 1);
            this.tblPrices.Location = new System.Drawing.Point(6, 27);
            this.tblPrices.Name = "tblPrices";
            this.tblPrices.RowCount = 2;
            this.tblPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tblPrices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tblPrices.Size = new System.Drawing.Size(178, 94);
            this.tblPrices.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(3, 11);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.lblSalesTax.Location = new System.Drawing.Point(3, 48);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(71, 42);
            this.lblSalesTax.TabIndex = 2;
            this.lblSalesTax.Text = "Sales Tax (13%)";
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtCost.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtCost.Location = new System.Drawing.Point(83, 9);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(92, 25);
            this.txtCost.TabIndex = 2;
            this.txtCost.Text = "$0.00";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalesTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.txtSalesTax.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.txtSalesTax.Location = new System.Drawing.Point(83, 56);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(92, 25);
            this.txtSalesTax.TabIndex = 2;
            this.txtSalesTax.Text = "$0.00";
            this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 24);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(184, 263);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = -8;
            this.lineShape2.X2 = 192;
            this.lineShape2.Y1 = 118;
            this.lineShape2.Y2 = 118;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.grpYourPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpSystemComponents);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.mnuOrder);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuOrder;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order - Dollar Computers";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.mnuOrder.ResumeLayout(false);
            this.mnuOrder.PerformLayout();
            this.grpSystemComponents.ResumeLayout(false);
            this.tblComponentsSubII.ResumeLayout(false);
            this.tblComponentsSubII.PerformLayout();
            this.tblComponentsSubI.ResumeLayout(false);
            this.tblComponentsSubI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpYourPrice.ResumeLayout(false);
            this.tblTotalPrice.ResumeLayout(false);
            this.tblTotalPrice.PerformLayout();
            this.tblPrices.ResumeLayout(false);
            this.tblPrices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOrder;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpSystemComponents;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TableLayoutPanel tblComponentsSubI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TableLayoutPanel tblComponentsSubII;
        private System.Windows.Forms.Label lblLcdSize;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblCpuBrand;
        private System.Windows.Forms.Label lblCpuType;
        private System.Windows.Forms.Label lblCpuNumber;
        private System.Windows.Forms.TextBox txtLcdSize;
        private System.Windows.Forms.Label lblCpuSpeed;
        private System.Windows.Forms.Label lblHddSize;
        private System.Windows.Forms.Label lblGpuType;
        private System.Windows.Forms.Label lblWebcam;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TextBox txtCpuBrand;
        private System.Windows.Forms.TextBox txtCpuType;
        private System.Windows.Forms.TextBox txtCpuNumber;
        private System.Windows.Forms.TextBox txtCpuSpeed;
        private System.Windows.Forms.TextBox txtHddSize;
        private System.Windows.Forms.TextBox txtGpuType;
        private System.Windows.Forms.TextBox txtWebcam;
        private System.Windows.Forms.TextBox txtOperatingSystem;
        private System.Windows.Forms.GroupBox grpYourPrice;
        private System.Windows.Forms.TableLayoutPanel tblTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TableLayoutPanel tblPrices;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtSalesTax;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}