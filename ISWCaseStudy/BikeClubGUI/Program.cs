using BikeClubLib.Persistence;
using BikeClubLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeClubGUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IBikeClubService service = new BikeClubService(new EntityFrameworkDAL(new BikeClubDbContext()));
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BikeClubApp(service));
        }
    }
}
