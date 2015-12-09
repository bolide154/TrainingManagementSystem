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
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!this.validateForm()){
                return;
            }
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            StaffBLL staffBLL = new StaffBLL();
            staffBLL = StaffDAL.getStaffById(Int32.Parse(username));
            if (staffBLL != null)
            {
                if (staffBLL.Password.Equals(password))
                {
                    MessageBox.Show("Login success!", "Success");
                    if (staffBLL.Role == "ADMIN")
                    {
                       
                    }
                    else if (staffBLL.Role == "STAFF")
                    {
                        TrainingMainGUI trainingMainGUI = new TrainingMainGUI(staffBLL);
                        trainingMainGUI.Show();
                        this.Hide();
                    }
                    else if (staffBLL.Role == "Trainee")
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Password wrong!", "Fail");
                }
            }
            else
            {
                MessageBox.Show("Username wrong!", "Fail");
            }
        }

        private bool isNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        private bool validateForm()
        {
            if (this.txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Username mustn't null!", "Warning");
                return false;
            }
            else  if (this.txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password mustn't null!", "Warning");
                return false;
            }
            else if (!this.isNumeric(this.txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username must be integers!", "Warning");
                return false;
            }
            return true;
        }
    }
}
