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
using System.Text.RegularExpressions;
namespace Online_Voting_System
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        Regex regPassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
        string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=OnlineVotingSystem;Data Source=DESKTOP-6SEK5AN";
        SqlConnection con = null;
        SqlCommand cmd;
        string gender = "";

        private void btnsignup_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                if (txtfn.Text == "")
                {
                    MessageBox.Show("Enter First Name");
                    txtfn.Focus();

                }

               else if (txtln.Text == "")
                {
                    MessageBox.Show("Enter Last Name");
                    txtln.Focus();

                }

             else   if (mtbcnic.Text == "")
                {
                    MessageBox.Show("Enter CNIC");
                    mtbcnic.Focus();

                }

             else   if (rdbmale.Checked == false && rdbfemale.Checked == false)
                {
                    MessageBox.Show("Choose Gender");

                }

            else    if (txtage.Text == "")
                {
                    MessageBox.Show("Enter Age");
                    txtage.Focus();

                }

          else      if (cmbcity.Text == "")
                {
                    MessageBox.Show("Enter City");
                    cmbcity.Focus();

                }

                else if (mtbphno.Mask == "")
                {
                    MessageBox.Show("Enter Phone No");
                    mtbphno.Focus();

                }

              else  if (txtvid.Text == "")
                {
                    MessageBox.Show("Enter Voter ID");
                    txtvid.Focus();

                }

             else   if (txtpwd.Text == "")
                {
                    MessageBox.Show("Enter Password");
                    txtpwd.Focus();

                }



             else   if (rdbmale.Checked == true)
                {
                    gender = "Male";

                }
            else    if (rdbfemale.Checked == true)
                {
                    gender = "Female";
                }

                //else if (regPassword.IsMatch(txtpwd.Text) == true)
                //{

                    //string query = "insert into User1 values('" + txtfn.Text + "','" + txtln.Text + "','" + mtbcnic.Text + "','" + cmbcity.Text + "','" + mtbphno.Text.ToString() + "','" + txtvid.Text.ToString() + "','" + txtpwd.Text.ToString() + "','" + gender + "','" + txtage.Text + "')";

                    //cmd = new SqlCommand(query, con);
                    //cmd.ExecuteNonQuery();
                    SqlConnection sqlCon = new SqlConnection(constr);
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("insert_user", sqlCon);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = txtfn.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = txtln.Text;
                        cmd.Parameters.Add("@cnic", SqlDbType.VarChar).Value = mtbcnic.Text;
                        cmd.Parameters.Add("@city", SqlDbType.VarChar).Value = cmbcity.Text;
                        cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = mtbphno.Text;
                        cmd.Parameters.Add("@vid", SqlDbType.VarChar).Value = txtvid.Text;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtpwd.Text;
                        cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = gender;
                        cmd.Parameters.Add("@age", SqlDbType.Int).Value = txtage.Text.ToString();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Command Executed");
                        sqlCon.Close();
                        MessageBox.Show("Record inserted successfully");
                        Form1 vl = new Form1();
                        vl.Show();
                        this.Hide();

                //}
                //else
                //{
                //    MessageBox.Show("Password Must Have at least one uppercase ,one lowercase and length should be minimum 8");
                //}

                //con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

        }

        private void btnadminsignup_Click(object sender, EventArgs e)
        {
            Form1 vl = new Form1();
            vl.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
    }
