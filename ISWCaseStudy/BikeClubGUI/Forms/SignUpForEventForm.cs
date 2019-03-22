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
using BikeClubLib.Entities;
using BikeClubLib.Services;
using System.Data.Entity.Validation;

namespace BikeClubGUI.Forms
{
    public partial class SignUpForEventForm : Form
    {

        private IBikeClubService service;
        public SignUpForEventForm(IBikeClubService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {
            Member member = service.getLoggedMember();
            BindingList<object> bindingList1 = new BindingList<object>();
            IEnumerable<Member> memberChildern = service.getChildren();
            bindingList1.Add(new
            {
                Name = member.Name,
                Login = member.Login,
                IBAN = member.IBAN,
               
            });
            MemberBinding.DataSource = bindingList1;


            IEnumerable<Event> events = service.getActualSingUpEvents();
            BindingList<object> bindingList2 = new BindingList<object>();
            foreach (Event e in events)
            {
                string endDate;
                if (e is SomeDaysEvent) endDate = (e as SomeDaysEvent).FinishDate.ToString("dd/MM/yyyy");
                else endDate = "One-day event";

                bindingList2.Add(new
                {
                    LaterEventName = e.Description,
                    LaterResponsible = e.Responsible.Name,
                    LaterStartDate = e.StartDate,
                    LaterEndDate = endDate
                });
            }
        
            LaterEventBiding.DataSource = bindingList2;

            ///////////////////////
            ///////////////////////////
            IEnumerable<Event> nextEvents = service.getActualEvents();
            ///////////////////
            BindingList<object> bindingList3 = new BindingList<object>();
            foreach (Event e in nextEvents)
            {
                
                    string nextEndDate;
                    if (e is SomeDaysEvent) nextEndDate = (e as SomeDaysEvent).FinishDate.ToString("dd/MM/yyyy");
                    else nextEndDate = "One-day event";

                    bindingList3.Add(new
                    {
                        NextEventName = e.Description,
                        NextResponsible = e.Responsible.Name,
                        NextStartDate = e.StartDate,
                        NextEndDate = nextEndDate
                    });
                

            }
            nextBindingSource.DataSource = bindingList3;

        
        }

        private void SignUpClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void addEventButtom(object sender, EventArgs e)
        {
            try
            {
                string description;
                if (nextEventsGridView3.CurrentRow == null)
                    return;
                 description = nextEventsGridView3.CurrentRow.Cells[0].Value.ToString();
                
                service.signUpEvent(description);
                
                Event infoEvent = service.findEventByDescription(description);
                string endDate;
                if (infoEvent is SomeDaysEvent) endDate = (infoEvent as SomeDaysEvent).FinishDate.ToString("dd/MM/yyyy");
                else endDate = "One-day event";
                string message = "Event: " + infoEvent.Description.ToString() + " Starts " + infoEvent.StartDate.ToString("dd/MM/yyyy")
                    + "Ends :    " + endDate +  "\n Sign Up for this event?"; 
                MessageBox.Show(this, message , "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                LoadData();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SignUpForEventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
