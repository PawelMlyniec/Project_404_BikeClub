using BikeClubLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeClubLib.Entities;
using BikeClubLib.Persistence;
using BikeClubLib.BusinessLogic.Services;
using System.Data.Entity.Validation;

namespace BikeClubLib.Services
{
    public class BikeClubService : IBikeClubService
       

    {
        BikeClubLib.Entities.Member logged;

        private readonly IDAL dal;

        public BikeClubService(IDAL dal)
        {
            this.dal = dal;
            logged = null;
        }
       
        public void createClub(string name, double quota)
        {
            if (getClub() != null) throw new ServiceException("The club already exists!");
            dal.Insert<Club>(new Club(quota, name, null, null));
            saveChanges();
        
        }

        public void createOneDayEvent(string description, DateTime startDate, string nameRoute)
        {
            Route route = findRouteByName(nameRoute);
            if (route == null) throw new ServiceException("This route does not exist!");
            dal.Insert<OneDayEvent>(new OneDayEvent(route, startDate, description, getLoggedMember()));
            saveChanges();
        }

        public void createRoute(string Name, string Start, string End, int Ramp, int Distance, Difficulty dif)
        {
            if (findRouteByName(Name) != null) throw new ServiceException("Route with this name already exists!");
            if (Name == "" || Start == "" || End == "") throw new ServiceException("Name, start and finish cannot be empty!");
            dal.Insert<Route>(new Route(dif, Distance, Ramp, Name, Start, End));
            saveChanges();
        }

        public void createSomeDaysEvent(string description, DateTime startDate, DateTime finishDate, List<string> routes)
        {
            if (!routes.Any()) throw new ServiceException("Route list cannot be empty");

            List<Route> routeList = new List<Route>();
            foreach(string name in routes)
            {
                Route route = findRouteByName(name);
                if (route == null) throw new ServiceException("One of the given routes does not exist!");
                routeList.Add(route);
            }

            if (DateTime.Compare(startDate, finishDate) > 0) throw new ServiceException("Start date cannot be later than finish date!");
            
            dal.Insert<SomeDaysEvent>(new SomeDaysEvent(routeList, startDate, finishDate, description, getLoggedMember()));
            saveChanges();
        }

        public SomeDaysEvent createSomeDaysEvent(string description, DateTime startDate, DateTime finishDate)
        {
            SomeDaysEvent sde = new SomeDaysEvent(null, startDate, finishDate, description, getLoggedMember());
            dal.Insert<SomeDaysEvent>(sde);
            saveChanges();
            return sde;
        }

        

        public void definePresident(string ID)
        {
            if (dal.GetById<Member>(ID) == null) throw new ServiceException("There is no such member!");
            if (getClub() == null) throw new ServiceException("Create the club first!");
            getClub().ActualPresident = dal.GetById<Member>(ID);
            saveChanges();
        }

        public Event findEventByDescription(string description)
        {
            return dal.GetWhere<Event>(e =>e.Description == description).FirstOrDefault();
        }
        public OneDayEvent findOneDayEventByDescription(string description)
        {
            return dal.GetWhere<OneDayEvent>(e => e.Description == description).FirstOrDefault();
        }

        public SomeDaysEvent findSomeDaysEventByDescription(string description)
        {
            return dal.GetWhere<SomeDaysEvent>(e => e.Description == description).FirstOrDefault();
        }

        public Route findRouteByName(string name)
        {
            return dal.GetWhere<Route>(r => r.Name == name).FirstOrDefault();
        }

        public IEnumerable<Event> getActualEvents()
        {
                        
           return dal.GetWhere<Event>(ev => ev.StartDate > DateTime.Today);
        }

        public IEnumerable<Event> getActualProposedEvents()
        {
            
            SomeDaysEvent e;
            return getLoggedMember().ProposedEvents.Where<Event>(ev => (ev is OneDayEvent && ev.StartDate.Date > DateTime.Now.Date) || ((e = ev as SomeDaysEvent) != null && e.StartDate.Date > DateTime.Now.Date && e.FinishDate >= DateTime.Now.Date));
         
        }


        public IEnumerable<Event> getActualSingUpEvents()
        {
          
            SomeDaysEvent e;
               return getLoggedMember().Events.Where<Event>(ev => ev.StartDate>DateTime.Now);

       
        }

        public IEnumerable<Event> getAllEvents()
        {
            return dal.GetAll<Event>();
        }

        public IEnumerable<Member> getAllMembers()
        {
            return dal.GetAll<Member>();
        }

        public IEnumerable<Route> getAllRoutes()
        {
            return dal.GetAll<Route>();
        }

        public IEnumerable<Member> getChildren()
        {
            return getLoggedMember().Children;
        }

