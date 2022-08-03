namespace MessageWall
{
    partial class DashBoard
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
            this.messageBox = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageListBoxLebel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.AutoSize = true;
            this.messageBox.Location = new System.Drawing.Point(85, 66);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(112, 29);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "Message";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(225, 63);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(363, 35);
            this.messageText.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 29;
            this.messageListBox.Location = new System.Drawing.Point(85, 163);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(598, 236);
            this.messageListBox.TabIndex = 3;
            // 
            // messageListBoxLebel
            // 
            this.messageListBoxLebel.AutoSize = true;
            this.messageListBoxLebel.Location = new System.Drawing.Point(85, 131);
            this.messageListBoxLebel.Name = "messageListBoxLebel";
            this.messageListBoxLebel.Size = new System.Drawing.Size(112, 29);
            this.messageListBoxLebel.TabIndex = 0;
            this.messageListBoxLebel.Text = "Message";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(594, 63);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(89, 35);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(534, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 33);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 435);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.messageListBoxLebel);
            this.Controls.Add(this.messageBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "DashBoard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label messageBox;
        private TextBox messageText;
        private ListBox messageListBox;
        private Label messageListBoxLebel;
        private Button SendButton;
        private CheckBox checkBox1;
    }
}