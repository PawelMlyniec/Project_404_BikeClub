using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeClubLib.BusinessLogic.Services;
using BikeClubLib.Services;
using BikeClubLib.Entities;

namespace BikeClubGUI.Forms
{
    public partial class AddChildForm : Form
    {
        private IBikeClubService service;
        public AddChildForm(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void AddChild_Load(object sender, EventArgs e)
        {
           


        }

        private void AddChildButtom(object sender, EventArgs e)
        {
            try
            {
              
                //service.register(service.generateID(), nameBox.ToString(), logBox.ToString(), passwordBox.ToString(), datePicker.Text, DateTime.Now);
                double toPay = service.registerChild(service.generateID(), NameBox.Text, LoginBox.Text, PasswordBox.Text, BirthPicker.Value, DateTime.Today);
                MessageBox.Show(this, "Your  child is registered. The payment is "+toPay+" euros.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ((registerChildForm)this.Owner).LoadData();
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
