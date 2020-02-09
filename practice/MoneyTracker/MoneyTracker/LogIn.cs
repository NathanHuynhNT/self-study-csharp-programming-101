using MoneyTracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Happens when click on the LogIn button
        /// if password is correct, open the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == Properties.Settings.Default.apppassword)
            {
                //Login
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                //Access denied
                MessageBox.Show("ACCESS DENIED!");
            }
        }
    }
}
