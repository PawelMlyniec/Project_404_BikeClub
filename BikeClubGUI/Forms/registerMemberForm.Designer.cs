namespace BikeClubGUI.Forms
{
    partial class registerMemberForm
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.ibanBoxx = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IBAN = new System.Windows.Forms.Label();
            this.birthName = new System.Windows.Forms.Label();
            this.birthPicker = new System.Windows.Forms.DateTimePicker();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(13, 53);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(218, 20);
            this.nameText.TabIndex = 0;
            // 
            // ibanBoxx
            // 
            this.ibanBoxx.Location = new System.Drawing.Point(14, 193);
            this.ibanBoxx.Name = "ibanBoxx";
            this.ibanBoxx.Size = new System.Drawing.Size(218, 20);
            this.ibanBoxx.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(14, 141);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(218, 20);
            this.passBox.TabIndex = 5;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(14, 95);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(218, 20);
            this.loginBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Password";
            // 
            // IBAN
            // 
            this.IBAN.AutoSize = true;
            this.IBAN.Location = new System.Drawing.Point(14, 174);
            this.IBAN.Name = "IBAN";
            this.IBAN.Size = new System.Drawing.Size(34, 15);
            this.IBAN.TabIndex = 10;
            this.IBAN.Text = "IBAN";
            // 
            // birthName
            // 
            this.birthName.AutoSize = true;
            this.birthName.Location = new System.Drawing.Point(14, 220);
            this.birthName.Name = "birthName";
            this.birthName.Size = new System.Drawing.Size(74, 15);
            this.birthName.TabIndex = 11;
            this.birthName.Text = "Date of Birth";
            // 
            // birthPicker
            // 
            this.birthPicker.Location = new System.Drawing.Point(13, 237);
            this.birthPicker.Name = "birthPicker";
            this.birthPicker.Size = new System.Drawing.Size(218, 20);
            this.birthPicker.TabIndex = 12;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(139, 362);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // registerMemberForm
            // 
            this.ClientSize = new System.Drawing.Size(246, 494);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.birthPicker);
            this.Controls.Add(this.birthName);
            this.Controls.Add(this.IBAN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.ibanBoxx);
            this.Controls.Add(this.nameText);
            this.Name = "registerMemberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox ibanBoxx;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label IBAN;
        private System.Windows.Forms.Label birthName;
        private System.Windows.Forms.DateTimePicker birthPicker;
        private System.Windows.Forms.Button okButton;
    }
}