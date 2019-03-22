using BikeClubLib.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeClubGUI.Forms;

namespace BikeClubGUI.Forms
{
    public partial class ProgramEventForm : FormBase
    {
        public ProgramEventForm(IBikeClubService service) : base(service)
        {
            InitializeComponent();
        }

        private void ProgramEventForm_Load(object sender, EventArgs e)
        {

        }
    }
}
