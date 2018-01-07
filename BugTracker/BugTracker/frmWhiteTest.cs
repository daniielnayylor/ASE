using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorCode;

namespace BugTracker
{
    /// <summary>
    /// Creates a connection for the database and displays the BugTable contents in the appropriate lists whenn the form is opened.
    /// </summary>
    public partial class frmWhiteTest : Form
    {
        SqlConnection mySqlConnection;
        frmHomePage frmHomePage;
        public frmWhiteTest(frmHomePage frmHomePage)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            populateListBox();
            simpleBugList();
            this.frmHomePage = frmHomePage;
        }
        /// <summary>
        /// Opens up the connection to the SQL database and shows the contents of the 'BugTable' table in order of the app name.
        /// </summary>
        public void populateListBox()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, BugType, ClassFileName, MethodName, CodeBlock, LineNumber FROM BugTable ORDER BY App";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxBugs.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    lbxBugs.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxBugs.Items.Add("Bug Type: " + mySqlDataReader["BugType"]);
                    lbxBugs.Items.Add("Class File Name: " + mySqlDataReader["ClassFileName"]);
                    lbxBugs.Items.Add("Method Name: " + mySqlDataReader["MethodName"]);
                    lbxBugs.Items.Add("Code Block: " + mySqlDataReader["CodeBlock"]);
                    lbxBugs.Items.Add("Line Number: " + mySqlDataReader["LineNumber"]);
                    lbxBugs.Items.Add("--------------------------");


                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Shows the contents of the 'BugTable' table from the application name that has been chosen.
        /// </summary>
        public void selectBugView()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, BugType, ClassFileName, MethodName, CodeBlock, LineNumber, Code FROM BugTable WHERE App = '" + txtsimpleview.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxBugView.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    lbxBugView.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxBugView.Items.Add("Bug Type: " + mySqlDataReader["BugType"]);
                    lbxBugView.Items.Add("Class Fine Name: " + mySqlDataReader["ClassFileName"]);
                    lbxBugView.Items.Add("Method Name: " + mySqlDataReader["MethodName"]);
                    lbxBugView.Items.Add("Code Block: " + mySqlDataReader["CodeBlock"]);
                    lbxBugView.Items.Add("Line Number: " + mySqlDataReader["LineNumber"]);
                    lbxBugView.Items.Add("-----------------------");

                    txtSourceCodeView.Text = mySqlDataReader["Code"].ToString();

                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Show a simplified version of the BugTable that has been entered by a blackbox tester.
        /// </summary>
        public void simpleBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Error, Cause FROM BugTable ORDER BY App";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxSimpleList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxSimpleList.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxSimpleList.Items.Add("Error: " + mySqlDataReader["Error"]);
                    lbxSimpleList.Items.Add("Cause: " + mySqlDataReader["Cause"]);
                    lbxSimpleList.Items.Add("----------------------");
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show a simplified version of the BugTable that has been entered by a blackbox tester from the app name chosen by the user.
        /// </summary>
        public void simpleBugView()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Error, Cause FROM BugTable WHERE App = '" + txtsimpleview.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxSimpleView.Items.Clear();

