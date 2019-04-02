using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeClubLib.Entities;

namespace BikeClubLib.Services
{
    public interface IBikeClubService
    {
        // Borra toda la información de la base de datos
        void removeAllData();
        // Guarda todos los cambios en la base de datos
        void saveChanges();

        // Creación de un club 
        void createClub(String name, double quota);
        // Asignación del presidente
        void definePresident(String ID);
        // Devolver el Club con el que se está trabajando
        Club getClub();

        // Caso de uso registrarse

        // Se introduce toda la información propia (incluyendo una fecha de alta)
        double register(String ID, String Name, String Login, String Password, String IBAN, DateTime BirthDate, DateTime EnrollmentDate);
        // Se introduce toda la información propia (sin incluir una fecha de alta porque se supone que es la fecha del sistema)
        double register(String ID, String Name, String Login, String Password, String IBAN, DateTime BirthDate);

        // Caso de uso registrar hijo

        // Se introduce toda la información propia (incluyendo una fecha de alta), no se incluye IBAN porque es el mismo que su padre
        // Su padre es el usuario autenticado
        double registerChild(String ID, String Name, String Login, String Password, DateTime BirthDate, DateTime EnrollmentDate);
        // Se introduce toda la información propia (sin incluir una fecha de alta), no se incluye IBAN porque es el mismo que su padre
        // Su padre es el usuario autenticado
        double registerChild(String ID, String Name, String Login, String Password, DateTime BirthDate);
        string generateID();
      

        // Devuelve los hijos del miembro autenticado
        IEnumerable<Member> getChildren();

        // Devolver todos los miembros 
        IEnumerable<Member> getAllMembers();

        //Caso de uso login
        Member login(String username, String password);
        void logout();

        //Recuperar el miembro conectado
        Member getLoggedMember();     

        //Caso de uso Programar evento
        // Crear un evento de un día
        void createOneDayEvent(String description, DateTime startDate, String nameRoute);
        // Crear un evento de varios días sin rutas
        SomeDaysEvent createSomeDaysEvent(String description, DateTime startDate, DateTime finishDate);
        // Crear un evento de varios días con rutas
        void createSomeDaysEvent(String description, DateTime startDate, DateTime finishDate, List<String> routes);
        // Devolver los eventos actuales propuestos por el usuario autenticado
        IEnumerable<Event> getActualProposedEvents();
        // Devolver todos los eventos
        IEnumerable<Event> getAllEvents();

        // Crear ruta si no existe, se utiliza en el caso de uso de programar evento
        void createRoute(String Name, String Start, String End, int Ramp, int Distance, Difficulty dif);
        // Devolver todas las rutas
        IEnumerable<Route> getAllRoutes();
        // Buscar y devolver una ruta por su nombre 
        Route findRouteByName(String name);

        //Caso de uso Apuntarse para hacer un evento
        void signUpEvent(string description);
        IEnumerable<Member> getMembersSignUpEvent(string description);
        OneDayEvent findOneDayEventByDescription(String description);
        SomeDaysEvent findSomeDaysEventByDescription(String description);
        Event findEventByDescription(String description);
        // Devolver los eventos actuales del sistema
        IEnumerable<Event> getActualEvents();
        // Devolver los eventos actuales en los que está apuntado el usuario autenticado
        IEnumerable<Event> getActualSingUpEvents();
    }
}
