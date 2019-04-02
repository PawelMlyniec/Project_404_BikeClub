using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeClubLib.Services;
using BikeClubGUI.Forms;

namespace BikeClubGUI
{
    public partial class BikeClubApp : Form
    {
        private IBikeClubService service;
        private LoginForm loginForm;
        //private ProgramEventForm programEventForm;
        private registerMemberForm registerMemberForm;
        private OneDayEventForm oneDayEventForm;
        private SomeDaysEventForm someDaysEventForm;
        private registerChildForm registerChildForm;
        private SignUpForEventForm signUpForEventForm;
        private UserInfoEventsForm userInfoEventsForm;
        
        public BikeClubApp(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
                      
            registerChildToolStripMenuItem.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm(service);
            loginForm.ShowDialog(this);

         

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                service.logout();
                MessageBox.Show("User logged out.");
                logoutToolStripMenuItem.Visible = false;
                eventsToolStripMenuItem.Visible = false;
                loginToolStripMenuItem.Visible = true;
                clearDatabaseToolStripMenuItem.Visible = true;
                registerChildToolStripMenuItem.Visible = false;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really wanto to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                service.saveChanges();
                //service.removeAllData();
                this.Close();
            }

        }

        private void programEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userInfoEventsForm = new UserInfoEventsForm(service);
            userInfoEventsForm.ShowDialog();
        }

        private void registerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerMemberForm = new registerMemberForm(service);
            registerMemberForm.ShowDialog();
        }

        private void BikeClubApp_Load(object sender, EventArgs e)
        {

        }

        private void onedayEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oneDayEventForm = new OneDayEventForm(service);
            oneDayEventForm.ShowDialog();
        }

        private void registerChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerChildForm = new registerChildForm(service);
            registerChildForm.ShowDialog();
        }

        private void multipledayEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            someDaysEventForm = new SomeDaysEventForm(service);
            someDaysEventForm.ShowDialog();
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service.removeAllData();
            MessageBox.Show(this, "Database cleared.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void signUpForEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            signUpForEventForm = new SignUpForEventForm(service);
            signUpForEventForm.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
