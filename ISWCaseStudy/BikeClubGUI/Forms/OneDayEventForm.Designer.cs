namespace BikeClubGUI.Forms
{
    partial class OneDayEventForm
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.routeLabel = new System.Windows.Forms.Label();
            this.addRouteButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.routeDataGridView = new System.Windows.Forms.DataGridView();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.route_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ramp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.AcceptsTab = true;
            this.descriptionTextBox.Location = new System.Drawing.Point(15, 30);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(255, 20);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 12);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(69, 15);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.startDateLabel.Location = new System.Drawing.Point(12, 53);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(59, 15);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "Start date";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(15, 74);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Location = new System.Drawing.Point(12, 104);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(80, 15);
            this.routeLabel.TabIndex = 4;
            this.routeLabel.Text = "Select Route:";
            // 
            // addRouteButton
            // 
            this.addRouteButton.Location = new System.Drawing.Point(122, 100);
            this.addRouteButton.Name = "addRouteButton";
            this.addRouteButton.Size = new System.Drawing.Size(75, 27);
            this.addRouteButton.TabIndex = 6;
            this.addRouteButton.Text = "New route";
            this.addRouteButton.UseVisualStyleBackColor = true;
            this.addRouteButton.Click += new System.EventHandler(this.addRouteButton_Click);
            // 
            // okButton
            // 
            this.okButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okButton.Location = new System.Drawing.Point(0, 315);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(662, 42);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // routeDataGridView
            // 
            this.routeDataGridView.AllowUserToAddRows = false;
            this.routeDataGridView.AllowUserToDeleteRows = false;
            this.routeDataGridView.AutoGenerateColumns = false;
            this.routeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.route_name,
            this.startColumn,
            this.end,
            this.Difficulty,
            this.Ramp,
            this.Distance});
            this.routeDataGridView.DataSource = this.routesBindingSource;
            this.routeDataGridView.Location = new System.Drawing.Point(15, 133);
            this.routeDataGridView.Name = "routeDataGridView";
            this.routeDataGridView.ReadOnly = true;
            this.routeDataGridView.Size = new System.Drawing.Size(635, 150);
            this.routeDataGridView.TabIndex = 8;
            this.routeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.routeDataGridView_CellContentClick);
            // 
            // route_name
            // 
            this.route_name.DataPropertyName = "route_name";
            this.route_name.HeaderText = "Route Name";
            this.route_name.Name = "route_name";
            this.route_name.ReadOnly = true;
            this.route_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // startColumn
            // 
            this.startColumn.DataPropertyName = "startColumn";
            this.startColumn.HeaderText = "Start";
            this.startColumn.Name = "startColumn";
            this.startColumn.ReadOnly = true;
            this.startColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // end
            // 
            this.end.DataPropertyName = "endColumn";
            this.end.HeaderText = "End";
            this.end.Name = "end";
            this.end.ReadOnly = true;
            // 
            // Difficulty
            // 
            this.Difficulty.DataPropertyName = "Difficulty";
            this.Difficulty.HeaderText = "Difficulty";
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.ReadOnly = true;
            this.Difficulty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Ramp
            // 
            this.Ramp.DataPropertyName = "Ramp";
            this.Ramp.HeaderText = "Ramp";
            this.Ramp.Name = "Ramp";
            this.Ramp.ReadOnly = true;
            this.Ramp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Distance
            // 
            this.Distance.DataPropertyName = "Distance";
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            this.Distance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // OneDayEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 357);
            this.Controls.Add(this.routeDataGridView);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.addRouteButton);
            this.Controls.Add(this.routeLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "OneDayEventForm";
            this.Text = "New one-day event";
            this.Load += new System.EventHandler(this.OneDayEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.Button addRouteButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private System.Windows.Forms.DataGridView routeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn route_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn startColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difficulty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ramp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
    }
}