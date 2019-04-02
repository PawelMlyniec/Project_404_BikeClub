namespace BikeClubGUI
{
    partial class BikeClubApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpForEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.registerToolStripMenuItem,
            this.eventsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.loginToolStripMenuItem.Text = "Log in";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerMemberToolStripMenuItem,
            this.registerChildToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // registerMemberToolStripMenuItem
            // 
            this.registerMemberToolStripMenuItem.Name = "registerMemberToolStripMenuItem";
            this.registerMemberToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.registerMemberToolStripMenuItem.Text = "Register member";
            this.registerMemberToolStripMenuItem.Click += new System.EventHandler(this.registerMemberToolStripMenuItem_Click);
            // 
            // registerChildToolStripMenuItem
            // 
            this.registerChildToolStripMenuItem.Name = "registerChildToolStripMenuItem";
            this.registerChildToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.registerChildToolStripMenuItem.Text = "Register child";
            this.registerChildToolStripMenuItem.Click += new System.EventHandler(this.registerChildToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programEventToolStripMenuItem,
            this.signUpForEventToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Visible = false;
            // 
            // programEventToolStripMenuItem
            // 
            this.programEventToolStripMenuItem.Name = "programEventToolStripMenuItem";
            this.programEventToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.programEventToolStripMenuItem.Text = "Program event";
            this.programEventToolStripMenuItem.Click += new System.EventHandler(this.programEventToolStripMenuItem_Click);
            // 
            // signUpForEventToolStripMenuItem
            // 
            this.signUpForEventToolStripMenuItem.Name = "signUpForEventToolStripMenuItem";
            this.signUpForEventToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.signUpForEventToolStripMenuItem.Text = "Sign up for event";
            this.signUpForEventToolStripMenuItem.Click += new System.EventHandler(this.signUpForEventToolStripMenuItem_Click);
            // 
            // BikeClubApp
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BikeClubApp";
            this.Text = "BikeClubApp";
            this.Load += new System.EventHandler(this.BikeClubApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpForEventToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem registerChildToolStripMenuItem;
    }
}

