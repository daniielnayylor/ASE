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
    /// Opens up a connection to the database and tables when the form is opened so the database can be read or written to.
    /// </summary>
    public partial class frmLogin : Form
    {
        SqlConnection mySqlConnection;
        frmHomePage frmHomePage;
        public frmLogin(frmHomePage frmHomePage)
        {
            openConnection();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.frmHomePage = frmHomePage;
        }
        /// <summary>
        /// Opens the connection to the database using the SQL Database connection string when the form is opened.
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
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Selects the values from the LogInTable and compares the results against what the user has written in the username and password text boxes to make sure the credentials match with the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM LogInTable WHERE Username=@uname and Password=@pass", mySqlConnection);
                cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                int result = (int)cmd.ExecuteScalar();
                if (result > 0)
                {
                    MessageBox.Show("Login Success");
                    var myForm = new frmDeveloper(frmHomePage);
                    myForm.Show();
                    this.Close();
                }
                else
                MessageBox.Show("Incorrect login");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error:" + ex.Message);
            }
        }
        /// <summary>
        /// Opens up the register from.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var myForm = new frmRegister(frmHomePage);
            myForm.Show();
            this.Close();
        }

        /// <summary>
        /// Minimized the size of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Restores the form to its normal size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }
        /// <summary>
        /// Maximizes the form size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Closes the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHomePage.Show();
            this.Close();
        }

        /// <summary>
        /// Opens the help form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmHelp();
            myForm.Show();
        }
    }
}
