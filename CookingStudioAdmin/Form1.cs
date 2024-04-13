using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookingStudioAdmin
{
    public partial class loginForm : Form
    {

        private bool passwordVisible = false;

        public loginForm()
        {
            InitializeComponent();

            //This code is for the form to be in the center position
            this.StartPosition = FormStartPosition.CenterScreen;

            // Hide password characters by default
            PasswordTextbox.UseSystemPasswordChar = true;
        }


        private void loginForm_Load(object sender, EventArgs e)
        {
            unamePicture.SizeMode = PictureBoxSizeMode.CenterImage;
            passwordPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            showPicture.SizeMode = PictureBoxSizeMode.CenterImage;

            //This is the instance of form when closing- it calls the method LoginForm_FormClosing
            this.FormClosing += LoginForm_FormClosing;

            //This code ensures that the form is not resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        private void showPicture_MouseDown(object sender, MouseEventArgs e)
        {
            // Toggle password visibility
            passwordVisible = !passwordVisible;
            PasswordTextbox.UseSystemPasswordChar = !passwordVisible;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure that the application exits when the main form is closed
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text; // Assuming your username field is named usernameTextBox
            string password = PasswordTextbox.Text; // Assuming your password field is named passwordTextBox

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assuming your database connection string is stored somewhere accessible
            string connectionString = "Server=localhost;Database=cookingstudio;Uid=root;Pwd='';";

            // Query the database
            string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Handle the result
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Proceed with granting access or navigating to the next form

                        //Creates instance of the dashboard form
                        DashboardForm dashform = new DashboardForm();
                        dashform.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
