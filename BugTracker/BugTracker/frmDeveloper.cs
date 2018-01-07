using ColorCode;
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
        frmHomePage frmHomePage;
        public frmDeveloper(frmHomePage frmHomePage)
        {
            this.frmHomePage = frmHomePage;
            openConnection();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            viewBugNames();
        }
        /// <summary>
        /// Opens the connection to the database using the SQL Database connection string when the form is opened
        /// </summary>
        public void openConnection()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");
            String selcmd = "SELECT App FROM BugTable ORDER BY App";
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
        /// Shows the contents of the 'BugTable' table ordered by the application name that has been chosen
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
                    //adds an item to list showing -'s to create formatting for easier reading
                    lbxBugList.Items.Add("---------------------------------------------------");
                    //puts the Code field from the database into the textbox from the app selected
                    txtSourceCodeView.Text = mySqlDataReader["Code"].ToString();
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Shows the contents of the 'ArchiveTable' table from the application name that has been chosen
        /// </summary>
        public void archvieBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Comment, Name, Date FROM ArchiveTable WHERE App = '" + txtBugList.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxArchiveList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxArchiveList.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxArchiveList.Items.Add("Name: " + mySqlDataReader["Name"]);
                    lbxArchiveList.Items.Add("Date Archived: " + mySqlDataReader["Date"]);
                    lbxArchiveList.Items.Add("Archived Comment: ");
                    lbxArchiveList.Items.Add(mySqlDataReader["Comment"]);
                    lbxArchiveList.Items.Add("---------------------------------------------------");

                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Shows the contents of the 'CommentTable' table from the application name that has been chosen
        /// </summary>
        public void commentBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Comment, Name, Date FROM CommentTable WHERE App = '" + txtBugList.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxCommentList.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    lbxCommentList.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxCommentList.Items.Add("Name: " + mySqlDataReader["Name"]);
                    lbxCommentList.Items.Add("Date: " + mySqlDataReader["Date"]);
                    lbxCommentList.Items.Add("Archived Comment: ");
                    lbxCommentList.Items.Add(mySqlDataReader["Comment"]);
                    lbxCommentList.Items.Add("---------------------------------------------------");
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Shows a list of all the bug's application names so the developer can then choose a bug to view in more detail
        /// </summary>
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

                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            frmHomePage.Show();
            this.Close();
        }
        /// <summary>
        /// Assigns a string value to each @string value for the database archive table
        /// </summary>
        /// <param name="app"></param>
        /// <param name="comment"></param>
        /// <param name="commandString"></param>
        public void archiveRecord(String app, String comment, String name, String date, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@app", app);
                cmdInsert.Parameters.AddWithValue("@comment", comment);
                cmdInsert.Parameters.AddWithValue("@name", name);
                cmdInsert.Parameters.AddWithValue("@date", date);
                cmdInsert.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(app + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Assigns a string value to each @string value for the database comment table
        /// </summary>
        /// <param name="app"></param>
        /// <param name="comment"></param>
        /// <param name="commandString"></param>
        public void commentRecord(String app, String comment, String name, String date, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@app", app);
                cmdInsert.Parameters.AddWithValue("@comment", comment);
                cmdInsert.Parameters.AddWithValue("@name", name);
                cmdInsert.Parameters.AddWithValue("@date", date);
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
            txtSourceCodeView.Text = "";
            simpleBugList();
            commentBugList();
            archvieBugList();
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
        /// Adds the app name, comment, name and date into the CommentTable and shows the changes in the Comment listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCommentBug_Click(object sender, EventArgs e)
        {

            String commandString = "INSERT INTO CommentTable (App, Comment, Name, Date) VALUES ( @app, @comment, @name, @date)";
            commentRecord(txtcommentappname.Text, txtcommentbug.Text, txtUsernameComment.Text, txtCommentDate.Text, commandString);
            commentBugList();
            simpleBugList();
        }
        /// <summary>
        /// Adds the app name, comment, date and name into the ArchiveTable and shows the changes in the Archive listView and also removes the bug information and comments from BugTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            
            //removes the row from the table from the specified row ID
            String commandString = "UPDATE BugTable SET Comment = '" + txtcommentarchive.Text +
                "', Name = '" + txtUserNameArchive.Text + "', Date = '" + txtDateArchive.Text +
                "' WHERE App = '" + txtArchive.Text +
                "' INSERT INTO ArchiveTable(BugType, ClassFileName, MethodName, CodeBlock, LineNumber, Error, Cause, Code, App, Name, Date, Comment) SELECT BugType, ClassFileName, MethodName, CodeBlock, LineNumber, Error, Cause, Code, App, Name, Date, Comment FROM BugTable WHERE App = '" + txtArchive.Text
                + "'DELETE FROM BugTable WHERE App = '" + txtArchive.Text + "'";
            archiveRecord(txtArchive.Text, txtcommentarchive.Text, txtUserNameArchive.Text, txtDateArchive.Text, commandString);
            archvieBugList();
            txtArchive.Text = txtcommentarchive.Text = txtUserNameArchive.Text = txtDateArchive.Text = txtSourceCodeView.Text = "";
            simpleBugList();
            commentBugList();
            viewBugNames();
        }

        /// <summary>
        /// Colour codes the source code in the style of c# and shows this in a web broswer
        /// </summary>
        public void ColourCodeCSharp()
        {

            string colourizedSourceCode = new CodeColorizer().Colorize(txtSourceCodeView.Text, Languages.CSharp);

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Coloured Code </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            sourceCodeWebView.DocumentText = html;

        }
        /// <summary>
        /// Colour codes the source code in the style of html and shows this in a web broswer
        /// </summary>
        public void ColourCodeHTML()
        {

            string colourizedSourceCode = new CodeColorizer().Colorize(txtSourceCodeView.Text, Languages.Html);

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Coloured Code </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            sourceCodeWebView.DocumentText = html;
        }
        /// <summary>
        /// Colour codes the source code in the style of Java and shows this in a web broswer
        /// </summary>
        public void ColourCodeJava()
        {

            string colourizedSourceCode = new CodeColorizer().Colorize(txtSourceCodeView.Text, Languages.Java);

            string html = ("<!doctype html><head><meta charset=\"utf-8\" <title> Coloured Code </title> </head> <body>" + colourizedSourceCode + "</body></html>");
            sourceCodeWebView.DocumentText = html;
        }

        /// <summary>
        /// Assigns a string value to each @string value for the database bug table
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="error"></param>
        /// <param name="cause"></param>
        /// <param name="commandString"></param>
        public void insertRecord(String code, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);
                cmdInsert.Parameters.AddWithValue("@code", code);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Updates the source code within the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fixCode_Click(object sender, EventArgs e)
        {
            String commandString = "UPDATE BugTable SET Code = @code WHERE App = '" + txtBugList.Text + "'";
            insertRecord(txtSourceCodeView.Text, commandString);
            MessageBox.Show("Code Fixed!");
        }
        /// <summary>
        /// When an option is chosen from the combo box, if the value ='s one of the chosen strings, it colours the code and outputs it to the web broswer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showColouredCode_Click(object sender, EventArgs e)
        {
            if (cmbLanguage.Text == "C#")
            {
                ColourCodeCSharp();
            }
            else if (cmbLanguage.Text == "HTML")
            {
                ColourCodeHTML();
            }
            else if (cmbLanguage.Text == "Java")
            {
                ColourCodeJava();
            }
            else
            {
                MessageBox.Show("Incorrect Code Type!");
            }
            
        }
    }
}
