using System;
using BikeClubLib.BusinessLogic.Services;
using BikeClubLib.Services;
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
    public partial class registerMemberForm : Form
    {
        private IBikeClubService service;
   
        public registerMemberForm(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {

                //service.register(service.generateID(), nameBox.ToString(), logBox.ToString(), passwordBox.ToString(), datePicker.Text, DateTime.Now);
                double toPay = service.register(service.generateID(), nameText.Text, loginBox.Text, passBox.Text, ibanBoxx.Text, birthPicker.Value);
                
                MessageBox.Show(this, "You are registered. You have to pay "+toPay+" euros.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (ServiceException exception)
            {
                DialogResult answer = MessageBox.Show(this, exception.Message, "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                if (answer == DialogResult.Cancel)
                {
                    this.Close();
                }

            }
            
        }
    }
}
