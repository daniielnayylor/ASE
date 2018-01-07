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
    public partial class frmRegister : Form
    {
        SqlConnection mySqlConnection;
        frmHomePage frmHomePage;
        public frmRegister(frmHomePage frmHomePage)
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
        /// Creates the references for Username and Password for the LogInTable table.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="commandString"></param>
        public void registerAccount(String username, String password, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@username", username);
                cmdInsert.Parameters.AddWithValue("@password", password);
                cmdInsert.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(username + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Inserts the values of Username and Password into the LogInTable table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a username and/or password please!");
            }
            else
            {
                String commandString = "INSERT INTO LogInTable (Username, Password) VALUES ( @username, @password)";
                registerAccount(txtUsername.Text, txtPassword.Text, commandString);
                var myForm = new frmLogin(frmHomePage);
                myForm.Show();
                this.Close();

            }
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


