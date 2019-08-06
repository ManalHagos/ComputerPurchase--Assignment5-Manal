namespace ComputerPurchase.Views
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemBox = new System.Windows.Forms.GroupBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CpuBrandLabel = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.PlatFormBox = new System.Windows.Forms.TextBox();
            this.ManufacturerBox = new System.Windows.Forms.TextBox();
            this.ConditionBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatFormLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.GroupBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SaleTaxsLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderMenuStrip.SuspendLayout();
            this.SystemBox.SuspendLayout();
            this.PriceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderMenuStrip
            // 
            this.OrderMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.OrderMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderMenuStrip.Name = "OrderMenuStrip";
            this.OrderMenuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.OrderMenuStrip.Size = new System.Drawing.Size(1244, 35);
            this.OrderMenuStrip.TabIndex = 0;
            this.OrderMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(132, 30);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemBox
            // 
            this.SystemBox.Controls.Add(this.richTextBox);
            this.SystemBox.Controls.Add(this.OSLabel);
            this.SystemBox.Controls.Add(this.WebCamLabel);
            this.SystemBox.Controls.Add(this.GPUTypeLabel);
            this.SystemBox.Controls.Add(this.HDDLabel);
            this.SystemBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemBox.Controls.Add(this.CPUNumberLabel);
            this.SystemBox.Controls.Add(this.CPUTypeLabel);
            this.SystemBox.Controls.Add(this.CpuBrandLabel);
            this.SystemBox.Controls.Add(this.Memory);
            this.SystemBox.Controls.Add(this.Size);
            this.SystemBox.Controls.Add(this.ModelBox);
            this.SystemBox.Controls.Add(this.PlatFormBox);
            this.SystemBox.Controls.Add(this.ManufacturerBox);
            this.SystemBox.Controls.Add(this.ConditionBox);
            this.SystemBox.Controls.Add(this.ModelLabel);
            this.SystemBox.Controls.Add(this.PlatFormLabel);
            this.SystemBox.Controls.Add(this.ManufacturerLabel);
            this.SystemBox.Controls.Add(this.ConditionLabel);
            this.SystemBox.Location = new System.Drawing.Point(0, 45);
            this.SystemBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SystemBox.Name = "SystemBox";
            this.SystemBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SystemBox.Size = new System.Drawing.Size(662, 583);
            this.SystemBox.TabIndex = 1;
            this.SystemBox.TabStop = false;
            this.SystemBox.Text = "Sustem Components";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(204, 139);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(443, 430);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(36, 542);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(48, 29);
            this.OSLabel.TabIndex = 4;
            this.OSLabel.Text = "OS";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Location = new System.Drawing.Point(33, 497);
            this.WebCamLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(113, 29);
            this.WebCamLabel.TabIndex = 3;
            this.WebCamLabel.Text = "WebCam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(33, 454);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(125, 29);
            this.GPUTypeLabel.TabIndex = 2;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(36, 409);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(64, 29);
            this.HDDLabel.TabIndex = 2;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(36, 361);
            this.CPUSpeedLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(141, 29);
            this.CPUSpeedLabel.TabIndex = 2;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(36, 313);
            this.CPUNumberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(156, 29);
            this.CPUNumberLabel.TabIndex = 2;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(36, 270);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(124, 29);
            this.CPUTypeLabel.TabIndex = 2;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CpuBrandLabel
            // 
            this.CpuBrandLabel.AutoSize = true;
            this.CpuBrandLabel.Location = new System.Drawing.Point(33, 228);
            this.CpuBrandLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CpuBrandLabel.Name = "CpuBrandLabel";
            this.CpuBrandLabel.Size = new System.Drawing.Size(133, 29);
            this.CpuBrandLabel.TabIndex = 2;
            this.CpuBrandLabel.Text = "CPU Brand";
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(33, 186);
            this.Memory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(100, 29);
            this.Memory.TabIndex = 2;
            this.Memory.Text = "Memory";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(36, 141);
            this.Size.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(113, 29);
            this.Size.TabIndex = 2;
            this.Size.Text = "LCD Size";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(493, 93);
            this.ModelBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(153, 35);
            this.ModelBox.TabIndex = 1;
            // 
            // PlatFormBox
            // 
            this.PlatFormBox.Location = new System.Drawing.Point(493, 32);
            this.PlatFormBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PlatFormBox.Name = "PlatFormBox";
            this.PlatFormBox.Size = new System.Drawing.Size(153, 35);
            this.PlatFormBox.TabIndex = 1;
            // 
            // ManufacturerBox
            // 
            this.ManufacturerBox.Location = new System.Drawing.Point(180, 84);
            this.ManufacturerBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ManufacturerBox.Name = "ManufacturerBox";
            this.ManufacturerBox.Size = new System.Drawing.Size(153, 35);
            this.ManufacturerBox.TabIndex = 1;
            // 
            // ConditionBox
            // 
            this.ConditionBox.Location = new System.Drawing.Point(180, 36);
            this.ConditionBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ConditionBox.Name = "ConditionBox";
            this.ConditionBox.Size = new System.Drawing.Size(153, 35);
            this.ConditionBox.TabIndex = 1;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(370, 97);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(81, 29);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // PlatFormLabel
            // 
            this.PlatFormLabel.AutoSize = true;
            this.PlatFormLabel.Location = new System.Drawing.Point(370, 41);
            this.PlatFormLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PlatFormLabel.Name = "PlatFormLabel";
            this.PlatFormLabel.Size = new System.Drawing.Size(111, 29);
            this.PlatFormLabel.TabIndex = 0;
            this.PlatFormLabel.Text = "PlatForm";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(9, 97);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(152, 29);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(19, 42);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(116, 29);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // PriceBox
            // 
            this.PriceBox.Controls.Add(this.PriceTextBox);
            this.PriceBox.Controls.Add(this.TotalTextBox);
            this.PriceBox.Controls.Add(this.SalesTextBox);
            this.PriceBox.Controls.Add(this.TotalLabel);
            this.PriceBox.Controls.Add(this.SaleTaxsLabel);
            this.PriceBox.Controls.Add(this.PriceLabel);
            this.PriceBox.Controls.Add(this.shapeContainer1);
            this.PriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBox.Location = new System.Drawing.Point(697, 265);
            this.PriceBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceBox.Size = new System.Drawing.Size(503, 225);
            this.PriceBox.TabIndex = 2;
            this.PriceBox.TabStop = false;
            this.PriceBox.Text = "Your Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(222, 41);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(153, 30);
            this.PriceTextBox.TabIndex = 3;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(222, 174);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(153, 30);
            this.TotalTextBox.TabIndex = 3;
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Location = new System.Drawing.Point(222, 91);
            this.SalesTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(153, 30);
            this.SalesTextBox.TabIndex = 3;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(11, 174);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(56, 25);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total";
            // 
            // SaleTaxsLabel
            // 
            this.SaleTaxsLabel.AutoSize = true;
            this.SaleTaxsLabel.Location = new System.Drawing.Point(11, 94);
            this.SaleTaxsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SaleTaxsLabel.Name = "SaleTaxsLabel";
            this.SaleTaxsLabel.Size = new System.Drawing.Size(170, 25);
            this.SaleTaxsLabel.TabIndex = 1;
            this.SaleTaxsLabel.Text = "Sales Taxs (13%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(11, 44);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 25);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(5, 27);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer1.Size = new System.Drawing.Size(493, 194);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 2;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 10;
            this.TotalLine.X2 = 467;
            this.TotalLine.Y1 = 111;
            this.TotalLine.Y2 = 111;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(697, 571);
            this.BackButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 57);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(877, 571);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 57);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Location = new System.Drawing.Point(1060, 571);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(140, 57);
            this.FinishButton.TabIndex = 3;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(697, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 183);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 641);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.SystemBox);
            this.Controls.Add(this.OrderMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.OrderMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderMenuStrip.ResumeLayout(false);
            this.OrderMenuStrip.PerformLayout();
            this.SystemBox.ResumeLayout(false);
            this.SystemBox.PerformLayout();
            this.PriceBox.ResumeLayout(false);
            this.PriceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox PlatFormBox;
        private System.Windows.Forms.TextBox ManufacturerBox;
        private System.Windows.Forms.TextBox ConditionBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatFormLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.GroupBox PriceBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SaleTaxsLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CpuBrandLabel;
        private System.Windows.Forms.Label Memory;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.RichTextBox richTextBox;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}