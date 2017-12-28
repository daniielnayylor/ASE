using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmHomePage : Form
    {
    /// <summary>
<<<<<<< HEAD
    /// Creates the design for the form.
=======
    /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
    /// </summary>
        public frmHomePage()
        {
            InitializeComponent();
        }
        /// <summary>
<<<<<<< HEAD
        /// Opens the help form.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new frmHelp();
            myForm.Show();
        }
        /// <summary>
<<<<<<< HEAD
        /// Closes the current form.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
<<<<<<< HEAD
        /// Opens the white box testers form.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWhite_Click(object sender, EventArgs e)
        {
            var myForm = new frmWhiteTest();
            myForm.Show();
        }
        /// <summary>
<<<<<<< HEAD
        /// Opens the black box testers form.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlack_Click(object sender, EventArgs e)
        {
            var myForm = new frmBlackTester();
            myForm.Show();
        }
        /// <summary>
<<<<<<< HEAD
        /// Opens the developers form.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDev_Click(object sender, EventArgs e)
        {
            var myForm = new frmLogin();
            myForm.Show();
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
<<<<<<< HEAD
        /// Restores the form to its normal size.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }
        /// <summary>
<<<<<<< HEAD
        /// Maximizes the form size.
=======
        /// 
>>>>>>> 0bcdb75... Added a log in system with a new table for developers where they can create an account and log back in. This is so testers don't access developer options like comment and archive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maximizeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
