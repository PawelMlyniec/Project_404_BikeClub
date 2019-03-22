namespace BikeClubGUI.Forms
{
    partial class AddChildForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.BirthPicker = new System.Windows.Forms.DateTimePicker();
            this.okBottom = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(249, 20);
            this.NameBox.TabIndex = 0;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(14, 110);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(246, 20);
            this.LoginBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(14, 170);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(246, 20);
            this.PasswordBox.TabIndex = 2;
            // 
            // BirthPicker
            // 
            this.BirthPicker.Location = new System.Drawing.Point(17, 242);
            this.BirthPicker.Name = "BirthPicker";
            this.BirthPicker.Size = new System.Drawing.Size(242, 20);
            this.BirthPicker.TabIndex = 3;
            // 
            // okBottom
            // 
            this.okBottom.Location = new System.Drawing.Point(133, 360);
            this.okBottom.Name = "okBottom";
            this.okBottom.Size = new System.Drawing.Size(125, 54);
            this.okBottom.TabIndex = 4;
            this.okBottom.Text = "OK";
            this.okBottom.UseVisualStyleBackColor = true;
            this.okBottom.Click += new System.EventHandler(this.AddChildButtom);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(9, 33);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name";
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(16, 96);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(33, 13);
            this.Log.TabIndex = 6;
            this.Log.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Birth Date";
            // 
            // AddChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.okBottom);
            this.Controls.Add(this.BirthPicker);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.NameBox);
         //   this.Name = "AddChildForm";
            this.Load += new System.EventHandler(this.AddChild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.DateTimePicker BirthPicker;
        private System.Windows.Forms.Button okBottom;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}