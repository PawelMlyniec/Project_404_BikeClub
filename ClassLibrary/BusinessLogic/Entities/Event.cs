using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class Event
    {
        public Event(Event a)
        {
          
        }
        public Event()
        {
         
            Members = new List<Member>();
        }

        public Event(DateTime startDate, string description, Member responsible):this()
        {
            StartDate = startDate;
            Description = description;
            Responsible = responsible;
        }




    }
}
