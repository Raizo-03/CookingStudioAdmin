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
        public loginForm()
        {
            InitializeComponent();

            //This code is for the form to be in the center position
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void loginForm_Load(object sender, EventArgs e)
        {
            unamePicture.SizeMode = PictureBoxSizeMode.CenterImage;
            passwordPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            showPicture.SizeMode = PictureBoxSizeMode.CenterImage;

            //This is the instance of form when closing- it calls the method BookingOverviewForm_FormClosing
            this.FormClosing += BookingOverviewForm_FormClosing;

            //This code ensures that the form is not resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void BookingOverviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure that the application exits when the main form is closed
            Application.Exit();
        }

    }
}
