namespace BikeClubGUI.Forms
{
    partial class SignUpForEventForm
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
            this.MemberBinding = new System.Windows.Forms.BindingSource(this.components);
            this.LaterEventBiding = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LaterEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaterResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaterStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaterEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nextEventsGridView3 = new System.Windows.Forms.DataGridView();
            this.NextEventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextResponsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaterEventBiding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextEventsGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Login,
            this.IBAN});
            this.dataGridView1.DataSource = this.MemberBinding;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 42);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // IBAN
            // 
            this.IBAN.DataPropertyName = "IBAN";
            this.IBAN.HeaderText = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaterEventName,
            this.LaterResponsible,
            this.LaterStartDate,
            this.LaterEndDate});
            this.dataGridView2.DataSource = this.LaterEventBiding;
            this.dataGridView2.Location = new System.Drawing.Point(10, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(444, 100);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // LaterEventName
            // 
            this.LaterEventName.DataPropertyName = "LaterEventName";
            this.LaterEventName.HeaderText = "Event Name";
            this.LaterEventName.Name = "LaterEventName";
            this.LaterEventName.ReadOnly = true;
            // 
            // LaterResponsible
            // 
            this.LaterResponsible.DataPropertyName = "LaterResponsible";
            this.LaterResponsible.HeaderText = "Responsible";
            this.LaterResponsible.Name = "LaterResponsible";
            this.LaterResponsible.ReadOnly = true;
            // 
            // LaterStartDate
            // 
            this.LaterStartDate.DataPropertyName = "LaterStartDate";
            this.LaterStartDate.HeaderText = "Start Date";
            this.LaterStartDate.Name = "LaterStartDate";
            this.LaterStartDate.ReadOnly = true;
            // 
            // LaterEndDate
            // 
            this.LaterEndDate.DataPropertyName = "LaterEndDate";
            this.LaterEndDate.HeaderText = "End Date";
            this.LaterEndDate.Name = "LaterEndDate";
            this.LaterEndDate.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Events";
            // 
            // nextEventsGridView3
            // 
            this.nextEventsGridView3.AllowUserToAddRows = false;
            this.nextEventsGridView3.AllowUserToDeleteRows = false;
            this.nextEventsGridView3.AutoGenerateColumns = false;
            this.nextEventsGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nextEventsGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NextEventName,
            this.NextResponsible,
            this.NextStartDate,
            this.NextEndDate});
            this.nextEventsGridView3.DataSource = this.nextBindingSource;
            this.nextEventsGridView3.Location = new System.Drawing.Point(10, 232);
            this.nextEventsGridView3.Name = "nextEventsGridView3";
            this.nextEventsGridView3.ReadOnly = true;
            this.nextEventsGridView3.Size = new System.Drawing.Size(444, 88);
            this.nextEventsGridView3.TabIndex = 3;
            this.nextEventsGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SignUpClick);
            // 
            // NextEventName
            // 
            this.NextEventName.DataPropertyName = "NextEventName";
            this.NextEventName.HeaderText = "Event Name";
            this.NextEventName.Name = "NextEventName";
            this.NextEventName.ReadOnly = true;
            // 
            // NextResponsible
            // 
            this.NextResponsible.DataPropertyName = "NextResponsible";
            this.NextResponsible.HeaderText = "Responsible";
            this.NextResponsible.Name = "NextResponsible";
            this.NextResponsible.ReadOnly = true;
            // 
            // NextStartDate
            // 
            this.NextStartDate.DataPropertyName = "NextStartDate";
            this.NextStartDate.HeaderText = "Start Date";
            this.NextStartDate.Name = "NextStartDate";
            this.NextStartDate.ReadOnly = true;
            // 
            // NextEndDate
            // 
            this.NextEndDate.DataPropertyName = "NextEndDate";
            this.NextEndDate.HeaderText = "End Date";
            this.NextEndDate.Name = "NextEndDate";
            this.NextEndDate.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Next events";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addEventButtom);
            // 
            // SignUpForEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextEventsGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            //this.Name = "SignUpForEventForm";
            this.Text = "SignUpForEventForm";
            this.Load += new System.EventHandler(this.SignUpForEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaterEventBiding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextEventsGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MemberBinding;
        private System.Windows.Forms.BindingSource LaterEventBiding;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBAN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource nextBindingSource;
        private System.Windows.Forms.DataGridView nextEventsGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextResponsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextEndDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaterEventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaterResponsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaterStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaterEndDate;
    }
}