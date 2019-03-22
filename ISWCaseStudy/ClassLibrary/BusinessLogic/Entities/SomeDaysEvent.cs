using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class SomeDaysEvent
    {
        public SomeDaysEvent()
        {
            Routes = new List<Route>();
        }
        public SomeDaysEvent(List<Route> routes, DateTime startDate, DateTime finishDate, string description, Member responsible) : base(startDate, description, responsible)
        {
            Routes = routes;
            StartDate = startDate;
            Description = description;
            FinishDate = finishDate;
            Responsible = responsible;
            

        }


    }
}
