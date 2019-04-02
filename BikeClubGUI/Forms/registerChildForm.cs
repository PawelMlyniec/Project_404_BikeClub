using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeClubLib.BusinessLogic.Services;
using BikeClubLib.Entities;
using BikeClubLib.Services;

namespace BikeClubGUI.Forms
{
    public partial class registerChildForm : Form
    {
        private IBikeClubService service;
        private AddChildForm addchild;
        public registerChildForm(IBikeClubService service)
        {

            InitializeComponent();
            this.service = service;
            LoadData();
            addchild = new AddChildForm(service);
        }

        private void registerChild_Load(object sender, EventArgs e)
        {
            //
 

        }
        public void LoadData()
        {
            Member member = service.getLoggedMember();
            BindingList<object> bindingList = new BindingList<object>();
            IEnumerable<Member> memberChildern = service.getChildren();
            bindingList.Add(new
            {
                Name = member.Name,
                Login = member.Login,
                IBAN = member.IBAN,
                children = "Member"
            });
            foreach (Member ch in memberChildern)
            {

                bindingList.Add(new
                {
                    Name = ch.Name,
                    Login = ch.Login,
                    IBAN = ch.IBAN,
                    children = "Child"
                });
            }

            membersBindingSource.DataSource = bindingList;
        }

        private void addChildButtom(object sender, EventArgs e)
        {
            addchild.ShowDialog(this);
        }
    }
}
