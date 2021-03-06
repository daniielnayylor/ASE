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
    /// <summary>
    /// Opens up a connection to the database and tables when the form is opened so the database can be read or written to.
    /// </summary>
    public partial class frmBlackTester : Form
    {
        frmHomePage frmHomePage;
        public static bool rtnvalue;
        SqlConnection mySqlConnection;
        public frmBlackTester(frmHomePage frmHomePage)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            openConnection();
            this.frmHomePage = frmHomePage;
        }
        /// <summary>
        /// Opens the connection to the database using the SQL Database connection string when the form is opened.
        /// </summary>
        public void openConnection()
        {
            //the connection string searches for the database .mdf file
            mySqlConnection =
                 //"MultipleActiveResultsSets=true" allows for multiple SQLDataReaders to be open so they don't need to be opened and closed all the time, useful but I guess memory inefficient
                 new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Source\Repos\ASE\BugTracker\BugTracker\Bugs.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=true");

            String selcmd = "SELECT App, Error, Cause FROM BugTable ORDER BY App";

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
        /// Clears the text boxes when a bug is submitted.
        /// </summary>
        public void cleartxtBoxes()
        {
            txtAppName.Text = txtCause.Text = txtError.Text = "";
        }
        /// <summary>
        /// Checks the text boxes to make sure they aren't empty or full of white space before submitting a bug.
        /// </summary>
        /// <returns></returns>
        public bool checkInputs()
        {
            rtnvalue = true;
            if (string.IsNullOrEmpty(txtAppName.Text) ||
                string.IsNullOrEmpty(txtCause.Text) ||
                string.IsNullOrEmpty(txtError.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }
            return (rtnvalue);
        }
        /// <summary>
        /// Assigns a string value to each @string value for the database bug table
        /// </summary>
        /// <param name="appName"></param>
        /// <param name="error"></param>
        /// <param name="cause"></param>
        /// <param name="commandString"></param>
        public void insertRecord(String appName, String error, String cause, String commandString)
        {
            try
            {
                SqlCommand cmdInsert = new SqlCommand(commandString, mySqlConnection);
                cmdInsert.Parameters.AddWithValue("@app", appName);
                cmdInsert.Parameters.AddWithValue("@error", error);
                cmdInsert.Parameters.AddWithValue("@cause", cause);
                cmdInsert.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(appName + " .." + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Inserts App Name, Error and Cause into the BugTable table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reportBug_Click(object sender, EventArgs e)
        {
            if (checkInputs())
            {
                String commandString = "INSERT INTO BugTable(App, Error, Cause) VALUES (@app, @error, @cause)";
                insertRecord(txtAppName.Text, txtError.Text, txtCause.Text, commandString);
                cleartxtBoxes();
                MessageBox.Show("Bug Successfully Reported");
                this.Close();
                frmHomePage.Show();
            }
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
        /// Restores the form to its original size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }
        /// <summary>
        /// Minimizes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Maximizes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
