namespace CustomerDatabaseApplication
{
    partial class CustomerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomrID_Label = new System.Windows.Forms.Label();
            this.LastName_Label = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstName_Label = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.Street1_Label = new System.Windows.Forms.Label();
            this.Street2_Label = new System.Windows.Forms.Label();
            this.Street1TextBox = new System.Windows.Forms.TextBox();
            this.Street2TextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.TheButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(17, 45);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 0;
            this.CustomerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // CustomrID_Label
            // 
            this.CustomrID_Label.AutoSize = true;
            this.CustomrID_Label.Location = new System.Drawing.Point(17, 26);
            this.CustomrID_Label.Name = "CustomrID_Label";
            this.CustomrID_Label.Size = new System.Drawing.Size(68, 13);
            this.CustomrID_Label.TabIndex = 1;
            this.CustomrID_Label.Text = "Customer ID:";
            // 
            // LastName_Label
            // 
            this.LastName_Label.AutoSize = true;
            this.LastName_Label.Location = new System.Drawing.Point(17, 92);
            this.LastName_Label.Name = "LastName_Label";
            this.LastName_Label.Size = new System.Drawing.Size(61, 13);
            this.LastName_Label.TabIndex = 2;
            this.LastName_Label.Text = "Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(17, 108);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // FirstName_Label
            // 
            this.FirstName_Label.AutoSize = true;
            this.FirstName_Label.Location = new System.Drawing.Point(133, 92);
            this.FirstName_Label.Name = "FirstName_Label";
            this.FirstName_Label.Size = new System.Drawing.Size(60, 13);
            this.FirstName_Label.TabIndex = 4;
            this.FirstName_Label.Text = "First Name:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(136, 108);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 5;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // Street1_Label
            // 
            this.Street1_Label.AutoSize = true;
            this.Street1_Label.Location = new System.Drawing.Point(17, 144);
            this.Street1_Label.Name = "Street1_Label";
            this.Street1_Label.Size = new System.Drawing.Size(47, 13);
            this.Street1_Label.TabIndex = 6;
            this.Street1_Label.Text = "Street 1:";
            this.Street1_Label.Click += new System.EventHandler(this.Street1Label_Click);
            // 
            // Street2_Label
            // 
            this.Street2_Label.AutoSize = true;
            this.Street2_Label.Location = new System.Drawing.Point(17, 183);
            this.Street2_Label.Name = "Street2_Label";
            this.Street2_Label.Size = new System.Drawing.Size(47, 13);
            this.Street2_Label.TabIndex = 7;
            this.Street2_Label.Text = "Street 2:";
            // 
            // Street1TextBox
            // 
            this.Street1TextBox.Location = new System.Drawing.Point(17, 160);
            this.Street1TextBox.Name = "Street1TextBox";
            this.Street1TextBox.Size = new System.Drawing.Size(219, 20);
            this.Street1TextBox.TabIndex = 8;
            this.Street1TextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Street2TextBox
            // 
            this.Street2TextBox.Location = new System.Drawing.Point(17, 199);
            this.Street2TextBox.Name = "Street2TextBox";
            this.Street2TextBox.Size = new System.Drawing.Size(219, 20);
            this.Street2TextBox.TabIndex = 9;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(17, 227);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(17, 243);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 11;
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(133, 227);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(35, 13);
            this.StateLabel.TabIndex = 13;
            this.StateLabel.Text = "State:";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(17, 276);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(22, 13);
            this.ZipLabel.TabIndex = 14;
            this.ZipLabel.Text = "Zip";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.AccessibleName = "Zip";
            this.ZipTextBox.Location = new System.Drawing.Point(17, 293);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZipTextBox.TabIndex = 15;
            this.ZipTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // StateComboBox
            // 
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Location = new System.Drawing.Point(136, 243);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(100, 21);
            this.StateComboBox.TabIndex = 16;
            this.StateComboBox.SelectedIndexChanged += new System.EventHandler(this.StateComboBox_SelectedIndexChanged);
            // 
            // TheButton
            // 
            this.TheButton.Location = new System.Drawing.Point(136, 293);
            this.TheButton.Name = "TheButton";
            this.TheButton.Size = new System.Drawing.Size(100, 23);
            this.TheButton.TabIndex = 17;
            this.TheButton.Text = "Depends";
            this.TheButton.UseVisualStyleBackColor = true;
            this.TheButton.Click += new System.EventHandler(this.TheButton_Click);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TheButton);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.ZipTextBox);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.Street2TextBox);
            this.Controls.Add(this.Street1TextBox);
            this.Controls.Add(this.Street2_Label);
            this.Controls.Add(this.Street1_Label);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstName_Label);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastName_Label);
            this.Controls.Add(this.CustomrID_Label);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(514, 351);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Label CustomrID_Label;
        private System.Windows.Forms.Label LastName_Label;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label FirstName_Label;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label Street1_Label;
        private System.Windows.Forms.Label Street2_Label;
        private System.Windows.Forms.TextBox Street1TextBox;
        private System.Windows.Forms.TextBox Street2TextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.ComboBox StateComboBox;
        private System.Windows.Forms.Button TheButton;
    }
}
