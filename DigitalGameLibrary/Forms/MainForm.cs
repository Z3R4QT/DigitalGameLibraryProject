using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalGameLibrary.Forms;

namespace DigitalGameLibrary.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadControl(UserControl uc)
        {
            panel6.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel6.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnAddGames_Click(object sender, EventArgs e)
        {
            LoadControl(new GameControl());
        }


        private void btnOwnerShip_Click(object sender, EventArgs e)
        {
            LoadControl(new OwnershipControl());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panel6.Controls)
            {
                ctrl.Visible = false;
            }

            // Show panel6 itself as Home
            panel6.Visible = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageGames_Click(object sender, EventArgs e)
        {
            LoadControl(new ManageControl());
        }
    }
}
