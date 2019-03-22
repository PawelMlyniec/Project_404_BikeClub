namespace BikeClubGUI.Forms
{
    partial class UserInfoEventsForm
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
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsibleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addOneDayEventButton = new System.Windows.Forms.Button();
            this.addSomeDaysEventButton = new System.Windows.Forms.Button();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AutoGenerateColumns = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.ibanColumn,
            this.dateColumn});
            this.userDataGridView.DataSource = this.userBindingSource;
            this.userDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.Size = new System.Drawing.Size(446, 68);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AllowUserToAddRows = false;
            this.eventDataGridView.AllowUserToDeleteRows = false;
            this.eventDataGridView.AutoGenerateColumns = false;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionColumn,
            this.responsibleColumn,
            this.startDateColumn,
            this.endDateColumn});
            this.eventDataGridView.DataSource = this.eventBindingSource;
            this.eventDataGridView.Location = new System.Drawing.Point(12, 100);
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.ReadOnly = true;
            this.eventDataGridView.Size = new System.Drawing.Size(446, 150);
            this.eventDataGridView.TabIndex = 1;
            this.eventDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDataGridView_CellContentClick_1);
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.DataPropertyName = "descriptionColumn";
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            // 
            // responsibleColumn
            // 
            this.responsibleColumn.DataPropertyName = "responsibleColumn";
            this.responsibleColumn.HeaderText = "Responsible";
            this.responsibleColumn.Name = "responsibleColumn";
            this.responsibleColumn.ReadOnly = true;
            // 
            // startDateColumn
            // 
            this.startDateColumn.DataPropertyName = "startDateColumn";
            this.startDateColumn.HeaderText = "Start Date";
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.ReadOnly = true;
            // 
            // endDateColumn
            // 
            this.endDateColumn.DataPropertyName = "endDateColumn";
            this.endDateColumn.HeaderText = "End Date";
            this.endDateColumn.Name = "endDateColumn";
            this.endDateColumn.ReadOnly = true;
            // 
            // addOneDayEventButton
            // 
            this.addOneDayEventButton.Location = new System.Drawing.Point(12, 256);
            this.addOneDayEventButton.Name = "addOneDayEventButton";
            this.addOneDayEventButton.Size = new System.Drawing.Size(219, 43);
            this.addOneDayEventButton.TabIndex = 2;
            this.addOneDayEventButton.Text = "New one-day event";
            this.addOneDayEventButton.UseVisualStyleBackColor = true;
            this.addOneDayEventButton.Click += new System.EventHandler(this.addOneDayEventButton_Click_1);
            // 
            // addSomeDaysEventButton
            // 
            this.addSomeDaysEventButton.Location = new System.Drawing.Point(240, 256);
            this.addSomeDaysEventButton.Name = "addSomeDaysEventButton";
            this.addSomeDaysEventButton.Size = new System.Drawing.Size(219, 43);
            this.addSomeDaysEventButton.TabIndex = 3;
            this.addSomeDaysEventButton.Text = "New multiple-day event";
            this.addSomeDaysEventButton.UseVisualStyleBackColor = true;
            this.addSomeDaysEventButton.Click += new System.EventHandler(this.addSomeDaysEventButton_Click_1);
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "nameColumn";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // ibanColumn
            // 
            this.ibanColumn.DataPropertyName = "ibanColumn";
            this.ibanColumn.HeaderText = "IBAN";
            this.ibanColumn.Name = "ibanColumn";
            this.ibanColumn.ReadOnly = true;
            // 
            // dateColumn
            // 
            this.dateColumn.DataPropertyName = "dateColumn";
            this.dateColumn.HeaderText = "Date Of Birth";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            // 
            // UserInfoEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 326);
            this.Controls.Add(this.addSomeDaysEventButton);
            this.Controls.Add(this.addOneDayEventButton);
            this.Controls.Add(this.eventDataGridView);
            this.Controls.Add(this.userDataGridView);
            this.Name = "UserInfoEventsForm";
            this.Text = "UserInfoEventsForm";
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Button addOneDayEventButton;
        private System.Windows.Forms.Button addSomeDaysEventButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
    }
}