﻿namespace ComputerPurchase.Views
{
    partial class SelectForm
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
            this.AboutSelection = new System.Windows.Forms.Label();
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaytypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolutionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDsizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDspeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opticaldriveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audiotypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mousttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webcamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarComputersDataSet = new ComputerPurchase.DollarComputersDataSet();
            this.productsTableAdapter = new ComputerPurchase.DollarComputersDataSetTableAdapters.productsTableAdapter();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutSelection
            // 
            this.AboutSelection.AutoSize = true;
            this.AboutSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSelection.Location = new System.Drawing.Point(11, 28);
            this.AboutSelection.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AboutSelection.Name = "AboutSelection";
            this.AboutSelection.Size = new System.Drawing.Size(277, 25);
            this.AboutSelection.TabIndex = 1;
            this.AboutSelection.Text = "Dollar Computer Hardware List";
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeColumns = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            this.ProductDataGridView.AutoGenerateColumns = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProductDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.rAMtypeDataGridViewTextBoxColumn,
            this.rAMsizeDataGridViewTextBoxColumn,
            this.displaytypeDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.cPUClassDataGridViewTextBoxColumn,
            this.cPUbrandDataGridViewTextBoxColumn,
            this.cPUtypeDataGridViewTextBoxColumn,
            this.cPUspeedDataGridViewTextBoxColumn,
            this.cPUnumberDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.hDDsizeDataGridViewTextBoxColumn,
            this.hDDspeedDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.opticaldriveDataGridViewTextBoxColumn,
            this.audiotypeDataGridViewTextBoxColumn,
            this.lANDataGridViewTextBoxColumn,
            this.wIFIDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.depthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.mousttypeDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.webcamDataGridViewTextBoxColumn});
            this.ProductDataGridView.DataSource = this.productsBindingSource;
            this.ProductDataGridView.Location = new System.Drawing.Point(19, 73);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.RowTemplate.Height = 28;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(1297, 497);
            this.ProductDataGridView.TabIndex = 2;
            this.ProductDataGridView.SelectionChanged += new System.EventHandler(this.ProductDataGridView_SelectionChanged);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 153;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 93;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 188;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 117;
            // 
            // rAMtypeDataGridViewTextBoxColumn
            // 
            this.rAMtypeDataGridViewTextBoxColumn.DataPropertyName = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.HeaderText = "RAM_type";
            this.rAMtypeDataGridViewTextBoxColumn.Name = "rAMtypeDataGridViewTextBoxColumn";
            this.rAMtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMtypeDataGridViewTextBoxColumn.Width = 159;
            // 
            // rAMsizeDataGridViewTextBoxColumn
            // 
            this.rAMsizeDataGridViewTextBoxColumn.DataPropertyName = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.HeaderText = "RAM_size";
            this.rAMsizeDataGridViewTextBoxColumn.Name = "rAMsizeDataGridViewTextBoxColumn";
            this.rAMsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMsizeDataGridViewTextBoxColumn.Width = 157;
            // 
            // displaytypeDataGridViewTextBoxColumn
            // 
            this.displaytypeDataGridViewTextBoxColumn.DataPropertyName = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.HeaderText = "displaytype";
            this.displaytypeDataGridViewTextBoxColumn.Name = "displaytypeDataGridViewTextBoxColumn";
            this.displaytypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.displaytypeDataGridViewTextBoxColumn.Width = 170;
            // 
            // screensizeDataGridViewTextBoxColumn
            // 
            this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
            this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
            this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
            this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.screensizeDataGridViewTextBoxColumn.Width = 165;
            // 
            // resolutionDataGridViewTextBoxColumn
            // 
            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "resolution";
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "resolution";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Width = 155;
            // 
            // cPUClassDataGridViewTextBoxColumn
            // 
            this.cPUClassDataGridViewTextBoxColumn.DataPropertyName = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.HeaderText = "CPU_Class";
            this.cPUClassDataGridViewTextBoxColumn.Name = "cPUClassDataGridViewTextBoxColumn";
            this.cPUClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUClassDataGridViewTextBoxColumn.Width = 172;
            // 
            // cPUbrandDataGridViewTextBoxColumn
            // 
            this.cPUbrandDataGridViewTextBoxColumn.DataPropertyName = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.HeaderText = "CPU_brand";
            this.cPUbrandDataGridViewTextBoxColumn.Name = "cPUbrandDataGridViewTextBoxColumn";
            this.cPUbrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUbrandDataGridViewTextBoxColumn.Width = 174;
            // 
            // cPUtypeDataGridViewTextBoxColumn
            // 
            this.cPUtypeDataGridViewTextBoxColumn.DataPropertyName = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.HeaderText = "CPU_type";
            this.cPUtypeDataGridViewTextBoxColumn.Name = "cPUtypeDataGridViewTextBoxColumn";
            this.cPUtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUtypeDataGridViewTextBoxColumn.Width = 157;
            // 
            // cPUspeedDataGridViewTextBoxColumn
            // 
            this.cPUspeedDataGridViewTextBoxColumn.DataPropertyName = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.HeaderText = "CPU_speed";
            this.cPUspeedDataGridViewTextBoxColumn.Name = "cPUspeedDataGridViewTextBoxColumn";
            this.cPUspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUspeedDataGridViewTextBoxColumn.Width = 180;
            // 
            // cPUnumberDataGridViewTextBoxColumn
            // 
            this.cPUnumberDataGridViewTextBoxColumn.DataPropertyName = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.HeaderText = "CPU_number";
            this.cPUnumberDataGridViewTextBoxColumn.Name = "cPUnumberDataGridViewTextBoxColumn";
            this.cPUnumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUnumberDataGridViewTextBoxColumn.Width = 194;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 147;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSDataGridViewTextBoxColumn.Width = 84;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Width = 136;
            // 
            // hDDsizeDataGridViewTextBoxColumn
            // 
            this.hDDsizeDataGridViewTextBoxColumn.DataPropertyName = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.HeaderText = "HDD_size";
            this.hDDsizeDataGridViewTextBoxColumn.Name = "hDDsizeDataGridViewTextBoxColumn";
            this.hDDsizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDsizeDataGridViewTextBoxColumn.Width = 156;
            // 
            // hDDspeedDataGridViewTextBoxColumn
            // 
            this.hDDspeedDataGridViewTextBoxColumn.DataPropertyName = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.HeaderText = "HDD_speed";
            this.hDDspeedDataGridViewTextBoxColumn.Name = "hDDspeedDataGridViewTextBoxColumn";
            this.hDDspeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDspeedDataGridViewTextBoxColumn.Width = 181;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPU_Type";
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gPUTypeDataGridViewTextBoxColumn.Width = 168;
            // 
            // opticaldriveDataGridViewTextBoxColumn
            // 
            this.opticaldriveDataGridViewTextBoxColumn.DataPropertyName = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.HeaderText = "optical_drive";
            this.opticaldriveDataGridViewTextBoxColumn.Name = "opticaldriveDataGridViewTextBoxColumn";
            this.opticaldriveDataGridViewTextBoxColumn.ReadOnly = true;
            this.opticaldriveDataGridViewTextBoxColumn.Width = 186;
            // 
            // audiotypeDataGridViewTextBoxColumn
            // 
            this.audiotypeDataGridViewTextBoxColumn.DataPropertyName = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.HeaderText = "Audio_type";
            this.audiotypeDataGridViewTextBoxColumn.Name = "audiotypeDataGridViewTextBoxColumn";
            this.audiotypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.audiotypeDataGridViewTextBoxColumn.Width = 169;
            // 
            // lANDataGridViewTextBoxColumn
            // 
            this.lANDataGridViewTextBoxColumn.DataPropertyName = "LAN";
            this.lANDataGridViewTextBoxColumn.HeaderText = "LAN";
            this.lANDataGridViewTextBoxColumn.Name = "lANDataGridViewTextBoxColumn";
            this.lANDataGridViewTextBoxColumn.ReadOnly = true;
            this.lANDataGridViewTextBoxColumn.Width = 95;
            // 
            // wIFIDataGridViewTextBoxColumn
            // 
            this.wIFIDataGridViewTextBoxColumn.DataPropertyName = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.HeaderText = "WIFI";
            this.wIFIDataGridViewTextBoxColumn.Name = "wIFIDataGridViewTextBoxColumn";
            this.wIFIDataGridViewTextBoxColumn.ReadOnly = true;
            this.wIFIDataGridViewTextBoxColumn.Width = 98;
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            this.widthDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthDataGridViewTextBoxColumn.Width = 106;
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            this.heightDataGridViewTextBoxColumn.ReadOnly = true;
            this.heightDataGridViewTextBoxColumn.Width = 115;
            // 
            // depthDataGridViewTextBoxColumn
            // 
            this.depthDataGridViewTextBoxColumn.DataPropertyName = "depth";
            this.depthDataGridViewTextBoxColumn.HeaderText = "depth";
            this.depthDataGridViewTextBoxColumn.Name = "depthDataGridViewTextBoxColumn";
            this.depthDataGridViewTextBoxColumn.ReadOnly = true;
            this.depthDataGridViewTextBoxColumn.Width = 110;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            this.weightDataGridViewTextBoxColumn.Width = 120;
            // 
            // mousttypeDataGridViewTextBoxColumn
            // 
            this.mousttypeDataGridViewTextBoxColumn.DataPropertyName = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.HeaderText = "moust_type";
            this.mousttypeDataGridViewTextBoxColumn.Name = "mousttypeDataGridViewTextBoxColumn";
            this.mousttypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mousttypeDataGridViewTextBoxColumn.Width = 172;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "power";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.Width = 117;
            // 
            // webcamDataGridViewTextBoxColumn
            // 
            this.webcamDataGridViewTextBoxColumn.DataPropertyName = "webcam";
            this.webcamDataGridViewTextBoxColumn.HeaderText = "webcam";
            this.webcamDataGridViewTextBoxColumn.Name = "webcamDataGridViewTextBoxColumn";
            this.webcamDataGridViewTextBoxColumn.ReadOnly = true;
            this.webcamDataGridViewTextBoxColumn.Width = 140;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.dollarComputersDataSet;
            // 
            // dollarComputersDataSet
            // 
            this.dollarComputersDataSet.DataSetName = "DollarComputersDataSet";
            this.dollarComputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionLabel.Location = new System.Drawing.Point(19, 621);
            this.SelectionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(128, 25);
            this.SelectionLabel.TabIndex = 3;
            this.SelectionLabel.Text = "Your Selction";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(250, 622);
            this.textBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(612, 35);
            this.textBox.TabIndex = 4;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(1002, 618);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(142, 51);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(1168, 618);
            this.NextButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(148, 51);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 716);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.ProductDataGridView);
            this.Controls.Add(this.AboutSelection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutSelection;
        private System.Windows.Forms.DataGridView ProductDataGridView;
        private DollarComputersDataSet dollarComputersDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DollarComputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaytypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDsizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDspeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opticaldriveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn audiotypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIFIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mousttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webcamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}