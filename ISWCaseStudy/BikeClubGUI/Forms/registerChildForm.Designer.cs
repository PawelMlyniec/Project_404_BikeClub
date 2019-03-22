namespace BikeClubGUI.Forms
{
    partial class registerChildForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childButtom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.children = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // childButtom
            // 
            this.childButtom.Location = new System.Drawing.Point(177, 332);
            this.childButtom.Name = "childButtom";
            this.childButtom.Size = new System.Drawing.Size(98, 43);
            this.childButtom.TabIndex = 0;
            this.childButtom.Text = "Add child";
            this.childButtom.UseVisualStyleBackColor = true;
            this.childButtom.Click += new System.EventHandler(this.addChildButtom);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Login,
            this.IBAN,
            this.children});
            this.dataGridView1.DataSource = this.membersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 165);
            this.dataGridView1.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Login.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IBAN
            // 
            this.IBAN.DataPropertyName = "IBAN";
            this.IBAN.HeaderText = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.ReadOnly = true;
            this.IBAN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IBAN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // children
            // 
            this.children.DataPropertyName = "children";
            this.children.HeaderText = "Member or children";
            this.children.Name = "children";
            this.children.ReadOnly = true;
            this.children.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.children.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // registerChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.childButtom);
           // this.Name = "registerChildForm";
          //  this.Text = "registerChild";
            this.Load += new System.EventHandler(this.registerChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.Button childButtom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn children;
    }
}