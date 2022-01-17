using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CovidSurveyCheck
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=MyDB Catalog=UploadForm;User ID=FormUser;Password=XXXXXXXX");
        readonly string userName = Environment.UserName;
        public Form1()
        {
            InitializeComponent();
            //  MessageBox.Show("Welcome" + userName);
            label13.Text = "Currently Logged in User: " + userName;
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
           // string msg = "";
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            if (checkBox1.Checked == true)

            {
                //do sql insert here
                SqlCommand sqlcmd = new SqlCommand("dbo.LoadSurvey", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@Username", Environment.UserName);
                if (CB1.Checked == true)
                { sqlcmd.Parameters.AddWithValue("@Q1", "Yes"); }
                else
                { sqlcmd.Parameters.AddWithValue("@Q1", "No"); }
                if (CB3.Checked == true)
                { sqlcmd.Parameters.AddWithValue("@Q2", "Yes"); }
                else
                { sqlcmd.Parameters.AddWithValue("@Q2", "No"); }
                if (CB5.Checked == true)
                { sqlcmd.Parameters.AddWithValue("@Q3", "Yes"); }
                else
                { sqlcmd.Parameters.AddWithValue("@Q3", "No"); }
                if (CB7.Checked == true)
                { sqlcmd.Parameters.AddWithValue("@Q4", "Yes"); }
                else
                { sqlcmd.Parameters.AddWithValue("@Q4", "No"); }
                if (CB9.Checked == true)
                { sqlcmd.Parameters.AddWithValue("@Q5", "Yes"); }
                else
                { sqlcmd.Parameters.AddWithValue("@Q5", "No"); }
                if (CB9.Checked == true)
                { sqlcmd.Parameters.AddWithValue("@Q6", "Yes"); }
                else
                { sqlcmd.Parameters.AddWithValue("@Q6", "No"); }
                if ((CB1.Checked == false && CB2.Checked == false)
                    ||
                    (CB3.Checked == false && CB4.Checked == false)
                    ||
                    (CB5.Checked == false && CB6.Checked == false)
                    ||
                    (CB7.Checked == false && CB8.Checked == false)
                    ||
                    (CB9.Checked == false && CB10.Checked == false)
                    ||
                    (CB11.Checked == false && CB12.Checked == false))
                { MessageBox.Show("Please select an option on each question"); }
                
            else
            { sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Thanks. Your responses have now been saved. You can now close the application");
                    sqlcon.Close();
                }
                                     
                }
                        else
            {
                MessageBox.Show("Please check box to demonstrate you have read all information");
                sqlcon.Close();
            }
                checkBox1.ThreeState = true;
            
                                }
        }
    }

