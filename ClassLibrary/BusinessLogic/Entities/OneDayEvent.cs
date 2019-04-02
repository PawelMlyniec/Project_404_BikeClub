using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class OneDayEvent
    {
        public OneDayEvent()
        {
            Route = new Route();
        }
        public OneDayEvent(Route route, DateTime startDate, string description, Member responsible) : base(startDate, description, responsible)
        {
            Route = route;
            StartDate = startDate;
            Description = description;
            Responsible = responsible;
        }

    }
}
