using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class Club
    {
        public Club()
        {
            Members = new List<Member>();
            Vocals = new List<Member>();
            Elections = new List<Election>();
        }
        public Club(double quota, string name, Member treasurer, Member actualPresident) : this()
        {
            Quota = quota;
            
            Name = name;
            Treasurer = treasurer;
            ActualPresident = actualPresident;
        }

    }
}
