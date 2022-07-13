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
    public partial class Ballot_paper_Form : Form
    {
        public Ballot_paper_Form()
        {
            InitializeComponent();
        }
        // public static int vid;
       


        private void btnDetails_Click(object sender, EventArgs e)
        {
           
            if (cmbdistrict.SelectedIndex==0 && cmbcandidate.SelectedIndex==0)
            {
                
                    Candidate_For_NA_58_RP_II_ c1 = new Candidate_For_NA_58_RP_II_();
                    c1.Show();
                    this.Hide();
               

            }

            if (cmbdistrict.SelectedIndex == 1 && cmbcandidate.SelectedIndex == 1)
            {
               
                    Candidate_For_NA_53_ISB_II_ c1 = new Candidate_For_NA_53_ISB_II_();
                    c1.Show();
                    this.Hide();
                

            }

            if (cmbdistrict.SelectedIndex == 2 && cmbcandidate.SelectedIndex == 2)
            {
               
                    Candidate_For_NA_4_P_IV_ c1 = new Candidate_For_NA_4_P_IV_();
                    c1.Show();
                    this.Hide();
                

            }

            if (cmbdistrict.SelectedIndex == 3 && cmbcandidate.SelectedIndex == 3)
            {
               
                    Candidate_For_NA_107_F_VII_ c1 = new Candidate_For_NA_107_F_VII_();
                    c1.Show();
                    this.Hide();
                

            }
          


            if (cmbcandidate.SelectedItem==null)
            {
                MessageBox.Show("Please Select Candidate ");
            }
            if (cmbdistrict.SelectedItem==null)
            {
                MessageBox.Show("Please Select District ");
            }
            
            

        }

        private void Ballot_paper_Form_Load(object sender, EventArgs e)
        {
          
            cmbcandidate.Text = "--Select--";
            cmbdistrict.Text = "--Select--";
        }


       
    } 
}
