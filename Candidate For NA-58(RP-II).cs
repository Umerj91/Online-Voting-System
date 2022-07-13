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
    public partial class Candidate_For_NA_58_RP_II_ : Form
    {
        public Candidate_For_NA_58_RP_II_()
        {
            InitializeComponent();
        }

        private void Candidate_For_NA_58_RP_II__Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ballot_paper_Form f1 = new Ballot_paper_Form();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Voting_Form vt = new Voting_Form();
            vt.Show();
            this.Hide();
        }
    }
}
