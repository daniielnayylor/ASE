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
    public partial class Form1 : Form
    {
        SqlConnection mySqlConnection;
        public Form1()
        {
            InitializeComponent();
            populateListBox();
        }
        public void populateListBox()
        {
            mySqlConnection =
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Visual Studio\Projects\Bug Tracker - Assignment 2\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT BugId, BugType, ClassFileName, MethodName, CodeBlock, LineNumber FROM BugTable ORDER BY BugId";

            SqlCommand mySqlCommand = new SqlCommand(selcmd, mySqlConnection);

            try
            {
                mySqlConnection.Open();

                SqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                lbxBugs.Items.Clear();

                while (mySqlDataReader.Read())
                {

                    lbxBugs.Items.Add(mySqlDataReader["BugId"] + " " +
                           mySqlDataReader["BugType"] + " " + mySqlDataReader["ClassFileName"]
                           + " " + mySqlDataReader["MethodName"] + " " + mySqlDataReader["CodeBlock"]
                           + " " + mySqlDataReader["LineNumber"]);


                }
            }

            catch (SqlException ex)
            {

                // MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        public void cleartxtBoxes()
        {
            txtbugID.Text = txtbugType.Text = txtcbName.Text = txtcfName.Text = txtlineNumb.Text = txtmthdName.Text = "";
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(txtbugID.Text) ||
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


        public void insertRecord(String bugID, String bugtype, String classfilename, String methdName, String codeblock, String linenumb, String commandString)
        {

            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);

                cmdInsert.Parameters.AddWithValue("@bugid", bugID);
                cmdInsert.Parameters.AddWithValue("@bugtype", bugtype);
                cmdInsert.Parameters.AddWithValue("@classfilename", classfilename);
                cmdInsert.Parameters.AddWithValue("@methodname", methdName);
                cmdInsert.Parameters.AddWithValue("@codeblock", codeblock);
                cmdInsert.Parameters.AddWithValue("@linenumber", linenumb);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(bugID + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {

                String commandString = "INSERT INTO BugTable(BugId, BugType, ClassFileName, MethodName, CodeBlock, LineNumber) VALUES (@bugid, @bugtype, @classfilename, @methodname, @codeblock, @linenumber)";

                insertRecord(txtbugID.Text, txtbugType.Text, txtcfName.Text, txtmthdName.Text, txtcbName.Text, txtlineNumb.Text, commandString);
                populateListBox();
                cleartxtBoxes();
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(removeID.Text);
            String commandString = "DELETE FROM BugTable WHERE BugId = " + id;
            SqlCommand cmdClearTable = new SqlCommand(commandString, mySqlConnection);
            cmdClearTable.ExecuteNonQuery();
            //lbxBugs.Items.RemoveAt(bugID);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String commandString = "UPDATE BugTable SET BugType = '" + txtbugType.Text + "', ClassFileName = '"
                + txtcfName.Text + "', MethodName = '" + txtmthdName.Text + "', CodeBlock = '" + txtcbName.Text +
                "', LineNumber = '" + txtlineNumb.Text + "' WHERE BugId = '" + txtbugID.Text + "'";
            SqlCommand cmdEditTable = new SqlCommand(commandString, mySqlConnection);

            //String commandString = "UPDATE BugTable SET BugType = @bugtype, ClassFileName = @classfilename. MethodName = @methodname, CodeBlock = @codeblock, LineNumber = @linenumber Where BugId = @bugid";
            //cmdEditTable.Parameters.AddWithValue("@bigtype", txtbugType.Text);

            cmdEditTable.ExecuteNonQuery();

        }
    }
}
