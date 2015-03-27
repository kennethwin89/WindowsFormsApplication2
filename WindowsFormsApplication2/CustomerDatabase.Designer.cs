namespace CustomerDatabaseApplication
{
    partial class CustomerDatabase
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
            this.AddCustomersButton = new System.Windows.Forms.Button();
            this.ViewCustomerListButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // AddCustomersButton
            // 
            this.AddCustomersButton.AccessibleName = "Create Customer";
            this.AddCustomersButton.Location = new System.Drawing.Point(12, 43);
            this.AddCustomersButton.Name = "AddCustomersButton";
            this.AddCustomersButton.Size = new System.Drawing.Size(100, 25);
            this.AddCustomersButton.TabIndex = 0;
            this.AddCustomersButton.Text = "Create Customer";
            this.AddCustomersButton.UseVisualStyleBackColor = true;
            this.AddCustomersButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewCustomerListButton
            // 
            this.ViewCustomerListButton.Location = new System.Drawing.Point(12, 12);
            this.ViewCustomerListButton.Name = "ViewCustomerListButton";
            this.ViewCustomerListButton.Size = new System.Drawing.Size(100, 25);
            this.ViewCustomerListButton.TabIndex = 2;
            this.ViewCustomerListButton.Text = "View Cust. List";
            this.ViewCustomerListButton.UseVisualStyleBackColor = true;
            this.ViewCustomerListButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update Customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 348);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ViewCustomerListButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddCustomersButton);
            this.Name = "CustomerDatabase";
            this.Text = "Customer Database Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCustomersButton;
        private System.Windows.Forms.Button ViewCustomerListButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

