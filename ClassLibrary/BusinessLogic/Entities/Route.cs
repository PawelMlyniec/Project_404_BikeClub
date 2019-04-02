using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class Route
    {
        public Route()
        {
            SomeDaysEvent = new List<SomeDaysEvent>();
        }

        public Route(Difficulty difficulty, int distance, int ramp, string name, string start, string end) : this()
        {
            Difficulty = difficulty;
            Distance = distance;
            Ramp = ramp;
            Name = name;
            Start = start;
            End = end;
        }
    }
}