                while (mySqlDataReader.Read())
                {

                   
                    lbxSimpleView.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxSimpleView.Items.Add("Error: " + mySqlDataReader["Error"]);
                    lbxSimpleView.Items.Add("Cause: " + mySqlDataReader["Cause"]);
                    lbxSimpleView.Items.Add("------------------------");


                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Clears the text boxes when a bug has been edited or reported.
        /// </summary>
        public void cleartxtBoxes()
        {
            txtAppName.Text = txtbugType.Text = txtcbName.Text = txtcfName.Text = txtlineNumb.Text = txtmthdName.Text = txtSourceCode.Text = "";
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(txtAppName.Text) ||
                string.IsNullOrEmpty(txtbugType.Text) ||
                string.IsNullOrEmpty(txtcfName.Text) ||
                string.IsNullOrEmpty(txtmthdName.Text) ||
                string.IsNullOrEmpty(txtcbName.Text) ||
                string.IsNullOrEmpty(txtlineNumb.Text) ||
                string.IsNullOrEmpty(txtSourceCode.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);

        }

        /// <summary>
        /// Assigns a string value to each @string value for the database bug table
        /// </summary>
        /// <param name="appname"></param>
        /// <param name="bugtype"></param>
        /// <param name="classfilename"></param>
        /// <param name="methdName"></param>
        /// <param name="codeblock"></param>
        /// <param name="linenumb"></param>
        /// <param name="commandString"></param>
        public void insertRecord(String appname, String bugtype, String classfilename, String methdName, String codeblock, String linenumb, String code, String commandString)
        {

            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@app", appname);
                cmdInsert.Parameters.AddWithValue("@bugtype", bugtype);
                cmdInsert.Parameters.AddWithValue("@classfilename", classfilename);
                cmdInsert.Parameters.AddWithValue("@methodname", methdName);
                cmdInsert.Parameters.AddWithValue("@codeblock", codeblock);
                cmdInsert.Parameters.AddWithValue("@linenumber", linenumb);
                cmdInsert.Parameters.AddWithValue("@code", code);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(appname + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        /// <summary>
        /// Inserts a record into the BugTable as a white box tester with more details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (checkInputs())
                {
                    String commandString = "INSERT INTO BugTable(App, BugType, ClassFileName, MethodName, CodeBlock, LineNumber, Code) VALUES (@app, @bugtype, @classfilename, @methodname, @codeblock, @linenumber, @code)";
                    insertRecord(txtAppName.Text, txtbugType.Text, txtcfName.Text, txtmthdName.Text, txtcbName.Text, txtlineNumb.Text, txtSourceCode.Text, commandString);
                    populateListBox();  
                    simpleBugList();
                    cleartxtBoxes();
                MessageBox.Show("Bug Successfully Reported");
                }
        }
        /// <summary>
        /// Edits a single row of the BugTable and updates the values with the users new inputs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditBug_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

                String commandString = "UPDATE BugTable SET BugType = '" + txtbugType.Text + "', ClassFileName = '"
                + txtcfName.Text + "', MethodName = '" + txtmthdName.Text + "', CodeBlock = '" + txtcbName.Text +
                "', LineNumber = '" + txtlineNumb.Text + "', Code = '" + txtSourceCode.Text + "' WHERE App = '" + txtAppName.Text + "'";
                SqlCommand cmdEditTable = new SqlCommand(commandString, mySqlConnection);
                cmdEditTable.ExecuteNonQuery();
                MessageBox.Show("Bug Successfully Updated");
                populateListBox();
                cleartxtBoxes();
            }
        }

        /// <summary>
        /// Assigns a string value to each @string value for the database comment table
        /// </summary>
        /// <param name="app"></param>
        /// <param name="comment"></param>
        /// <param name="commandString"></param>
        public void insertComment(String app, String comment, String commandString)
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
        /// Calls the simpleBugView method to show a simple list of bug details of the chosen app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimpleView_Click(object sender, EventArgs e)
        {
            simpleBugView();
            selectBugView();
        }
        /// <summary>
        /// Inserts the App name and Comment into the CommentTable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommentBug_Click(object sender, EventArgs e)
        {
            String commandStringArchive = "INSERT INTO CommentTable (App, Comment) VALUES ( @app, @comment)";
            insertComment(txtcommentappname.Text, txtcommentbug.Text, commandStringArchive);
            txtcommentappname.Text = "";
            txtcommentbug.Text = "";
            MessageBox.Show("Comment Submitted");
        }
        /// <summary>
        /// Opens up the help form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmHelp();
            myForm.Show();
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
        /// Restores the current form to its normal size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        /// <summary>
        /// Minimizes the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Maxinizes the size of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
