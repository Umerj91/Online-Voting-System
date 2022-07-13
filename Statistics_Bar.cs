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
    public partial class Statistics_Bar : Form
    {
        public Statistics_Bar()
        {
            InitializeComponent();
        }
        public string id;
        string constr = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=OnlineVotingSystem;Data Source=DESKTOP-6SEK5AN";


        private void btncheck_Click(object sender, EventArgs e)
        {


            //    dataGridView1.Rows.Add(sdr[0].ToString(), sdr[1].ToString(),sdr[2].ToString(),sdr[3].ToString());
            try
            {

               // dataGridView1.Rows.Clear();
                SqlConnection sqlCon = new SqlConnection(constr);
                using (SqlCommand cmd = new SqlCommand("Read_Candidate", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    sqlCon.Open();

                    SqlParameter canId = cmd.Parameters.Add("@cid", SqlDbType.VarChar);
                    canId.Direction = ParameterDirection.Input;
                    canId.Value = id;
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex == 0)
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
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(constr);
            using (SqlCommand cmd = new SqlCommand("count_Candidate", sqlCon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();

                SqlParameter canId = cmd.Parameters.Add("@cid", SqlDbType.VarChar);
                canId.Direction = ParameterDirection.Input;
                canId.Value = id;
              ///  SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               
                //if (dr.Read())
                //{
                    
                    Int32 count = (Int32)cmd.ExecuteScalar();
                    MessageBox.Show("This Candidate has" +  count+ "Votes");
                //}
                //SqlDataReader sdr = cmd.ExecuteReader();

            }
        }
    }
}
