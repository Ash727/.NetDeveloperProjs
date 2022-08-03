namespace WinFormMiniProject
{
    partial class PersonEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.addressesListBox = new System.Windows.Forms.ListBox();
            this.addressesLabel = new System.Windows.Forms.Label();
            this.AddNewAddress = new System.Windows.Forms.Button();
            this.IsActiveLabel = new System.Windows.Forms.Label();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(137, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 32);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "FirstName";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(257, 12);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(298, 39);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(137, 69);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(119, 32);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "LastName";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(257, 66);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(298, 39);
            this.lastNameText.TabIndex = 1;
            // 
            // addressesListBox
            // 
            this.addressesListBox.FormattingEnabled = true;
            this.addressesListBox.ItemHeight = 32;
            this.addressesListBox.Location = new System.Drawing.Point(53, 196);
            this.addressesListBox.Name = "addressesListBox";
            this.addressesListBox.Size = new System.Drawing.Size(587, 164);
            this.addressesListBox.TabIndex = 2;
            // 
            // addressesLabel
            // 
            this.addressesLabel.AutoSize = true;
            this.addressesLabel.Location = new System.Drawing.Point(140, 152);
            this.addressesLabel.Name = "addressesLabel";
            this.addressesLabel.Size = new System.Drawing.Size(121, 32);
            this.addressesLabel.TabIndex = 0;
            this.addressesLabel.Text = "Addresses";
            // 
            // AddNewAddress
            // 
            this.AddNewAddress.Location = new System.Drawing.Point(466, 140);
            this.AddNewAddress.Name = "AddNewAddress";
            this.AddNewAddress.Size = new System.Drawing.Size(98, 44);
            this.AddNewAddress.TabIndex = 3;
            this.AddNewAddress.Text = "Add";
            this.AddNewAddress.UseVisualStyleBackColor = true;
            this.AddNewAddress.Click += new System.EventHandler(this.AddNewAddress_Click);
            // 
            // IsActiveLabel
            // 
            this.IsActiveLabel.AutoSize = true;
            this.IsActiveLabel.Location = new System.Drawing.Point(140, 114);
            this.IsActiveLabel.Name = "IsActiveLabel";
            this.IsActiveLabel.Size = new System.Drawing.Size(95, 32);
            this.IsActiveLabel.TabIndex = 0;
            this.IsActiveLabel.Text = "IsActive";
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(257, 124);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isActiveCheckBox.TabIndex = 4;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(257, 389);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(175, 44);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PersonEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 480);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddNewAddress);
            this.Controls.Add(this.addressesListBox);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.addressesLabel);
            this.Controls.Add(this.IsActiveLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PersonEntryForm";
            this.Text = "PersonEnteryForm By Ash727";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private ListBox addressesListBox;
        private Label addressesLabel;
        private Button AddNewAddress;
        private Label IsActiveLabel;
        private CheckBox isActiveCheckBox;
        private Button SaveButton;
    }
}