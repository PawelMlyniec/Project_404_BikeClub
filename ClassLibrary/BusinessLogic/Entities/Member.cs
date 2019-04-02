using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeClubLib.Entities
{
    public partial class Member
    {
        public Member()
        {
            Children = new List<Member>();
            ProposedEvents = new List<Event>();
            Events = new List<Event>();
            Payments = new List<Payment>();
            Votes = new List<Votes>();
        }

        public Member(DateTime birthDate,  DateTime enrollmentDate, string iban, string login, string name, string password) : this()
        {
            BirthDate = birthDate;
           
            EnrollmentDate = enrollmentDate;
            IBAN = iban;
            Login = login;
            Name = name;
            Password = password;
        }
        public Member(string id, DateTime birthDate, DateTime enrollmentDate, string iban, string login, string name, string password) : this()
        {
            BirthDate = birthDate;
            ID = id;
            EnrollmentDate = enrollmentDate;
            IBAN = iban;
            Login = login;
            Name = name;
            Password = password;
        }
    }
}
