using Core.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrainingMainGUI : Form
    {
        public TrainingMainGUI(StaffBLL staffBLL)
        {
            InitializeComponent();
            this.lblId.Text = staffBLL.StaffId.ToString();
            this.lblDisplayName.Text = staffBLL.DisplayName;
        }

        private void mnuiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuiLogout_Click(object sender, EventArgs e)
        {
            StaffBLL staffBLL = new StaffBLL();
            LoginGUI LoginGUI = new LoginGUI();
            LoginGUI.Show();
            this.Hide();
        }

        private void mnuTrainee_Click(object sender, EventArgs e)
        {
            TraineeManagementGUI TraineeManagementGUI = new TraineeManagementGUI();
            TraineeManagementGUI.Show();
            
        }
    }
}
