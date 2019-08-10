namespace COMP123_2019_Assignment05.Forms {
    partial class ProductInfoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.mnuProductInfoForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblProductId = new System.Windows.Forms.TableLayoutPanel();
            this.lblProductId = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.tblProductInformationSubI = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.txtPlatform = new System.Windows.Forms.TextBox();
            this.txtOperatingSystem = new System.Windows.Forms.TextBox();
            this.grpTechnicalSpecifications = new System.Windows.Forms.GroupBox();
            this.tblTechnicalSpecificationsSubII = new System.Windows.Forms.TableLayoutPanel();
            this.lblCpuBrand = new System.Windows.Forms.Label();
            this.lblCpuNumber = new System.Windows.Forms.Label();
            this.txtCpuBrand = new System.Windows.Forms.TextBox();
            this.lblGpuType = new System.Windows.Forms.Label();
            this.txtGpuType = new System.Windows.Forms.TextBox();
            this.txtCpuNumber = new System.Windows.Forms.TextBox();
            this.tblTechnicalSpecificationsSubIII = new System.Windows.Forms.TableLayoutPanel();
            this.lblCpuType = new System.Windows.Forms.Label();
            this.lblCpuSpeed = new System.Windows.Forms.Label();
            this.txtCpuType = new System.Windows.Forms.TextBox();
            this.lblWebcam = new System.Windows.Forms.Label();
            this.txtWebcam = new System.Windows.Forms.TextBox();
            this.txtCpuSpeed = new System.Windows.Forms.TextBox();
            this.tblTechnicalSpecificationsSubI = new System.Windows.Forms.TableLayoutPanel();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblLcdSize = new System.Windows.Forms.Label();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.lblHddSize = new System.Windows.Forms.Label();
            this.txtHddSize = new System.Windows.Forms.TextBox();
            this.txtLcdSize = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblClickNextConfirm = new System.Windows.Forms.Label();
            this.btnSelectAnotherProduct = new System.Windows.Forms.Button();
            this.tblProductInformationSubII = new System.Windows.Forms.TableLayoutPanel();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.mnuProductInfoForm.SuspendLayout();
            this.tblProductId.SuspendLayout();
            this.grpProductInfo.SuspendLayout();
            this.tblProductInformationSubI.SuspendLayout();
            this.grpTechnicalSpecifications.SuspendLayout();
            this.tblTechnicalSpecificationsSubII.SuspendLayout();
            this.tblTechnicalSpecificationsSubIII.SuspendLayout();
            this.tblTechnicalSpecificationsSubI.SuspendLayout();
            this.tblProductInformationSubII.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProductInfoForm
            // 
            this.mnuProductInfoForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuProductInfoForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnuProductInfoForm.Location = new System.Drawing.Point(0, 0);
            this.mnuProductInfoForm.Name = "mnuProductInfoForm";
            this.mnuProductInfoForm.Size = new System.Drawing.Size(782, 27);
            this.mnuProductInfoForm.TabIndex = 0;
            this.mnuProductInfoForm.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(172, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.selectAllToolStripMenuItem.Text = "Se&lect Another Product";
            // 
            // tblProductId
            // 
            this.tblProductId.ColumnCount = 6;
            this.tblProductId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblProductId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblProductId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblProductId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblProductId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblProductId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblProductId.Controls.Add(this.lblProductId, 0, 0);
            this.tblProductId.Controls.Add(this.lblCondition, 2, 0);
            this.tblProductId.Controls.Add(this.lblCost, 4, 0);
            this.tblProductId.Controls.Add(this.txtProductId, 1, 0);
            this.tblProductId.Controls.Add(this.txtCondition, 3, 0);
            this.tblProductId.Controls.Add(this.txtCost, 5, 0);
            this.tblProductId.Location = new System.Drawing.Point(12, 30);
            this.tblProductId.Name = "tblProductId";
            this.tblProductId.RowCount = 1;
            this.tblProductId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProductId.Size = new System.Drawing.Size(758, 46);
            this.tblProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            this.lblProductId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(27, 12);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(83, 21);
            this.lblProductId.TabIndex = 0;
            this.lblProductId.Text = "Product ID";
            this.lblProductId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCondition
            // 
            this.lblCondition.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(284, 12);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(77, 21);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "Condition";
            this.lblCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(571, 12);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(41, 21);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(116, 10);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(132, 25);
            this.txtProductId.TabIndex = 1;
            this.txtProductId.TabStop = false;
            // 
            // txtCondition
            // 
            this.txtCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCondition.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondition.Location = new System.Drawing.Point(367, 10);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.ReadOnly = true;
            this.txtCondition.Size = new System.Drawing.Size(132, 25);
            this.txtCondition.TabIndex = 1;
            this.txtCondition.TabStop = false;
            // 
            // txtCost
            // 
            this.txtCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCost.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(618, 10);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(137, 25);
            this.txtCost.TabIndex = 1;
            this.txtCost.TabStop = false;
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.Controls.Add(this.tblProductInformationSubI);
            this.grpProductInfo.Location = new System.Drawing.Point(12, 83);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Size = new System.Drawing.Size(758, 138);
            this.grpProductInfo.TabIndex = 2;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "Product Information";
            // 
            // tblProductInformationSubI
            // 
            this.tblProductInformationSubI.ColumnCount = 4;
            this.tblProductInformationSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01677F));
            this.tblProductInformationSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.32045F));
            this.tblProductInformationSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01676F));
            this.tblProductInformationSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.64601F));
            this.tblProductInformationSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductInformationSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductInformationSubI.Controls.Add(this.lblPlatform, 0, 0);
            this.tblProductInformationSubI.Controls.Add(this.lblOperatingSystem, 2, 0);
            this.tblProductInformationSubI.Controls.Add(this.txtPlatform, 1, 0);
            this.tblProductInformationSubI.Controls.Add(this.txtOperatingSystem, 3, 0);
            this.tblProductInformationSubI.Location = new System.Drawing.Point(0, 27);
            this.tblProductInformationSubI.Name = "tblProductInformationSubI";
            this.tblProductInformationSubI.RowCount = 1;
            this.tblProductInformationSubI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProductInformationSubI.Size = new System.Drawing.Size(758, 46);
            this.tblProductInformationSubI.TabIndex = 1;
            // 
            // lblPlatform
            // 
            this.lblPlatform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(40, 12);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(70, 21);
            this.lblPlatform.TabIndex = 0;
            this.lblPlatform.Text = "Platform";
            this.lblPlatform.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Location = new System.Drawing.Point(332, 12);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(29, 21);
            this.lblOperatingSystem.TabIndex = 0;
            this.lblOperatingSystem.Text = "OS";
            this.lblOperatingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPlatform
            // 
            this.txtPlatform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlatform.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlatform.Location = new System.Drawing.Point(116, 10);
            this.txtPlatform.Name = "txtPlatform";
            this.txtPlatform.ReadOnly = true;
            this.txtPlatform.Size = new System.Drawing.Size(132, 25);
            this.txtPlatform.TabIndex = 1;
            this.txtPlatform.TabStop = false;
            // 
            // txtOperatingSystem
            // 
            this.txtOperatingSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperatingSystem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperatingSystem.Location = new System.Drawing.Point(367, 10);
            this.txtOperatingSystem.Name = "txtOperatingSystem";
            this.txtOperatingSystem.ReadOnly = true;
            this.txtOperatingSystem.Size = new System.Drawing.Size(388, 25);
            this.txtOperatingSystem.TabIndex = 1;
            this.txtOperatingSystem.TabStop = false;
            this.txtOperatingSystem.Text = "Windows 12";
            // 
            // grpTechnicalSpecifications
            // 
            this.grpTechnicalSpecifications.Controls.Add(this.tblTechnicalSpecificationsSubII);
            this.grpTechnicalSpecifications.Controls.Add(this.tblTechnicalSpecificationsSubIII);
            this.grpTechnicalSpecifications.Controls.Add(this.tblTechnicalSpecificationsSubI);
            this.grpTechnicalSpecifications.Location = new System.Drawing.Point(12, 227);
            this.grpTechnicalSpecifications.Name = "grpTechnicalSpecifications";
            this.grpTechnicalSpecifications.Size = new System.Drawing.Size(758, 190);
            this.grpTechnicalSpecifications.TabIndex = 2;
            this.grpTechnicalSpecifications.TabStop = false;
            this.grpTechnicalSpecifications.Text = "Technical Specifications";
            // 
            // tblTechnicalSpecificationsSubII
            // 
            this.tblTechnicalSpecificationsSubII.ColumnCount = 6;
            this.tblTechnicalSpecificationsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubII.Controls.Add(this.lblCpuBrand, 0, 0);
            this.tblTechnicalSpecificationsSubII.Controls.Add(this.lblCpuNumber, 2, 0);
            this.tblTechnicalSpecificationsSubII.Controls.Add(this.txtCpuBrand, 1, 0);
            this.tblTechnicalSpecificationsSubII.Controls.Add(this.lblGpuType, 4, 0);
            this.tblTechnicalSpecificationsSubII.Controls.Add(this.txtGpuType, 5, 0);
            this.tblTechnicalSpecificationsSubII.Controls.Add(this.txtCpuNumber, 3, 0);
            this.tblTechnicalSpecificationsSubII.Location = new System.Drawing.Point(0, 79);
            this.tblTechnicalSpecificationsSubII.Name = "tblTechnicalSpecificationsSubII";
            this.tblTechnicalSpecificationsSubII.RowCount = 1;
            this.tblTechnicalSpecificationsSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTechnicalSpecificationsSubII.Size = new System.Drawing.Size(758, 46);
            this.tblTechnicalSpecificationsSubII.TabIndex = 1;
            // 
            // lblCpuBrand
            // 
            this.lblCpuBrand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuBrand.AutoSize = true;
            this.lblCpuBrand.Location = new System.Drawing.Point(26, 12);
            this.lblCpuBrand.Name = "lblCpuBrand";
            this.lblCpuBrand.Size = new System.Drawing.Size(84, 21);
            this.lblCpuBrand.TabIndex = 0;
            this.lblCpuBrand.Text = "CPU Brand";
            this.lblCpuBrand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuNumber
            // 
            this.lblCpuNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuNumber.AutoSize = true;
            this.lblCpuNumber.Location = new System.Drawing.Point(261, 12);
            this.lblCpuNumber.Name = "lblCpuNumber";
            this.lblCpuNumber.Size = new System.Drawing.Size(100, 21);
            this.lblCpuNumber.TabIndex = 0;
            this.lblCpuNumber.Text = "CPU Number";
            this.lblCpuNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCpuBrand
            // 
            this.txtCpuBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuBrand.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuBrand.Location = new System.Drawing.Point(116, 10);
            this.txtCpuBrand.Name = "txtCpuBrand";
            this.txtCpuBrand.ReadOnly = true;
            this.txtCpuBrand.Size = new System.Drawing.Size(132, 25);
            this.txtCpuBrand.TabIndex = 1;
            this.txtCpuBrand.TabStop = false;
            // 
            // lblGpuType
            // 
            this.lblGpuType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGpuType.AutoSize = true;
            this.lblGpuType.Location = new System.Drawing.Point(535, 12);
            this.lblGpuType.Name = "lblGpuType";
            this.lblGpuType.Size = new System.Drawing.Size(77, 21);
            this.lblGpuType.TabIndex = 0;
            this.lblGpuType.Text = "GPU Type";
            this.lblGpuType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGpuType
            // 
            this.txtGpuType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGpuType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpuType.Location = new System.Drawing.Point(618, 10);
            this.txtGpuType.Name = "txtGpuType";
            this.txtGpuType.ReadOnly = true;
            this.txtGpuType.Size = new System.Drawing.Size(137, 25);
            this.txtGpuType.TabIndex = 1;
            this.txtGpuType.TabStop = false;
            // 
            // txtCpuNumber
            // 
            this.txtCpuNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuNumber.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuNumber.Location = new System.Drawing.Point(367, 10);
            this.txtCpuNumber.Name = "txtCpuNumber";
            this.txtCpuNumber.ReadOnly = true;
            this.txtCpuNumber.Size = new System.Drawing.Size(132, 25);
            this.txtCpuNumber.TabIndex = 1;
            this.txtCpuNumber.TabStop = false;
            // 
            // tblTechnicalSpecificationsSubIII
            // 
            this.tblTechnicalSpecificationsSubIII.ColumnCount = 6;
            this.tblTechnicalSpecificationsSubIII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubIII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubIII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubIII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubIII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubIII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubIII.Controls.Add(this.lblCpuType, 0, 0);
            this.tblTechnicalSpecificationsSubIII.Controls.Add(this.lblCpuSpeed, 2, 0);
            this.tblTechnicalSpecificationsSubIII.Controls.Add(this.txtCpuType, 1, 0);
            this.tblTechnicalSpecificationsSubIII.Controls.Add(this.lblWebcam, 4, 0);
            this.tblTechnicalSpecificationsSubIII.Controls.Add(this.txtWebcam, 5, 0);
            this.tblTechnicalSpecificationsSubIII.Controls.Add(this.txtCpuSpeed, 3, 0);
            this.tblTechnicalSpecificationsSubIII.Location = new System.Drawing.Point(0, 131);
            this.tblTechnicalSpecificationsSubIII.Name = "tblTechnicalSpecificationsSubIII";
            this.tblTechnicalSpecificationsSubIII.RowCount = 1;
            this.tblTechnicalSpecificationsSubIII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTechnicalSpecificationsSubIII.Size = new System.Drawing.Size(758, 46);
            this.tblTechnicalSpecificationsSubIII.TabIndex = 1;
            // 
            // lblCpuType
            // 
            this.lblCpuType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuType.AutoSize = true;
            this.lblCpuType.Location = new System.Drawing.Point(35, 12);
            this.lblCpuType.Name = "lblCpuType";
            this.lblCpuType.Size = new System.Drawing.Size(75, 21);
            this.lblCpuType.TabIndex = 0;
            this.lblCpuType.Text = "CPU Type";
            this.lblCpuType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCpuSpeed
            // 
            this.lblCpuSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCpuSpeed.AutoSize = true;
            this.lblCpuSpeed.Location = new System.Drawing.Point(276, 12);
            this.lblCpuSpeed.Name = "lblCpuSpeed";
            this.lblCpuSpeed.Size = new System.Drawing.Size(85, 21);
            this.lblCpuSpeed.TabIndex = 0;
            this.lblCpuSpeed.Text = "CPU Speed";
            this.lblCpuSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCpuType
            // 
            this.txtCpuType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuType.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuType.Location = new System.Drawing.Point(116, 10);
            this.txtCpuType.Name = "txtCpuType";
            this.txtCpuType.ReadOnly = true;
            this.txtCpuType.Size = new System.Drawing.Size(132, 25);
            this.txtCpuType.TabIndex = 1;
            this.txtCpuType.TabStop = false;
            // 
            // lblWebcam
            // 
            this.lblWebcam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWebcam.AutoSize = true;
            this.lblWebcam.Location = new System.Drawing.Point(542, 12);
            this.lblWebcam.Name = "lblWebcam";
            this.lblWebcam.Size = new System.Drawing.Size(70, 21);
            this.lblWebcam.TabIndex = 0;
            this.lblWebcam.Text = "Webcam";
            this.lblWebcam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWebcam
            // 
            this.txtWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebcam.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebcam.Location = new System.Drawing.Point(618, 10);
            this.txtWebcam.Name = "txtWebcam";
            this.txtWebcam.ReadOnly = true;
            this.txtWebcam.Size = new System.Drawing.Size(137, 25);
            this.txtWebcam.TabIndex = 1;
            this.txtWebcam.TabStop = false;
            // 
            // txtCpuSpeed
            // 
            this.txtCpuSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpuSpeed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpuSpeed.Location = new System.Drawing.Point(367, 10);
            this.txtCpuSpeed.Name = "txtCpuSpeed";
            this.txtCpuSpeed.ReadOnly = true;
            this.txtCpuSpeed.Size = new System.Drawing.Size(132, 25);
            this.txtCpuSpeed.TabIndex = 1;
            this.txtCpuSpeed.TabStop = false;
            // 
            // tblTechnicalSpecificationsSubI
            // 
            this.tblTechnicalSpecificationsSubI.ColumnCount = 6;
            this.tblTechnicalSpecificationsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01502F));
            this.tblTechnicalSpecificationsSubI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31832F));
            this.tblTechnicalSpecificationsSubI.Controls.Add(this.lblMemory, 0, 0);
            this.tblTechnicalSpecificationsSubI.Controls.Add(this.lblLcdSize, 2, 0);
            this.tblTechnicalSpecificationsSubI.Controls.Add(this.txtMemory, 1, 0);
            this.tblTechnicalSpecificationsSubI.Controls.Add(this.lblHddSize, 4, 0);
            this.tblTechnicalSpecificationsSubI.Controls.Add(this.txtHddSize, 5, 0);
            this.tblTechnicalSpecificationsSubI.Controls.Add(this.txtLcdSize, 3, 0);
            this.tblTechnicalSpecificationsSubI.Location = new System.Drawing.Point(0, 27);
            this.tblTechnicalSpecificationsSubI.Name = "tblTechnicalSpecificationsSubI";
            this.tblTechnicalSpecificationsSubI.RowCount = 1;
            this.tblTechnicalSpecificationsSubI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTechnicalSpecificationsSubI.Size = new System.Drawing.Size(758, 46);
            this.tblTechnicalSpecificationsSubI.TabIndex = 1;
            // 
            // lblMemory
            // 
            this.lblMemory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(40, 12);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(70, 21);
            this.lblMemory.TabIndex = 0;
            this.lblMemory.Text = "Memory";
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLcdSize
            // 
            this.lblLcdSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLcdSize.AutoSize = true;
            this.lblLcdSize.Location = new System.Drawing.Point(294, 12);
            this.lblLcdSize.Name = "lblLcdSize";
            this.lblLcdSize.Size = new System.Drawing.Size(67, 21);
            this.lblLcdSize.TabIndex = 0;
            this.lblLcdSize.Text = "LCD Size";
            this.lblLcdSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMemory
            // 
            this.txtMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemory.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemory.Location = new System.Drawing.Point(116, 10);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.ReadOnly = true;
            this.txtMemory.Size = new System.Drawing.Size(132, 25);
            this.txtMemory.TabIndex = 1;
            this.txtMemory.TabStop = false;
            // 
            // lblHddSize
            // 
            this.lblHddSize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHddSize.AutoSize = true;
            this.lblHddSize.Location = new System.Drawing.Point(571, 12);
            this.lblHddSize.Name = "lblHddSize";
            this.lblHddSize.Size = new System.Drawing.Size(41, 21);
            this.lblHddSize.TabIndex = 0;
            this.lblHddSize.Text = "HDD";
            this.lblHddSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHddSize
            // 
            this.txtHddSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHddSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHddSize.Location = new System.Drawing.Point(618, 10);
            this.txtHddSize.Name = "txtHddSize";
            this.txtHddSize.ReadOnly = true;
            this.txtHddSize.Size = new System.Drawing.Size(137, 25);
            this.txtHddSize.TabIndex = 1;
            this.txtHddSize.TabStop = false;
            // 
            // txtLcdSize
            // 
            this.txtLcdSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLcdSize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLcdSize.Location = new System.Drawing.Point(367, 10);
            this.txtLcdSize.Name = "txtLcdSize";
            this.txtLcdSize.ReadOnly = true;
            this.txtLcdSize.Size = new System.Drawing.Size(132, 25);
            this.txtLcdSize.TabIndex = 1;
            this.txtLcdSize.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(580, 501);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(678, 501);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 40);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblClickNextConfirm
            // 
            this.lblClickNextConfirm.AutoSize = true;
            this.lblClickNextConfirm.Location = new System.Drawing.Point(8, 511);
            this.lblClickNextConfirm.Name = "lblClickNextConfirm";
            this.lblClickNextConfirm.Size = new System.Drawing.Size(258, 21);
            this.lblClickNextConfirm.TabIndex = 5;
            this.lblClickNextConfirm.Text = "Click next to confirm your selection.";
            // 
            // btnSelectAnotherProduct
            // 
            this.btnSelectAnotherProduct.Location = new System.Drawing.Point(379, 501);
            this.btnSelectAnotherProduct.Name = "btnSelectAnotherProduct";
            this.btnSelectAnotherProduct.Size = new System.Drawing.Size(195, 40);
            this.btnSelectAnotherProduct.TabIndex = 6;
            this.btnSelectAnotherProduct.Text = "Select Another Product";
            this.btnSelectAnotherProduct.UseVisualStyleBackColor = true;
            this.btnSelectAnotherProduct.Click += new System.EventHandler(this.BtnSelectAnotherProduct_Click);
            // 
            // tblProductInformationSubII
            // 
            this.tblProductInformationSubII.ColumnCount = 4;
            this.tblProductInformationSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01677F));
            this.tblProductInformationSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.32045F));
            this.tblProductInformationSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.01676F));
            this.tblProductInformationSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.64601F));
            this.tblProductInformationSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductInformationSubII.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblProductInformationSubII.Controls.Add(this.lblManufacturer, 0, 0);
            this.tblProductInformationSubII.Controls.Add(this.lblModel, 2, 0);
            this.tblProductInformationSubII.Controls.Add(this.txtManufacturer, 1, 0);
            this.tblProductInformationSubII.Controls.Add(this.txtModel, 3, 0);
            this.tblProductInformationSubII.Location = new System.Drawing.Point(12, 162);
            this.tblProductInformationSubII.Name = "tblProductInformationSubII";
            this.tblProductInformationSubII.RowCount = 1;
            this.tblProductInformationSubII.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProductInformationSubII.Size = new System.Drawing.Size(758, 46);
            this.tblProductInformationSubII.TabIndex = 1;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(4, 12);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(106, 21);
            this.lblManufacturer.TabIndex = 0;
            this.lblManufacturer.Text = "Manufacturer";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModel
            // 
            this.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(306, 12);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(55, 21);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManufacturer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(116, 10);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.ReadOnly = true;
            this.txtManufacturer.Size = new System.Drawing.Size(132, 25);
            this.txtManufacturer.TabIndex = 1;
            this.txtManufacturer.TabStop = false;
            // 
            // txtModel
            // 
            this.txtModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(367, 10);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(388, 25);
            this.txtModel.TabIndex = 1;
            this.txtModel.TabStop = false;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.ControlBox = false;
            this.Controls.Add(this.tblProductInformationSubII);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectAnotherProduct);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblClickNextConfirm);
            this.Controls.Add(this.grpTechnicalSpecifications);
            this.Controls.Add(this.grpProductInfo);
            this.Controls.Add(this.tblProductId);
            this.Controls.Add(this.mnuProductInfoForm);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuProductInfoForm;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information - Dollar Computers";
            this.mnuProductInfoForm.ResumeLayout(false);
            this.mnuProductInfoForm.PerformLayout();
            this.tblProductId.ResumeLayout(false);
            this.tblProductId.PerformLayout();
            this.grpProductInfo.ResumeLayout(false);
            this.tblProductInformationSubI.ResumeLayout(false);
            this.tblProductInformationSubI.PerformLayout();
            this.grpTechnicalSpecifications.ResumeLayout(false);
            this.tblTechnicalSpecificationsSubII.ResumeLayout(false);
            this.tblTechnicalSpecificationsSubII.PerformLayout();
            this.tblTechnicalSpecificationsSubIII.ResumeLayout(false);
            this.tblTechnicalSpecificationsSubIII.PerformLayout();
            this.tblTechnicalSpecificationsSubI.ResumeLayout(false);
            this.tblTechnicalSpecificationsSubI.PerformLayout();
            this.tblProductInformationSubII.ResumeLayout(false);
            this.tblProductInformationSubII.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProductInfoForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tblProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.TableLayoutPanel tblProductInformationSubI;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.GroupBox grpTechnicalSpecifications;
        private System.Windows.Forms.TableLayoutPanel tblTechnicalSpecificationsSubI;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblClickNextConfirm;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.TableLayoutPanel tblTechnicalSpecificationsSubII;
        private System.Windows.Forms.Label lblCpuBrand;
        private System.Windows.Forms.TableLayoutPanel tblTechnicalSpecificationsSubIII;
        private System.Windows.Forms.Label lblCpuType;
        private System.Windows.Forms.Button btnSelectAnotherProduct;
        private System.Windows.Forms.TableLayoutPanel tblProductInformationSubII;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPlatform;
        private System.Windows.Forms.TextBox txtOperatingSystem;
        private System.Windows.Forms.Label lblCpuNumber;
        private System.Windows.Forms.TextBox txtCpuBrand;
        private System.Windows.Forms.Label lblGpuType;
        private System.Windows.Forms.TextBox txtGpuType;
        private System.Windows.Forms.TextBox txtCpuNumber;
        private System.Windows.Forms.Label lblCpuSpeed;
        private System.Windows.Forms.TextBox txtCpuType;
        private System.Windows.Forms.Label lblWebcam;
        private System.Windows.Forms.TextBox txtWebcam;
        private System.Windows.Forms.TextBox txtCpuSpeed;
        private System.Windows.Forms.Label lblLcdSize;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.Label lblHddSize;
        private System.Windows.Forms.TextBox txtHddSize;
        private System.Windows.Forms.TextBox txtLcdSize;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblManufacturer;
    }
}