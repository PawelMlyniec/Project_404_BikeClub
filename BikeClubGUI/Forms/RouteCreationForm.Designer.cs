namespace BikeClubGUI.Forms
{
    partial class RouteCreationForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rampBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.startTextBox = new System.Windows.Forms.TextBox();
            this.endTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rampBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(258, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Route name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "End";
            // 
            // rampBox
            // 
            this.rampBox.Location = new System.Drawing.Point(67, 151);
            this.rampBox.Name = "rampBox";
            this.rampBox.Size = new System.Drawing.Size(57, 20);
            this.rampBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ramp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Difficulty";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 232);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(258, 43);
            this.okButton.TabIndex = 10;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distance";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(67, 180);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(57, 20);
            this.distanceTextBox.TabIndex = 12;
            this.distanceTextBox.Text = "0";
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.difficultyComboBox.Location = new System.Drawing.Point(67, 206);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(57, 21);
            this.difficultyComboBox.TabIndex = 13;
            // 
            // startTextBox
            // 
            this.startTextBox.Location = new System.Drawing.Point(12, 79);
            this.startTextBox.Name = "startTextBox";
            this.startTextBox.Size = new System.Drawing.Size(258, 20);
            this.startTextBox.TabIndex = 14;
            // 
            // endTextBox
            // 
            this.endTextBox.Location = new System.Drawing.Point(12, 120);
            this.endTextBox.Name = "endTextBox";
            this.endTextBox.Size = new System.Drawing.Size(258, 20);
            this.endTextBox.TabIndex = 15;
            // 
            // RouteCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 291);
            this.Controls.Add(this.endTextBox);
            this.Controls.Add(this.startTextBox);
            this.Controls.Add(this.difficultyComboBox);
            this.Controls.Add(this.distanceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rampBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "RouteCreationForm";
            this.Text = "New Route";
            this.Load += new System.EventHandler(this.RouteCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rampBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rampBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.TextBox startTextBox;
        private System.Windows.Forms.TextBox endTextBox;
    }
}