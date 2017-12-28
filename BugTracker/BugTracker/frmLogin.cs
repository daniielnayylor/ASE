using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    /// <summary>
<<<<<<< HEAD
    /// Opens up a connection to the database and tables when the form is opened so the database can be read or written to.
=======
    /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
    /// </summary>
    public partial class frmLogin : Form
    {
        SqlConnection mySqlConnection;
        public frmLogin()
        {
            openConnection();
            InitializeComponent();
        }
        /// <summary>
<<<<<<< HEAD
        /// Opens the connection to the database using the SQL Database connection string when the form is opened.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        public void openConnection()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT Username, Password FROM LogInTable ORDER BY Username";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
<<<<<<< HEAD
        /// Selects the values from the LogInTable and compares the results against what the user has written in the username and password text boxes to make sure the credentials match with the database.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM LogInTable WHERE Username=@uname and Password=@pass", mySqlConnection);
=======
                SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM LogInTable 
                                        WHERE Username=@uname and 
                                        Password=@pass", mySqlConnection);
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
                cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login Success");
                    var myForm = new frmDeveloper();
                    myForm.Show();
                    this.Close();
                }
                else
<<<<<<< HEAD
                MessageBox.Show("Incorrect login");                
=======
                    MessageBox.Show("Incorrect login");
                
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }
        }
        /// <summary>
<<<<<<< HEAD
        /// Opens up the register from.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var myForm = new frmRegister();
            myForm.Show();
            this.Close();
        }
    }
}
