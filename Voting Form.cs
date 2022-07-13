using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Voting_System
{
    public partial class Voting_Form : Form
    {
        public Voting_Form()
        {
            InitializeComponent();
        }
        public string id;
        string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=OnlineVotingSystem;Data Source=DESKTOP-6SEK5AN";

        SqlConnection con = null;
        SqlCommand cmd;
        private void Voting_Form_Load(object sender, EventArgs e)
        {
            txtvid.Text = Voter_Login.vid.ToString();
           



        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
           
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                if(cmb1.SelectedIndex==0)
                {
                    id = "MN-101";
                   
                }
                if (cmb1.SelectedIndex == 1)
                {
                    id = "MN-290";
                }
                if (cmb1.SelectedIndex == 2)
                {
                    id = "GJ-780";
                }
                if (cmb1.SelectedIndex == 3)
                {
                    id = "AD-456";
                }
                //string query = "insert into votecasting values('" + txtvid.Text + "','"+id+"','" + txtcname.Text + "','" + txtdistrict.Text + "')";
                //cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                //con.Close();
                //MessageBox.Show("Record inserted successfully");
                //txtvid.Text = "";
                //txtdistrict.Text = "";
                //txtcname.Text = "";
                //cmb1.Text = "";
                SqlConnection sqlCon = new SqlConnection(constr);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("insert_votecasting", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@vid", SqlDbType.VarChar).Value = txtvid.Text;
                cmd.Parameters.Add("@District", SqlDbType.VarChar).Value = txtdistrict.Text;
                cmd.Parameters.Add("@candidateName", SqlDbType.VarChar).Value = txtcname.Text;
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Command Executed");
                sqlCon.Close();
                MessageBox.Show("Record inserted successfully");
            }
            catch(Exception ex)
            {

                MessageBox.Show("Your Vote Already Counted .\nYou are Not Allowed to Cast Vote Again!Thanks");

            }

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex == 0)
            {
                txtcname.Text = "Raja Parvez Ashraf";
                txtdistrict.Text = "NA-58";
            }

            if (cmb1.SelectedIndex == 1)
            {
                txtcname.Text = "Shahid Khaqan Abasi";
                txtdistrict.Text = "NA-53";
            }

            if (cmb1.SelectedIndex == 2)
            {
                txtcname.Text = "Gulzar Khan";
                txtdistrict.Text = "NA-4";
            }

            if (cmb1.SelectedIndex == 3)
            {
                txtcname.Text = "Khurram Shehzad";
                txtdistrict.Text = "NA-107";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup c = new Signup();
            c.Show();
            this.Hide();
        }
    }
}
