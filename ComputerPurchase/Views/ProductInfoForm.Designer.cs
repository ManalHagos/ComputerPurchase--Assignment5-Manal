namespace ComputerPurchase
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.GPUBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.menuStrip.Size = new System.Drawing.Size(804, 33);
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.exitToolStripMenuItem.Text = "Exit";
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
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDLabel.Location = new System.Drawing.Point(12, 54);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(103, 25);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.Location = new System.Drawing.Point(278, 54);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(95, 25);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(535, 54);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(53, 25);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost";
            // 
            // Condition
            // 
            this.Condition.Location = new System.Drawing.Point(379, 53);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(100, 26);
            this.Condition.TabIndex = 4;
            // 
            // Product
            // 
            this.Product.Location = new System.Drawing.Point(159, 53);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 26);
            this.Product.TabIndex = 4;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(594, 53);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 26);
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
            this.ProductInfoBox.Location = new System.Drawing.Point(17, 105);
            this.ProductInfoBox.Name = "ProductInfoBox";
            this.ProductInfoBox.Size = new System.Drawing.Size(771, 104);
            this.ProductInfoBox.TabIndex = 5;
            this.ProductInfoBox.TabStop = false;
            this.ProductInfoBox.Text = "Product Info";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSLabel.Location = new System.Drawing.Point(314, 21);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(42, 25);
            this.OSLabel.TabIndex = 0;
            this.OSLabel.Text = "OS";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(290, 61);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(66, 25);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(370, 61);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(395, 30);
            this.Model.TabIndex = 4;
            // 
            // OS
            // 
            this.OS.Location = new System.Drawing.Point(370, 22);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(395, 30);
            this.OS.TabIndex = 4;
            // 
            // Manufaturer
            // 
            this.Manufaturer.Location = new System.Drawing.Point(139, 61);
            this.Manufaturer.Name = "Manufaturer";
            this.Manufaturer.Size = new System.Drawing.Size(100, 30);
            this.Manufaturer.TabIndex = 4;
            // 
            // PlatForm
            // 
            this.PlatForm.Location = new System.Drawing.Point(139, 21);
            this.PlatForm.Name = "PlatForm";
            this.PlatForm.Size = new System.Drawing.Size(100, 30);
            this.PlatForm.TabIndex = 4;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 62);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(127, 25);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatFormlabel
            // 
            this.PlatFormlabel.AutoSize = true;
            this.PlatFormlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatFormlabel.Location = new System.Drawing.Point(43, 27);
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
            this.TechBox.Controls.Add(this.textBox5);
            this.TechBox.Controls.Add(this.GPUBox);
            this.TechBox.Controls.Add(this.TypeBox);
            this.TechBox.Controls.Add(this.textBox6);
            this.TechBox.Controls.Add(this.textBox4);
            this.TechBox.Controls.Add(this.BrandBox);
            this.TechBox.Controls.Add(this.MemoryBox);
            this.TechBox.Controls.Add(this.NumberLabel);
            this.TechBox.Controls.Add(this.SizeLabel);
            this.TechBox.Controls.Add(this.label3);
            this.TechBox.Controls.Add(this.CPULabel);
            this.TechBox.Controls.Add(this.MemoryLabel);
            this.TechBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TechBox.Location = new System.Drawing.Point(17, 227);
            this.TechBox.Name = "TechBox";
            this.TechBox.Size = new System.Drawing.Size(771, 124);
            this.TechBox.TabIndex = 6;
            this.TechBox.TabStop = false;
            this.TechBox.Text = "Tech Specs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "WebCam";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(498, 20);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(54, 25);
            this.HDDLabel.TabIndex = 0;
            this.HDDLabel.Text = "HDD";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Location = new System.Drawing.Point(498, 60);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(104, 25);
            this.GPULabel.TabIndex = 0;
            this.GPULabel.Text = "GPU Type";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(261, 96);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(117, 25);
            this.SpeedLabel.TabIndex = 0;
            this.SpeedLabel.Text = "CPU Speed";
            // 
            // WebCamBox
            // 
            this.WebCamBox.Location = new System.Drawing.Point(610, 91);
            this.WebCamBox.Name = "WebCamBox";
            this.WebCamBox.Size = new System.Drawing.Size(155, 30);
            this.WebCamBox.TabIndex = 4;
            // 
            // HDDtBox
            // 
            this.HDDtBox.Location = new System.Drawing.Point(610, 17);
            this.HDDtBox.Name = "HDDtBox";
            this.HDDtBox.Size = new System.Drawing.Size(155, 30);
            this.HDDtBox.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(383, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 30);
            this.textBox5.TabIndex = 4;
            // 
            // GPUBox
            // 
            this.GPUBox.Location = new System.Drawing.Point(610, 54);
            this.GPUBox.Name = "GPUBox";
            this.GPUBox.Size = new System.Drawing.Size(155, 30);
            this.GPUBox.TabIndex = 4;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(142, 88);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 30);
            this.TypeBox.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(383, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 30);
            this.textBox6.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(383, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 30);
            this.textBox4.TabIndex = 4;
            // 
            // BrandBox
            // 
            this.BrandBox.Location = new System.Drawing.Point(142, 52);
            this.BrandBox.Name = "BrandBox";
            this.BrandBox.Size = new System.Drawing.Size(100, 30);
            this.BrandBox.TabIndex = 4;
            // 
            // MemoryBox
            // 
            this.MemoryBox.Location = new System.Drawing.Point(142, 19);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Size = new System.Drawing.Size(100, 30);
            this.MemoryBox.TabIndex = 4;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(261, 57);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(128, 25);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "CPU Number";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(261, 22);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(96, 25);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "LCD Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU Type";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(5, 57);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(111, 25);
            this.CPULabel.TabIndex = 0;
            this.CPULabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(5, 26);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(83, 25);
            this.MemoryLabel.TabIndex = 0;
            this.MemoryLabel.Text = "Memory";
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionLabel.Location = new System.Drawing.Point(12, 389);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(321, 25);
            this.YourSelectionLabel.TabIndex = 0;
            this.YourSelectionLabel.Text = "Click Next To Cofirm Your Selection";
            // 
            // AnotherProductButton
            // 
            this.AnotherProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnotherProductButton.Location = new System.Drawing.Point(349, 389);
            this.AnotherProductButton.Name = "AnotherProductButton";
            this.AnotherProductButton.Size = new System.Drawing.Size(235, 32);
            this.AnotherProductButton.TabIndex = 7;
            this.AnotherProductButton.Text = "Select Another Product";
            this.AnotherProductButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(594, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 32);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(707, 389);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 32);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfoForm";
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox GPUBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox BrandBox;
        private System.Windows.Forms.TextBox MemoryBox;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.Button AnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}