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

namespace BikeClubGUI.Forms
{
    public partial class FormBase : Form
    {
        protected IBikeClubService service;
        public FormBase()
        {
            InitializeComponent();
        }
        public FormBase(IBikeClubService service) : this()
        {
            this.service = service;
        }
    }
}
