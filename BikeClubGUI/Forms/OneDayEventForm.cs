using BikeClubLib.BusinessLogic.Services;
using BikeClubLib.Entities;
using BikeClubLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeClubGUI.Forms
{

    public partial class OneDayEventForm : Form
    {
        protected IBikeClubService service;
        protected RouteCreationForm routeCreationForm;
        public OneDayEventForm()
        {
            InitializeComponent();
        }
        public OneDayEventForm(IBikeClubService service) :this()
        {
            
            this.service = service;
            this.routeCreationForm = new RouteCreationForm(service);
            LoadData();
        }

        public void LoadData()
        {
            IEnumerable<Route> routes = service.getAllRoutes();
            BindingList<object> bindingList = new BindingList<object>();
            foreach (Route r in routes)
            {
                 bindingList.Add(new
                    {
                        route_name = r.Name,
                        startColumn= r.Start,
                        endColumn = r.End,
                        Difficulty = r.Difficulty.ToString(),
                        Ramp = r.Ramp,
                        Distance = r.Distance


                    });
            }
            routesBindingSource.DataSource = bindingList;

        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            routeCreationForm.ShowDialog(this);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                string description = descriptionTextBox.Text;
                DateTime startDate = startDateTimePicker.Value;
                if (routeDataGridView.CurrentRow == null) throw new ServiceException("Pick a route.");
                string nameRoute = routeDataGridView.CurrentRow.Cells[0].Value.ToString();
                service.createOneDayEvent(description, startDate, nameRoute);
                ((UserInfoEventsForm)this.Owner).LoadData();
                
                MessageBox.Show(this, "New Event created successfully.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);


                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                MessageBox.Show(this, exceptionMessage, "Error",
                   MessageBoxButtons.RetryCancel,
                   MessageBoxIcon.Error);
            }
        }

        private void routeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OneDayEventForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
