using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_app
{
    public partial class MainForm : Form
    {
        private UserAuthenticationSystem authSystem = new UserAuthenticationSystem();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            authSystem.RegisterUser(username, password);
            MessageBox.Show("User registered successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            bool isAuthenticated = authSystem.AuthenticateUser(username, password);

            // Show a message box based on the authentication result
            if (isAuthenticated)
            {
                MessageBox.Show("Authentication successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            // Show an optional confirmation or just clear without dialog
            MessageBox.Show("Fields cleared!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
