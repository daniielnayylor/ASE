﻿using System;
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
    public partial class frmDeveloper : Form
    {
        SqlConnection mySqlConnection;
        public frmDeveloper()
        {
            InitializeComponent();
            populateListBox();
            simpleBugList();
        }
        public void populateListBox()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Visual Studio\Projects\Bug Tracker - Assignment 2\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

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
                    lbxBugs.Items.Add(" Line Number: " + mySqlDataReader["LineNumber"]);
                    lbxBugs.Items.Add("");


                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void selectBugView()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Visual Studio\Projects\Bug Tracker - Assignment 2\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, BugType, ClassFileName, MethodName, CodeBlock, LineNumber FROM BugTable WHERE App = '" + txtchoosebug.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxBugView.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    //lbxBugView.Items.Add("ID: " + mySqlDataReader["BugId"] + " Bug Type: " +
                    //       mySqlDataReader["BugType"] + " Class File Name: " + mySqlDataReader["ClassFileName"]
                    //       + " Method Name: " + mySqlDataReader["MethodName"] + " Code Block: " + mySqlDataReader["CodeBlock"]
                    //       + " Line Number: " + mySqlDataReader["LineNumber"]);

                    lbxBugView.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxBugView.Items.Add("Bug Type: " + mySqlDataReader["BugType"]);
                    lbxBugView.Items.Add("Class Fine Name: " + mySqlDataReader["ClassFileName"]);
                    lbxBugView.Items.Add("Method Name: " + mySqlDataReader["MethodName"]);
                    lbxBugView.Items.Add("Code Block: " + mySqlDataReader["CodeBlock"]);
                    lbxBugView.Items.Add("Line Number: " + mySqlDataReader["LineNumber"]);

                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void simpleBugList()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Visual Studio\Projects\Bug Tracker - Assignment 2\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

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
                    lbxSimpleList.Items.Add("");


                    //lbxSimpleView.Items.Add("ID: " + mySqlDataReader["BugId"]);
                    //lbxSimpleView.Items.Add("App Name: " + mySqlDataReader["App"]);
                    //lbxSimpleView.Items.Add("Error: " + mySqlDataReader["Error"]);
                    //lbxSimpleView.Items.Add("Cause: " + mySqlDataReader["Cause"]);


                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void simpleBugView()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Visual Studio\Projects\Bug Tracker - Assignment 2\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Error, Cause FROM BugTable WHERE App = '" + txtsimpleview.Text + "'";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxSimpleView.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    //lbxBugView.Items.Add("ID: " + mySqlDataReader["BugId"] + " Bug Type: " +
                    //       mySqlDataReader["BugType"] + " Class File Name: " + mySqlDataReader["ClassFileName"]
                    //       + " Method Name: " + mySqlDataReader["MethodName"] + " Code Block: " + mySqlDataReader["CodeBlock"]
                    //       + " Line Number: " + mySqlDataReader["LineNumber"]);

                    //lbxSimpleView.Items.Add("ID: " + mySqlDataReader["BugId"]);
                    lbxSimpleView.Items.Add("App Name: " + mySqlDataReader["App"]);
                    lbxSimpleView.Items.Add("Error: " + mySqlDataReader["Error"]);
                    lbxSimpleView.Items.Add("Cause: " + mySqlDataReader["Cause"]);
                  

                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void cleartxtBoxes()
        {
            txtAppName.Text = txtbugType.Text = txtcbName.Text = txtcfName.Text = txtlineNumb.Text = txtmthdName.Text = "";
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(txtAppName.Text) ||
                string.IsNullOrEmpty(txtbugType.Text) ||
                string.IsNullOrEmpty(txtcfName.Text) ||
                string.IsNullOrEmpty(txtmthdName.Text) ||
                string.IsNullOrEmpty(txtcbName.Text) ||
                string.IsNullOrEmpty(txtlineNumb.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);

        }


        public void insertRecord(String bugtype, String classfilename, String methdName, String codeblock, String linenumb, String commandString)
        {

            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                //cmdInsert.Parameters.AddWithValue("@bugid", bugID);
                cmdInsert.Parameters.AddWithValue("@bugtype", bugtype);
                cmdInsert.Parameters.AddWithValue("@classfilename", classfilename);
                cmdInsert.Parameters.AddWithValue("@methodname", methdName);
                cmdInsert.Parameters.AddWithValue("@codeblock", codeblock);
                cmdInsert.Parameters.AddWithValue("@linenumber", linenumb);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(app + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void insertArchiveRecord(String app, String comment, String commandStringArchive)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandStringArchive, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@app", app);
                cmdInsert.Parameters.AddWithValue("@comment", comment);
                cmdInsert.ExecuteNonQuery();

            } catch (SqlException ex)
            {

            }
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

               // String commandString = "INSERT INTO BugTable(BugType, ClassFileName, MethodName, CodeBlock, LineNumber) VALUES ( @bugtype, @classfilename, @methodname, @codeblock, @linenumber)";
                //insertRecord(txtbugID.Text, txtbugType.Text, txtcfName.Text, txtmthdName.Text, txtcbName.Text, txtlineNumb.Text, commandString);

                String commandString = "UPDATE BugTable SET BugType = '" + txtbugType.Text + "', ClassFileName = '"
                + txtcfName.Text + "', MethodName = '" + txtmthdName.Text + "', CodeBlock = '" + txtcbName.Text +
                "', LineNumber = '" + txtlineNumb.Text + "' WHERE App = '" + txtAppName.Text + "'";
                SqlCommand cmdEditTable = new SqlCommand(commandString, mySqlConnection);
                cmdEditTable.ExecuteNonQuery();

                populateListBox();
                cleartxtBoxes();
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            //removes the row from the table from the specified row ID
            String commandString = "DELETE FROM BugTable WHERE App = '" + txtArchive.Text + "'";

            String commandStringArchive = "INSERT INTO ArchiveTable (App, Comment) VALUES ( @app, @comment)";
            insertArchiveRecord(txtArchive.Text, txtComments.Text, commandStringArchive);
            SqlCommand cmdAddToArchive = new SqlCommand(commandStringArchive, mySqlConnection);
            cmdAddToArchive.ExecuteNonQuery();

            SqlCommand cmdClearTable = new SqlCommand(commandString, mySqlConnection);
            cmdClearTable.ExecuteNonQuery();

            populateListBox();
            simpleBugView();
            simpleBugList();
            selectBugView();
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //edits the data within the columns for the row of the given ID
            String commandString = "UPDATE BugTable SET BugType = '" + txtbugType.Text + "', ClassFileName = '"
                + txtcfName.Text + "', MethodName = '" + txtmthdName.Text + "', CodeBlock = '" + txtcbName.Text +
                "', LineNumber = '" + txtlineNumb.Text + "' WHERE App = '" + txtAppName.Text + "'";
            SqlCommand cmdEditTable = new SqlCommand(commandString, mySqlConnection);
            cmdEditTable.ExecuteNonQuery();
            //different sql statement for doing the edit command
            //String commandString = "UPDATE BugTable SET BugType = @bugtype, ClassFileName = @classfilename. MethodName = @methodname, CodeBlock = @codeblock, LineNumber = @linenumber Where BugId = @bugid";
            //cmdEditTable.Parameters.AddWithValue("@bigtype", txtbugType.Text);

            
            populateListBox();


        }

        private void btnViewBug_Click(object sender, EventArgs e)
        {
            selectBugView();
        }

        private void btnSimpleView_Click(object sender, EventArgs e)
        {
            simpleBugView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
