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
    /// Creates the design for the form.
    /// </summary>
        public frmHomePage()
        {
            InitializeComponent();
        }

        public frmHelp frmHelp
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public frmBlackTester frmBlackTester
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public frmWhiteTest frmWhiteTest
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public frmLogin frmLogin
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
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
        /// <summary>
        /// Closes the current form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Opens the white box testers form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWhite_Click(object sender, EventArgs e)
        {
            var myForm = new frmWhiteTest();
            myForm.Show();
        }
        /// <summary>
        /// Opens the black box testers form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlack_Click(object sender, EventArgs e)
        {
            var myForm = new frmBlackTester();
            myForm.Show();
        }
        /// <summary>
        /// Opens the developers form.
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
        private void maximizeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
