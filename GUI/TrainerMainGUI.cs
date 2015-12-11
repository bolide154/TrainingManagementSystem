using Core.BLL;
using Core.DAL;
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
    public partial class TrainerMainGUI : Form
    {
        private StaffBLL _staffBLL = new StaffBLL();
        public TrainerMainGUI(StaffBLL staffBLL)
        {
            InitializeComponent();
            this.lblId.Text = staffBLL.StaffId.ToString();
            this.lblDisplayName.Text = staffBLL.DisplayName;
            this._staffBLL = staffBLL;
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
            ProfileGUI ProfileGUI = new ProfileGUI(this._staffBLL);
            ProfileGUI.Show();
        }

        private void TrainerMainGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            TrainerCourseGUI TrainerCourseGUI = new TrainerCourseGUI(this._staffBLL);
            TrainerCourseGUI.Show();
        }
    }
}
