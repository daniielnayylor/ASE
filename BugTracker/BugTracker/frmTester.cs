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
    public partial class frmTester : Form
    {
        public frmTester()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new frmDeveloper();
            myForm.Show();
        }


        public void cleartxtBoxes()



        {
            txtAppName.Text = txtCause.Text = txtError.Text = "";
        }

        public bool checkInputs()
        {
            bool rtnvalue = true;

            if (string.IsNullOrEmpty(txtAppName.Text) ||
                string.IsNullOrEmpty(txtCause.Text) ||
                string.IsNullOrEmpty(txtError.Text))
            {
                MessageBox.Show("Error: Please check your inputs");
                rtnvalue = false;
            }

            return (rtnvalue);

        }
    
    }
}
