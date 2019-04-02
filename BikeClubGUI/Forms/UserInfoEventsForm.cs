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
    public partial class UserInfoEventsForm : Form
    {
        private IBikeClubService service;
        private SomeDaysEventForm someDaysEventForm;
        private OneDayEventForm oneDayEventForm;
        public UserInfoEventsForm(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
            oneDayEventForm = new OneDayEventForm(service);
            someDaysEventForm = new SomeDaysEventForm(service);
        }

        public void LoadData()
        {
            //try
            //{
                IEnumerable<Event> events = service.getActualEvents();
                BindingList<object> bindingList = new BindingList<object>();
                foreach (Event e in events)
                {
                    
                    if (DateTime.Compare(DateTime.Today, e.StartDate)<0 || true)
                    {
                        string endDate;
                        if (e is SomeDaysEvent) endDate = (e as SomeDaysEvent).FinishDate.ToString("dd/MM/yyyy");
                        else endDate = "One-day event";

                        bindingList.Add(new
                        {
                            descriptionColumn = e.Description,
                            responsibleColumn = e.Responsible.Name,
                            startDateColumn = e.StartDate.ToString("dd/MM/yyyy"),
                            endDateColumn = endDate
                        });
                    }
                }
                eventBindingSource.DataSource = bindingList;

                Member user = service.getLoggedMember();
                BindingList<object> userInfo = new BindingList<object>();
                userInfo.Add(new
                {
                    nameColumn = user.Name,
                    ibanColumn = user.IBAN,
                    dateColumn = user.BirthDate.ToString("dd/MM/yyyy")
                });
                userBindingSource.DataSource = userInfo;
           /* } catch (Exception exception)
            {
                DialogResult answer = MessageBox.Show(this, exception.Message, "Error",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error);
                if (answer == DialogResult.Cancel)
                {
                    this.Close();
                }
            }*/

        }

       

        private void UserInfoEventsForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void addOneDayEventButton_Click_1(object sender, EventArgs e)
        {
            oneDayEventForm.ShowDialog(this);
        }

        private void addSomeDaysEventButton_Click_1(object sender, EventArgs e)
        {
            someDaysEventForm.ShowDialog(this);
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
