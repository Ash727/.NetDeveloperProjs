namespace WinFormMiniProject
{
    partial class AddressEntryForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.poboxText = new System.Windows.Forms.TextBox();
            this.provinceText = new System.Windows.Forms.TextBox();
            this.poBoxLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.streetAddressText = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.HeaderLable = new System.Windows.Forms.Label();
            this.streetAdressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(232, 282);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(155, 38);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // poboxText
            // 
            this.poboxText.Location = new System.Drawing.Point(179, 233);
            this.poboxText.Name = "poboxText";
            this.poboxText.Size = new System.Drawing.Size(298, 35);
            this.poboxText.TabIndex = 18;
            // 
            // provinceText
            // 
            this.provinceText.Location = new System.Drawing.Point(179, 179);
            this.provinceText.Name = "provinceText";
            this.provinceText.Size = new System.Drawing.Size(298, 35);
            this.provinceText.TabIndex = 19;
            // 
            // poBoxLabel
            // 
            this.poBoxLabel.AutoSize = true;
            this.poBoxLabel.Location = new System.Drawing.Point(51, 236);
            this.poBoxLabel.Name = "poBoxLabel";
            this.poBoxLabel.Size = new System.Drawing.Size(122, 30);
            this.poBoxLabel.TabIndex = 16;
            this.poBoxLabel.Text = "Postal Code";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(80, 182);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(92, 30);
            this.provinceLabel.TabIndex = 17;
            this.provinceLabel.Text = "Province";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(179, 122);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(298, 35);
            this.cityText.TabIndex = 14;
            // 
            // streetAddressText
            // 
            this.streetAddressText.Location = new System.Drawing.Point(179, 68);
            this.streetAddressText.Name = "streetAddressText";
            this.streetAddressText.Size = new System.Drawing.Size(298, 35);
            this.streetAddressText.TabIndex = 15;
            this.streetAddressText.TextChanged += new System.EventHandler(this.streetAddressText_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(125, 127);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(48, 30);
            this.cityLabel.TabIndex = 11;
            this.cityLabel.Text = "City";
            // 
            // HeaderLable
            // 
            this.HeaderLable.AutoSize = true;
            this.HeaderLable.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HeaderLable.Location = new System.Drawing.Point(179, 9);
            this.HeaderLable.Name = "HeaderLable";
            this.HeaderLable.Size = new System.Drawing.Size(250, 47);
            this.HeaderLable.TabIndex = 12;
            this.HeaderLable.Text = "Address Entry";
            // 
            // streetAdressLabel
            // 
            this.streetAdressLabel.AutoSize = true;
            this.streetAdressLabel.Location = new System.Drawing.Point(27, 71);
            this.streetAdressLabel.Name = "streetAdressLabel";
            this.streetAdressLabel.Size = new System.Drawing.Size(146, 30);
            this.streetAdressLabel.TabIndex = 13;
            this.streetAdressLabel.Text = "Street Address";
            // 
            // AddressEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 330);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.poboxText);
            this.Controls.Add(this.provinceText);
            this.Controls.Add(this.poBoxLabel);
            this.Controls.Add(this.provinceLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.streetAddressText);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.HeaderLable);
            this.Controls.Add(this.streetAdressLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddressEntryForm";
            this.Text = "AddressEntry";
            this.Load += new System.EventHandler(this.AddressEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveButton;
        private TextBox poboxText;
        private TextBox provinceText;
        private Label poBoxLabel;
        private Label provinceLabel;
        private TextBox cityText;
        private TextBox streetAddressText;
        private Label cityLabel;
        private Label HeaderLable;
        private Label streetAdressLabel;
    }
}