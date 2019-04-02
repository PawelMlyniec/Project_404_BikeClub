using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BikeClubLib.Entities;
using BikeClubLib.Persistence;
using BikeClubLib.Services;
using System.Data.Entity.Validation;

namespace BusinessLogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IBikeClubService service = new BikeClubService(new EntityFrameworkDAL(new BikeClubDbContext()));

                new Program(service);
            }
            catch (Exception e)
            {
                if (e is System.Data.Entity.Validation.DbEntityValidationException)
                {
                    foreach (var eve in (e as DbEntityValidationException).EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }

                }
                printError(e);
                Console.WriteLine("Press any key.");
                Console.ReadLine();
            }

        }

        private IBikeClubService service;

        Program(IBikeClubService service)
        {
            this.service = service;
            
            service.removeAllData();
            
            // Adding Club
            addClub();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Adding Members
            addMembers();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Testing login
            testLogin();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // More login testing
            testLogin2();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Adding Routes
            addRoutes();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Adding Events
            addEvents();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Adding event registrations
            addEventRegistrations();
            Console.WriteLine("FINISH - Press any key to continue...");
            Console.ReadKey();

        }


        static void printError(Exception e)
        {
            while (e != null)
            {
                Console.WriteLine("ERROR: " + e.Message);
                e = e.InnerException;
            }
        }

        void addClub()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING CLUB...");

            try
            {
                // public Club(String Name, Double Quota)
             
                service.createClub("BikeClub de L'Horta Nord", 24);

             

            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        String clubToString(Club c)
        {
            return "  Club name: " + c.Name + ", quota = " + c.Quota;
        }

        void addMembers()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING MEMBERS...");

            try
            {
            
                double quota;

                // Member(DateTime birthDate,  DateTime enrollmentDate, string iban, string login, string name, string password) 
     
                quota = service.register("12345678A", "Eddy Merckx", "emerckx", "xkcreme", "ES123456789012345678", Convert.ToDateTime("17/06/1945"), Convert.ToDateTime("20/05/2001"));
       
                quota = service.register("23456789B", "Bernard Hinault", "bhinault", "tluanihb", "ES234567890123456789", Convert.ToDateTime("14/11/1954"), Convert.ToDateTime("10/01/2010"));
        
                quota = service.register("34567890C", "Miguel Indurain", "mindurain", "niarudnim", "ES345678901234567890", Convert.ToDateTime("16/07/1964"), Convert.ToDateTime("23/08/2013"));
          
                quota = service.register("45678901D", "Rafa Nadal", "rnadal", "ladanr", "ES456789012345678901", Convert.ToDateTime("03/06/1986"), Convert.ToDateTime("20/05/2016"));
                // Mayor de 18 años
               service.login("emerckx", "xkcreme");
                quota = service.registerChild("56789012E", "Hijo de Eddy Merckx", "hijodeeddy", "yddeedojih",  Convert.ToDateTime("17/06/1965"), Convert.ToDateTime("20/05/2001"));
                // Mayor de 18 años
                service.login("bhinault", "tluanihb");
                quota = service.registerChild("67890123B", "Hijo de Bernard Hinault", "hijodebhinault", "tluanihbedojih",  Convert.ToDateTime("14/11/1974"), Convert.ToDateTime("10/01/2010"));
                // Menor de 18 años
                service.login("mindurain", "niarudnim");
                quota = service.registerChild("78901234C", "Hijo de Miguel Indurain", "hijodemindurain", "niarudnimedojih",  Convert.ToDateTime("16/07/2004"), Convert.ToDateTime("23/10/2018"));

                foreach (Member m in service.getAllMembers())
                {
                    Console.WriteLine(memberToString(m));
                    if (m.Children.Count() > 0)
                        foreach (Member s in m.Children)
                            Console.WriteLine("     Son" + memberToString(s));

                    if (m.Parent != null)
                        Console.WriteLine("     Parent" + memberToString(m.Parent));

                    foreach (Payment p in m.Payments)
                        Console.WriteLine("         " + p.Description + ", date: " + p.Date.ToString("dd/MM/yyyy") + ", quantity: " + p.Quantity);
                }

                service.definePresident("34567890C");

                Console.WriteLine();
                Console.WriteLine("  ACTUAL PRESIDENT: " + service.getClub().ActualPresident.Name);
            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        String memberToString(Member m)
        {
            return "  Name: " + m.Name + ", login: " + m.Login + ", password: " + m.Password;
        }

        void testLogin()
        {
            Member m;
            Console.WriteLine();
            Console.WriteLine("TESTING LOGIN...");

            try
            {
                m = service.login("mindurain", "niarudnim");
                if (m != null)
                    Console.WriteLine("  Login " + m.Name);
                else
                    Console.WriteLine("  NOLOGIN");

                m = service.login("mindurain", "niarubnim");
                if(m != null)
                    Console.WriteLine("  Login " + m.Name);
                else
                    Console.WriteLine("  NOLOGIN");

                m = service.login("mind", "dnim");
                if(m != null)
                    Console.WriteLine("  Login " + m.Name );
                else
                    Console.WriteLine("  NOLOGIN");

            }
            catch (Exception e)
            {
                printError(e);
            }
        }


        void testLogin2()
        {
            Member m;
            Console.WriteLine();
            Console.WriteLine("TESTING MORE ABOUT LOGIN...");

            try
            {
                m = service.getLoggedMember();
                if (m != null)
                    Console.WriteLine("  Logged " + m.Name);
                else
                    Console.WriteLine("  NOLOGIN");

                service.logout();

                m = service.getLoggedMember();
                if (m != null)
                    Console.WriteLine("  Logged " + m.Name);
                else
                    Console.WriteLine("  NOLOGGED");

            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        void addRoutes()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING ROUTES...");

            try
            {
                // public Route(String Name, String Start, String End, int Ramp, int Distance, Difficulty dif)
                //public void createRoute(string Name, string Start, string End, int Ramp, int Distance, Difficulty dif)
              
                service.createRoute("Valencia 1", "Parque de Cabecera", "Bioparc", 0, 20, Difficulty.easy);
               
                service.createRoute("Valencia 2", "Estació del Nord", "Puerto", 0, 25, Difficulty.easy);

                service.createRoute("Valencia 3", "Pinedo", "Palmar", 0, 25, Difficulty.medium);
           
                service.createRoute("Camino Santiago", "Roncesvalles", "Santiago", 1079, 762, Difficulty.pro);

                foreach (Route r in service.getAllRoutes())
                    Console.WriteLine(routeToString(r));
            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        String routeToString(Route r)
        {
            return "  Name: " + r.Name + ", Start: " + r.Start + ", End: " + r.End + ", Ramp: " +  r.Ramp + ", Distance: " + r.Distance + ", Difficulty: " + r.Difficulty;
        }


        void addEvents()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING EVENTS...");

            try
            {
                Member m1 = service.login("emerckx", "xkcreme");

                // public OneDayEvent(String description, DateTime startDate,  Route route)
             
                service.createOneDayEvent("Paseito por el rio Turia", Convert.ToDateTime("27/10/2018"), "Valencia 1");
                service.logout();

                Member m2 = service.login("bhinault", "tluanihb");
              
                service.createOneDayEvent("Paseito por el centro", DateTime.Today.AddDays(1), "Valencia 2");
                service.logout();

                Member m3 = service.login("mindurain", "niarudnim");
       
                service.createOneDayEvent("Paseito por la playa", Convert.ToDateTime("26/12/2018"), "Valencia 3");


                service.createOneDayEvent("Paseito por el norte", Convert.ToDateTime("28/12/2018"), "Camino Santiago");
                service.logout();

                Member m6 = service.login("hijodebhinault", "tluanihbedojih");
                // public SomeDaysEvent(String description, DateTime startDate, Member resp, DateTime finishDate)
                
                
                List < string > init = new List<string>(new string[] { "Valencia 1", "Valencia 2", "Valencia 3" });
                service.createSomeDaysEvent("Vuelta a España", Convert.ToDateTime("01/01/2019"), Convert.ToDateTime("05/01/2019"),init );


                   
                init.Add("Valencia 4");
                //exception here (Valencia 4 does not exist)
                service.createSomeDaysEvent("Vuelta a España 2", Convert.ToDateTime("02/02/2019"),  Convert.ToDateTime("06/02/2019"),init);
             

                service.logout();

                foreach (Event e in service.getAllEvents())
                    if(e is OneDayEvent )
                        Console.WriteLine(eventToString((OneDayEvent)e));
                    else
                        Console.WriteLine(eventToString((SomeDaysEvent)e));

            }
            catch (Exception e)
            {
                printError(e);
            }
        }

        String eventToString(OneDayEvent ode)
        {
            return "  Description: " + ode.Description + ", Route: " + ode.Route.Name + ", StartDate: " + ode.StartDate.ToString("dd/MM/yyyy");
        }

        String eventToString(SomeDaysEvent sde)
        {
            return "  Description: " + sde.Description + ", Routes: " + sde.Routes.Count() + ", StartDate: " + sde.StartDate.ToString("dd/MM/yyyy") + ", FinishDate: " + sde.FinishDate.ToString("dd/MM/yyyy");
        }

        void addEventRegistrations()
        {
            Console.WriteLine();
            Console.WriteLine("ADDING EVENT REGISTRATIONS...");

            try
            {
                Member m1 = service.login("emerckx", "xkcreme");

                // public OneDayEvent(String description, DateTime startDate,  Route route)

                service.signUpEvent("Paseito por el rio Turia");
                service.logout();

                Member m2 = service.login("bhinault", "tluanihb");

                service.signUpEvent("Paseito por el centro");
                service.logout();

                Member m3 = service.login("mindurain", "niarudnim");

                service.signUpEvent("Paseito por la playa");



                service.signUpEvent("Paseito por el norte");
                service.logout();


                foreach (Member m in service.getMembersSignUpEvent("Paseito por la playa")) {
                    Console.WriteLine("  " + m.Name + " registered to " + "Paseito por la playa");
                    }
            }
            catch (Exception e)
            {
                printError(e);
            }

         

            try
            {
                SomeDaysEvent e5 = service.findSomeDaysEventByDescription("Vuelta a España");
                Member m1 = service.login("emerckx", "xkcreme");

                // public OneDayEvent(String description, DateTime startDate,  Route route)

                service.signUpEvent("Vuelta a España");
                service.logout();

                Member m2 = service.login("bhinault", "tluanihb");

                service.signUpEvent("Vuelta a España");
                service.logout();

                Member m3 = service.login("mindurain", "niarudnim");

                service.signUpEvent("Vuelta a España");


                service.logout();

             

            }
            catch (Exception e)
            {
                printError(e);
            }
        }


    }
}
