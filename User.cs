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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

      

        private void btngovote_Click(object sender, EventArgs e)
        {
            Ballot_paper_Form b1 = new Ballot_paper_Form();
            b1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            lblname.Text = Voter_Login.fn+"  "+Voter_Login.ln;
            lblid.Text = Voter_Login.vid.ToString();
            lblcnic2.Text = Voter_Login.cnic;
            lblemail2.Text = Voter_Login.email;
            lbladd2.Text = Voter_Login.city;
            lblph2.Text = Voter_Login.phno;

        }
    }
}