        public Club getClub()
        {
            return dal.GetAll<Club>().FirstOrDefault();
        }

        public Member getLoggedMember()
        {
            if (logged == null)
                throw new ServiceException("No member logged");
            else
                return logged;

        }

        public IEnumerable<Member> getMembersSignUpEvent(string description)
        {
            return getAllMembers().Where<Member>(member => member.Events.Where<Event>(ev => ev.Description == description) != null);
        }

        public Member login(string username, string password)
        {
            if (username == null || password == null)
                throw new ServiceException("Incorrect data");

            if ((logged = dal.GetWhere<Member>(person => person.Login == username && person.Password == password).FirstOrDefault()) == null)
                throw new ServiceException("Login or password incorrect");
            else
            {
                saveChanges();
                return logged;
            }


        }

        public void logout()
        {
            logged = null;
            saveChanges();
        }

        

        public double register(string ID, string Name, string Login, string Password, string IBAN, DateTime BirthDate, DateTime EnrollmentDate)
        {
            if (dal.GetWhere<Member>(person => person.Login == Login).FirstOrDefault() != null)
                throw new ServiceException("This login already exists");
       
            if (dal.GetById<Member>(ID) == null)
            {
                if (DateTime.Now.Year - BirthDate.Year < 18) throw new ServiceException("You must be at least 18 years old in the year you sign up.");
                Member member = new Member(ID, BirthDate, EnrollmentDate, IBAN, Login, Name, Password);
                dal.Insert<Member>(member);
                double toPay = (12 - EnrollmentDate.Month + 1) * 2;
                Payment payment = new Payment(EnrollmentDate, "First payment", toPay);
                member.Payments.Add(payment);
                dal.Insert<Payment>(payment);
                saveChanges();
                return toPay;
            }
            else throw new ServiceException("This person is already registered.");
            
        }

        public double register(string ID, string Name, string Login, string Password, string IBAN, DateTime BirthDate)
        {
            return register(ID, Name, Login, Password, IBAN, BirthDate, DateTime.Now);
        }

        public string generateID()
        {
            Random rnd = new Random();
            int i = rnd.Next(100000000, 999999999);
            while(dal.GetWhere<Member>(person => person.ID == i.ToString()).FirstOrDefault() != null)
                i = rnd.Next(100000000, 999999999);
            return i.ToString();
        }


        public double registerChild(string ID, string Name, string Login, string Password, DateTime BirthDate, DateTime EnrollmentDate)
        {
            
            if (dal.GetWhere<Member>(person => person.Login == Login).FirstOrDefault() != null)
                throw new ServiceException("This login already exists");
            if (dal.GetById<Member>(ID) == null)
            {
                string iban = getLoggedMember().IBAN;
                Member child = new Member(ID, BirthDate, EnrollmentDate, iban, Login, Name, Password);
                dal.Insert<Member>(child);
                getLoggedMember().Children.Add(child);
                double toPay;
                if (DateTime.Today.Year - BirthDate.Year >= 18) toPay = (12 - EnrollmentDate.Month + 1) * 2;
                else toPay = 12 - EnrollmentDate.Month + 1;
                Payment payment = new Payment(EnrollmentDate, "First payment", toPay);
                dal.Insert<Payment>(payment);
                child.Payments.Add(payment);
                saveChanges();
                return toPay;
            }
            else throw new ServiceException("This person is already registered.");
        }

        public double registerChild(string ID, string Name, string Login, string Password, DateTime BirthDate)
        {
            return registerChild(ID, Name, Login, Password, BirthDate, DateTime.Now);
        }

      

        public void removeAllData()
        {
            //clearing relationships
            if (dal.GetAll<Club>().Any())
            {
                Club c = dal.GetAll<Club>().First();

                Member president = c.ActualPresident;
                c.ActualPresident = null;

                Member treasurer = c.Treasurer;
                c.Treasurer = null;

                dal.Commit();
            }
            foreach (Route route in dal.GetAll<Route>())
            {
                //Console.WriteLine(route.Name);
            }
            dal.Clear<Club>();
            dal.Clear<Member>();
            dal.Clear<Election>();
            dal.Clear<Event>();
            dal.Clear<Payment>();
            dal.Clear<OneDayEvent>();
            dal.Clear<Route>();
            dal.Clear<SomeDaysEvent>();
            dal.Clear<Votes>();
            dal.Commit();
            
        }

        public void saveChanges()
        {
            dal.Commit();
        }

        public void signUpEvent(string description)
        {
            if (findEventByDescription(description) == null) throw new ServiceException("This event does not exist");
            getLoggedMember().Events.Add(findEventByDescription(description));
            dal.Commit();          
            
        }
    }
}
