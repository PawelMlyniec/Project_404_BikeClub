using BikeClubLib.BusinessLogic.Services;
using BikeClubLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeClubGUI.Forms;

namespace BikeClubGUI.Forms
{
    public partial class LoginForm : Form
    {
        private IBikeClubService service;
         
        public LoginForm(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void okButton_Click(object sender, EventArgs e) 
        {            
            try
            {
                service.login(textBoxUsername.Text, textBoxPassword.Text);
                ((BikeClubApp)this.Owner).logoutToolStripMenuItem.Visible = true;
                ((BikeClubApp)this.Owner).eventsToolStripMenuItem.Visible = true;
                ((BikeClubApp)this.Owner).loginToolStripMenuItem.Visible = false;
                ((BikeClubApp)this.Owner).clearDatabaseToolStripMenuItem.Visible = false;
                ((BikeClubApp)this.Owner).registerChildToolStripMenuItem.Visible = true;
                MessageBox.Show(this, "You are logged in", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            } catch (ServiceException exception)
            {
                DialogResult answer=MessageBox.Show(this, exception.Message, "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                if (answer == DialogResult.Cancel)
                {
                    this.Close();
                }
                              
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
