using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Voting_System
{
    public partial class AdminDetails : Form
    {
        public AdminDetails()
        {
            InitializeComponent();
        }

        private void AdminDetails_Load(object sender, EventArgs e)
        {
            lblname.Text = Admin.fn + "  " + Admin.ln;
            lblid.Text = Admin.vid.ToString();
            lblcnic2.Text = Admin.cnic;
           // lblemail2.Text = Admin.email;
            lbladd2.Text = Admin.city;
            lblph2.Text = Admin.phno;
        }

        private void btngovote_Click(object sender, EventArgs e)
        {
            Statistics_Bar bs = new Statistics_Bar();
            bs.Show();
            this.Hide();  
    }
    }
}
