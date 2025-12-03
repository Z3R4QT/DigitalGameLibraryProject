using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private string usersFile = "users.txt"; // File to store users

        // Sign In button
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!File.Exists(usersFile))
            {
                MessageBox.Show("No users found. Please sign up first.");
                return;
            }

            bool loginSuccess = false;

            foreach (string line in File.ReadAllLines(usersFile))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    loginSuccess = true;
                    break;
                }
            }

            if (loginSuccess)
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        // Sign Up button
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password!");
                return;
            }

            // Check if file exists
            if (!File.Exists(usersFile))
                File.Create(usersFile).Close();

            // Check for duplicate username
            foreach (string line in File.ReadAllLines(usersFile))
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username)
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }
            }

            // Save new user
            File.AppendAllText(usersFile, username + "," + password + Environment.NewLine);
            MessageBox.Show("User created successfully!");
        }
    }
}
    
