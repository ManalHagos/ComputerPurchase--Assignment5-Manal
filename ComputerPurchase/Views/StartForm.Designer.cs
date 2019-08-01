namespace ComputerPurchase.Views
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.NewOrder = new System.Windows.Forms.Button();
            this.SavedOrder = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrder
            // 
            this.NewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NewOrder.Location = new System.Drawing.Point(400, 374);
            this.NewOrder.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(323, 59);
            this.NewOrder.TabIndex = 0;
            this.NewOrder.Text = "Start a new order";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // SavedOrder
            // 
            this.SavedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedOrder.Location = new System.Drawing.Point(400, 471);
            this.SavedOrder.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SavedOrder.Name = "SavedOrder";
            this.SavedOrder.Size = new System.Drawing.Size(326, 57);
            this.SavedOrder.TabIndex = 1;
            this.SavedOrder.Text = "Load a saved order";
            this.SavedOrder.UseVisualStyleBackColor = true;
            this.SavedOrder.Click += new System.EventHandler(this.SavedOrder_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitButton.Location = new System.Drawing.Point(400, 568);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(326, 49);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 228);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 653);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavedOrder);
            this.Controls.Add(this.NewOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button SavedOrder;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

