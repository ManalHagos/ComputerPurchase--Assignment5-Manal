namespace ComputerPurchase.Views
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.Condition = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.ProductInfoBox = new System.Windows.Forms.GroupBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.TextBox();
            this.OS = new System.Windows.Forms.TextBox();
            this.Manufaturer = new System.Windows.Forms.TextBox();
            this.PlatForm = new System.Windows.Forms.TextBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatFormlabel = new System.Windows.Forms.Label();
            this.TechBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.WebCamBox = new System.Windows.Forms.TextBox();
            this.HDDtBox = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.GPUBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.BrandBox = new System.Windows.Forms.TextBox();
            this.MemoryBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.AnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.ProductInfoBox.SuspendLayout();
            this.TechBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1251, 35);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(278, 30);
            this.sToolStripMenuItem.Text = "Select Another Product";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.AnotherProductButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(19, 78);
            this.ProductIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(103, 25);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(448, 83);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(95, 25);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(832, 78);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(53, 25);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // Condition
            // 
            this.Condition.Location = new System.Drawing.Point(590, 77);
            this.Condition.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(153, 35);
            this.Condition.TabIndex = 4;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(187, 78);
            this.Product.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(153, 35);
            this.Product.TabIndex = 4;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(915, 77);
            this.Cost.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(153, 35);
            this.Cost.TabIndex = 4;
            // 
            // ProductInfoBox
            // 
            this.ProductInfoBox.Controls.Add(this.OSLabel);
            this.ProductInfoBox.Controls.Add(this.ModelLabel);
            this.ProductInfoBox.Controls.Add(this.Model);
            this.ProductInfoBox.Controls.Add(this.OS);
            this.ProductInfoBox.Controls.Add(this.Manufaturer);
            this.ProductInfoBox.Controls.Add(this.PlatForm);
            this.ProductInfoBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoBox.Controls.Add(this.PlatFormlabel);
            this.ProductInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductInfoBox.Location = new System.Drawing.Point(26, 152);
            this.ProductInfoBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductInfoBox.Name = "ProductInfoBox";
            this.ProductInfoBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductInfoBox.Size = new System.Drawing.Size(1106, 151);
            this.ProductInfoBox.TabIndex = 5;
            this.ProductInfoBox.TabStop = false;
            this.ProductInfoBox.Text = "Product Info";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(475, 37);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(42, 25);
            this.OSLabel.TabIndex = 0;
            this.OSLabel.Text = "OS";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(457, 88);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(66, 25);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(564, 88);
            this.Model.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(478, 30);
            this.Model.TabIndex = 4;
            // 
            // OS
            // 
            this.OS.Location = new System.Drawing.Point(564, 34);
            this.OS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(478, 30);
            this.OS.TabIndex = 4;
            // 
            // Manufaturer
            // 
            this.Manufaturer.Location = new System.Drawing.Point(161, 90);
            this.Manufaturer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Manufaturer.Name = "Manufaturer";
            this.Manufaturer.Size = new System.Drawing.Size(153, 30);
            this.Manufaturer.TabIndex = 4;
            // 
            // PlatForm
            // 
            this.PlatForm.Location = new System.Drawing.Point(161, 31);
            this.PlatForm.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlatForm.Name = "PlatForm";
            this.PlatForm.Size = new System.Drawing.Size(153, 30);
            this.PlatForm.TabIndex = 4;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(9, 90);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(127, 25);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatFormlabel
            // 
            this.PlatFormlabel.AutoSize = true;
            this.PlatFormlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatFormlabel.Location = new System.Drawing.Point(46, 37);
            this.PlatFormlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlatFormlabel.Name = "PlatFormlabel";
            this.PlatFormlabel.Size = new System.Drawing.Size(90, 25);
            this.PlatFormlabel.TabIndex = 0;
            this.PlatFormlabel.Text = "PlatForm";
            // 
            // TechBox
            // 
            this.TechBox.Controls.Add(this.label7);
            this.TechBox.Controls.Add(this.HDDLabel);
            this.TechBox.Controls.Add(this.GPULabel);
            this.TechBox.Controls.Add(this.SpeedLabel);
            this.TechBox.Controls.Add(this.WebCamBox);
            this.TechBox.Controls.Add(this.HDDtBox);
            this.TechBox.Controls.Add(this.speed);
            this.TechBox.Controls.Add(this.GPUBox);
            this.TechBox.Controls.Add(this.TypeBox);
            this.TechBox.Controls.Add(this.number);
            this.TechBox.Controls.Add(this.size);
            this.TechBox.Controls.Add(this.BrandBox);
            this.TechBox.Controls.Add(this.MemoryBox);
            this.TechBox.Controls.Add(this.NumberLabel);
            this.TechBox.Controls.Add(this.SizeLabel);
            this.TechBox.Controls.Add(this.label3);
            this.TechBox.Controls.Add(this.CPULabel);
            this.TechBox.Controls.Add(this.MemoryLabel);
            this.TechBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechBox.Location = new System.Drawing.Point(26, 329);
            this.TechBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TechBox.Name = "TechBox";
            this.TechBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TechBox.Size = new System.Drawing.Size(1106, 180);
            this.TechBox.TabIndex = 6;
            this.TechBox.TabStop = false;
            this.TechBox.Text = "Tech Specs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "WebCam";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(775, 29);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(54, 25);
            this.HDDLabel.TabIndex = 0;
            this.HDDLabel.Text = "HDD";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Location = new System.Drawing.Point(775, 87);
            this.GPULabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(104, 25);
            this.GPULabel.TabIndex = 0;
            this.GPULabel.Text = "GPU Type";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(406, 139);
            this.SpeedLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(117, 25);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "CPU Speed";
            // 
            // WebCamBox
            // 
            this.WebCamBox.Location = new System.Drawing.Point(898, 134);
            this.WebCamBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.WebCamBox.Name = "WebCamBox";
            this.WebCamBox.Size = new System.Drawing.Size(153, 30);
            this.WebCamBox.TabIndex = 4;
            // 
            // HDDtBox
            // 
            this.HDDtBox.Location = new System.Drawing.Point(898, 25);
            this.HDDtBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.HDDtBox.Name = "HDDtBox";
            this.HDDtBox.Size = new System.Drawing.Size(156, 30);
            this.HDDtBox.TabIndex = 4;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(564, 136);
            this.speed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(153, 30);
            this.speed.TabIndex = 4;
            // 
            // GPUBox
            // 
            this.GPUBox.Location = new System.Drawing.Point(898, 84);
            this.GPUBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GPUBox.Name = "GPUBox";
            this.GPUBox.Size = new System.Drawing.Size(153, 30);
            this.GPUBox.TabIndex = 4;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(161, 129);
            this.TypeBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(153, 30);
            this.TypeBox.TabIndex = 4;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(564, 82);
            this.number.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(153, 30);
            this.number.TabIndex = 4;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(564, 24);
            this.size.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(153, 30);
            this.size.TabIndex = 4;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(161, 78);
            this.BrandBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(153, 30);
            this.BrandBox.TabIndex = 4;
            // 
            // MemoryBox
            // 
            this.MemoryBox.Location = new System.Drawing.Point(161, 29);
            this.MemoryBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Size = new System.Drawing.Size(153, 30);
            this.MemoryBox.TabIndex = 4;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(406, 83);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(128, 25);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "CPU Number";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(406, 32);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(96, 25);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "LCD Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU Type";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(8, 83);
            this.CPULabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(111, 25);
            this.CPULabel.TabIndex = 0;
            this.CPULabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(8, 38);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(83, 25);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionLabel.Location = new System.Drawing.Point(19, 564);
            this.YourSelectionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(321, 25);
            this.YourSelectionLabel.TabIndex = 0;
            this.YourSelectionLabel.Text = "Click Next To Cofirm Your Selection";
            // 
            // AnotherProductButton
            // 
            this.AnotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherProductButton.Location = new System.Drawing.Point(580, 551);
            this.AnotherProductButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AnotherProductButton.Name = "AnotherProductButton";
            this.AnotherProductButton.Size = new System.Drawing.Size(222, 46);
            this.AnotherProductButton.TabIndex = 7;
            this.AnotherProductButton.Text = "Select Another Product";
            this.AnotherProductButton.UseVisualStyleBackColor = true;
            this.AnotherProductButton.Click += new System.EventHandler(this.AnotherProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(853, 551);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 46);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(1015, 551);
            this.NextButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(117, 46);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 653);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AnotherProductButton);
            this.Controls.Add(this.TechBox);
            this.Controls.Add(this.ProductInfoBox);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.YourSelectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ProductInfoBox.ResumeLayout(false);
            this.ProductInfoBox.PerformLayout();
            this.TechBox.ResumeLayout(false);
            this.TechBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox Condition;
        private System.Windows.Forms.TextBox Product;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.GroupBox ProductInfoBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox OS;
        private System.Windows.Forms.TextBox Manufaturer;
        private System.Windows.Forms.TextBox PlatForm;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatFormlabel;
        private System.Windows.Forms.GroupBox TechBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.TextBox WebCamBox;
        private System.Windows.Forms.TextBox HDDtBox;
        private System.Windows.Forms.TextBox speed;
        private System.Windows.Forms.TextBox GPUBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox MemoryBox;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.Button AnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}