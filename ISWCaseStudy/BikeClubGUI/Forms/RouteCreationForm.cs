using BikeClubLib.BusinessLogic.Services;
using BikeClubLib.Entities;
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

namespace BikeClubGUI.Forms
{
    public partial class RouteCreationForm : Form
    {
        private IBikeClubService service;
        public RouteCreationForm(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
            difficultyComboBox.DataSource = Enum.GetValues(typeof(Difficulty));
      
        }


        private void RouteCreationForm_Load(object sender, EventArgs e)
        {
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string start = startTextBox.Text;
                string end = endTextBox.Text;
                int ramp = (int)rampBox.Value;
                int distance;
                Difficulty dif;
                Enum.TryParse<Difficulty>(difficultyComboBox.SelectedValue.ToString(), out dif);

                if (!(Int32.TryParse(distanceTextBox.Text, out distance)))
                {
                    MessageBox.Show(this, "Distance must be an integer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    service.createRoute(name, start, end, ramp, distance, dif);
                    MessageBox.Show(this, "New route created successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (this.Owner is OneDayEventForm) ((OneDayEventForm)this.Owner).LoadData();
                    else ((SomeDaysEventForm)this.Owner).LoadData();

                    this.Close();
                }
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
            catch (Exception exception)
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
