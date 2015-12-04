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
    public partial class TraineeManagementGUI : Form
    {
        public TraineeManagementGUI()
        {
            InitializeComponent();
        }

        private void TraineeManagementGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToDataGirdView();
        }

        private void LoadDataToDataGirdView()
        {
            this.dgvTraineeManagement.Rows.Clear();
            List<TraineeBLL> traineeList = new List<TraineeBLL>();
            traineeList = TraineeDAL.getTraineeList();
            //this.dgvTraineeManagement.DataSource = traineeList;           
            foreach (TraineeBLL row in traineeList)
            {

                this.dgvTraineeManagement.Rows.Add(row.TraineeId, row.TraineeName, row.DateOfBirth.ToShortDateString(), row.ToeicScore, row.ProgramLanguage, row.ExperienceDetails, row.Department, row.Location);
            }
        }

        private void dgvTraineeManagement_CurrentCellChanged(object sender, EventArgs e)
        {
            if(this.dgvTraineeManagement.SelectedCells.Count>0 && this.dgvTraineeManagement.CurrentRow.Index<this.dgvTraineeManagement.Rows.Count-1)
            {
                txtname.Text = dgvTraineeManagement.CurrentRow.Cells[1].Value.ToString();
                dtpdateofbirth.Text = dgvTraineeManagement.CurrentRow.Cells[2].Value.ToString();
                txttoeic.Text = dgvTraineeManagement.CurrentRow.Cells[3].Value.ToString();
                txtlanguage.Text = dgvTraineeManagement.CurrentRow.Cells[4].Value.ToString();
                txtdetails.Text = dgvTraineeManagement.CurrentRow.Cells[5].Value.ToString();
                txtdepartment.Text = dgvTraineeManagement.CurrentRow.Cells[6].Value.ToString();
                txtlocation.Text = dgvTraineeManagement.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {
                txtname.Text = "";
                dtpdateofbirth.Text = "";
                txttoeic.Text ="0" ;
                txtlanguage.Text = "";
                txtdetails.Text = "";
                txtdepartment.Text = "";
                txtlocation.Text = "";
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            TraineeBLL traineeBLL = new TraineeBLL();
            traineeBLL.TraineeName = this.txtname.Text;
            if (traineeBLL.TraineeName == "")
            {
                MessageBox.Show("please enter name","Notice");
                return;
            }
            traineeBLL.DateOfBirth = dtpdateofbirth.Value;
            if (traineeBLL.DateOfBirth == null)
            {
                MessageBox.Show("please enter Date Of Birth", "Notice");
                return;
            }
            traineeBLL.ToeicScore = int.Parse(txttoeic.Text);
            if (traineeBLL.ToeicScore == 0)
            {
                MessageBox.Show("please enter Toeic Score", "Notice");
                return;
            }
            traineeBLL.ProgramLanguage = this.txtlanguage.Text.ToString();
            if(traineeBLL.ProgramLanguage == "")
            {
                MessageBox.Show("please enter Language", "Notice");
                return;
            }
            traineeBLL.ExperienceDetails = this.txtlanguage.Text.ToString();
            if(traineeBLL.ExperienceDetails == "")
            {
                MessageBox.Show("please enter Experience Detail", "Notice");
                return;
            }
            traineeBLL.Department = this.txtdepartment.Text.ToString();
            if(traineeBLL.Department == "")
            {
                MessageBox.Show("please enter Department", "Notice");
                return;
            }
            traineeBLL.Location = this.txtlocation.Text.ToString();
            if (traineeBLL.Location== "")
            {
                MessageBox.Show("please enter Location");
                return;
            }
            TraineeDAL.addTrainee(traineeBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToDataGirdView();
        }
    }


}
