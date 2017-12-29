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
    public partial class frmDeveloper : Form
    {
        SqlConnection mySqlConnection;
        public frmDeveloper()
        {
            openConnection();
            InitializeComponent();
            viewBugNames();

        }
        /// <summary>
        /// Opens the connection to the database using the SQL Database connection string when the form is opened
        /// </summary>
        public void openConnection()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, BugType, ClassFileName, MethodName, CodeBlock, LineNumber FROM BugTable ORDER BY App";

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
        /// Shows the contents of the 'BugTable' table from the application name that has been chosen
        /// </summary>
        public void simpleBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Error, Cause, BugType, ClassFileName, MethodName, CodeBlock, LineNumber, Code FROM BugTable WHERE App = '" + txtBugList.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxBugList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxBugList.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxBugList.Items.Add("Simple Bug Report for " + mySqlDataReader["App"] + ": ");
                    lbxBugList.Items.Add("Error: " + mySqlDataReader["Error"]);
                    lbxBugList.Items.Add("Cause: " + mySqlDataReader["Cause"]);
                    lbxBugList.Items.Add("Advanced Bug Report for " + mySqlDataReader["App"] + ": ");
                    lbxBugList.Items.Add("Bug Type: " + mySqlDataReader["BugType"]);
                    lbxBugList.Items.Add("Class File Name: " + mySqlDataReader["ClassFileName"]);
                    lbxBugList.Items.Add("Method Name: " + mySqlDataReader["MethodName"]);
                    lbxBugList.Items.Add("Code Block: " + mySqlDataReader["CodeBlock"]);
                    lbxBugList.Items.Add("Line Number: " + mySqlDataReader["LineNumber"]);
                    lbxBugList.Items.Add("---------------------------------------------------");

                    txtSourceCodeView.Text = mySqlDataReader["Code"].ToString();





                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Shows the contents of the 'ArchiveTable' table from the application name that has been chosen
        /// </summary>
        public void archvieBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Comment FROM ArchiveTable WHERE App = '" + txtArchiveList.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxArchiveList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxArchiveList.Items.Add("Archived App Name: " + mySqlDataReader["App"]);
                    lbxArchiveList.Items.Add("Archived Comment: ");
                    lbxArchiveList.Items.Add(mySqlDataReader["Comment"]);
                    lbxArchiveList.Items.Add("---------------------------------------------------");





                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Shows the contents of the 'CommentTable' table from the application name that has been chosen
        /// </summary>
        public void commentBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Comment FROM CommentTable WHERE App = '" + txtCommentList.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxCommentList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxCommentList.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxCommentList.Items.Add("Archived Comment: ");
                    lbxCommentList.Items.Add(mySqlDataReader["Comment"]);
                    lbxCommentList.Items.Add("---------------------------------------------------");
                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void viewBugNames()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App FROM BugTable ORDER BY App";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxBugView.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxBugView.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxBugView.Items.Add("---------------------------------------------------");
                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Opens the help form from the help menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmHelp();
            myForm.Show();
        }
        /// <summary>
        /// Closes the current form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Creates the references for app and comment for the archive table
        /// </summary>
        /// <param name="app"></param>
        /// <param name="comment"></param>
        /// <param name="commandString"></param>
        public void archiveRecord(String app, String comment, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@app", app);
                cmdInsert.Parameters.AddWithValue("@comment", comment);
                cmdInsert.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(app + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Creates the references for app and comment for the comment table
        /// </summary>
        /// <param name="app"></param>
        /// <param name="comment"></param>
        /// <param name="commandString"></param>
        public void commentRecord(String app, String comment, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@app", app);
                cmdInsert.Parameters.AddWithValue("@comment", comment);
                cmdInsert.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(app + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Displays the BugTable contents in the Bug listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBugList_Click(object sender, EventArgs e)
        {
            simpleBugList();
        }
        /// <summary>
        /// Displays the ArchiveTable contents in the Archive listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnArchiveList_Click(object sender, EventArgs e)
        {
            archvieBugList();
        }
        /// <summary>
        /// Displays the CommentTable contents in the Comment listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommentList_Click(object sender, EventArgs e)
        {
            commentBugList();
        }
        /// <summary>
        /// Restores the size of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        /// <summary>
        /// Minimizes the size of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Maximizes the size of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Adds the app name and comment into the CommentTable and shows the changes in the Comment listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommentBug_Click(object sender, EventArgs e)
        {

            String commandStringArchive = "INSERT INTO CommentTable (App, Comment) VALUES ( @app, @comment)";
            commentRecord(txtcommentappname.Text, txtcommentbug.Text, commandStringArchive);
            commentBugList();
            simpleBugList();


        }
        /// <summary>
        /// Adds the app name and comment into the ArchiveTable and shows the changes in the Archive listView and also removes the bug information and comments from BugTable and CommentTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            //removes the row from the table from the specified row ID
            String commandString = "DELETE FROM BugTable WHERE App = '" + txtArchive.Text + "'" + "INSERT INTO ArchiveTable (App, Comment) VALUES ( @app, @comment) DELETE FROM CommentTable WHERE App = '" + txtArchive.Text + "'";
            archiveRecord(txtArchive.Text, txtcommentarchive.Text, commandString);
            archvieBugList();
            simpleBugList();
            commentBugList();

        }
        /// <summary>
        /// Updates the source code within the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fixCode_Click(object sender, EventArgs e)
        {
            String commandString = "UPDATE BugTable SET Code = '" + txtSourceCodeView.Text + "' WHERE App = '" + txtBugList.Text + "'"; 
            SqlCommand cmdfixCode = new SqlCommand(commandString, mySqlConnection);
            cmdfixCode.ExecuteNonQuery();
            MessageBox.Show("Code Fixed!");
        }
    }
}
