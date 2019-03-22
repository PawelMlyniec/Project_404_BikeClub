using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class Votes
    {
        public Votes()
        {
            Election = new Election();
        }

        public Votes(bool hasVoted, int numberOfVotesReceived,Election election)
        {
            HasVoted = hasVoted;
            NumberOfVotesReceived = numberOfVotesReceived;
            Election = election;

        }
    }
}
