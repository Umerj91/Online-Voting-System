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
    public partial class Voter_Login : Form
    {
        public Voter_Login()
        {
            InitializeComponent();
        }
        string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=OnlineVotingSystem;Data Source=DESKTOP-6SEK5AN";


        public static string fn = "";
        public static string ln = "";
        public static string cnic = "";
        public static string email = "";
        public static string city = "";
        public static string phno = "";
        public static int vid;
        public static string pwd;



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(constr);
            // string q = "select * from User1 where vid = '" + txtname.Text + "' and pass = '" + txtpassword.Text + "'";
            //con.Open();
            // SqlCommand cmd = new SqlCommand(q, con);
            // SqlDataReader sdr = cmd.ExecuteReader();
            // while(sdr.Read())
            // {

            //     fn = sdr["fname"].ToString();
            //     ln = sdr["lname"].ToString();
            //     cnic = sdr["cnic"].ToString();
            //     city = sdr["city"].ToString();
            //     phno = sdr["phone"].ToString();
            //     vid = int.Parse(sdr["vid"].ToString());
            //     pwd = sdr["pass"].ToString();
            // }
            try
            {
                SqlConnection sqlCon = new SqlConnection(constr);
                using (SqlCommand cmd = new SqlCommand("Read_User", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlCon.Open();

                    SqlParameter custId = cmd.Parameters.Add("@vid", SqlDbType.VarChar);
                    custId.Direction = ParameterDirection.Input;
                    custId.Value = txtname.Text;

                    

                    SqlParameter custpw = cmd.Parameters.Add("@pass", SqlDbType.VarChar);
                    custpw.Direction = ParameterDirection.Input;
                    custpw.Value = txtpassword.Text;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                   
                    if (dr.Read())
                    {

                        fn = dr["fname"].ToString();
                        ln = dr["lname"].ToString();
                        cnic = dr["cnic"].ToString();
                        city = dr["city"].ToString();
                        phno = dr["phone"].ToString();
                        vid = int.Parse(dr["vid"].ToString());
                        pwd = dr["pass"].ToString();
                        User u = new User();
                        u.Show();
                        this.Hide();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Invalid User");
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
        }
    }

