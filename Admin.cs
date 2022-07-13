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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        public static string fn = "";
        public static string ln = "";
        public static string cnic = "";
       // public static string email = "";
        public static string city = "";
        public static string phno = "";
        public static int vid;
        public static string pwd;
        string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=OnlineVotingSystem;Data Source=DESKTOP-6SEK5AN";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(constr);
                using (SqlCommand cmd = new SqlCommand("Read_Admin", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlCon.Open();

                    SqlParameter custId = cmd.Parameters.Add("@vid", SqlDbType.VarChar);
                    custId.Direction = ParameterDirection.Input;
                    custId.Value = txtname.Text;

                    //---------------------------

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
                        AdminDetails u = new AdminDetails();
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
