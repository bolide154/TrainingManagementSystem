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
    public partial class CourseToTraineeGUI : Form
    {
        TraineeBLL _trainerBLL = new TraineeBLL();
        public CourseToTraineeGUI(TraineeBLL trainerBLL)
        {
            
            InitializeComponent();
            this._trainerBLL = trainerBLL;
            this.lblName.Text = trainerBLL.TraineeName;
            
        }

        private void CourseToTraineeGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToComBoBoxCourse();
            this.LoadDataToDataGridViewCoursesToTrainee();
        }
        public void LoadDataToDataGridViewCoursesToTrainee()
        {
            this.dgvCourseToTrainee.Rows.Clear();
            List<CourseToTraineeBLL> coursetotraineelist = new List<CourseToTraineeBLL>();
            coursetotraineelist = CourseToTraineeDAL.getCourseToTraineeList(this._trainerBLL);
            foreach (CourseToTraineeBLL row in coursetotraineelist)
            {
                TraineeBLL traineeBLL = TraineeDAL.getTraineeById(row.TraineeId);
                CourseBLL courseBLL = CourseDAL.getCourseById(row.CourseId);
                this.dgvCourseToTrainee.Rows.Add(row.TraineeId, row.CourseId, traineeBLL.TraineeName, courseBLL.Coursename);
            }
            this.getSelectedValue();
            this.dgvCourseToTrainee.SelectionChanged += new EventHandler(dgvCourseToTrainee_SelectionChanged);


        }
        private void dgvCourseToTrainee_SelectionChanged(object sender, EventArgs e)
        {
            this.getSelectedValue();
        }
        private void getSelectedValue()
        {
            if (this.dgvCourseToTrainee.SelectedCells.Count > 0 && this.dgvCourseToTrainee.CurrentRow.Index < this.dgvCourseToTrainee.Rows.Count - 1)
            {
                lblName.Text = dgvCourseToTrainee.CurrentRow.Cells[2].Value.ToString();
                cboCourseName.Text = dgvCourseToTrainee.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                lblName.Text = "";
                cboCourseName.Text = "";                
            }
        }
        public void LoadDataToComBoBoxCourse()
        {
            cboCourseName.DataSource = CourseDAL.getCourseList();
            cboCourseName.ValueMember = "courseid";
            cboCourseName.DisplayMember = "coursename";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            CourseToTraineeBLL coursetotraineeBLL = new CourseToTraineeBLL();
            coursetotraineeBLL.TraineeId =_trainerBLL.TraineeId;



            coursetotraineeBLL.CourseId = int.Parse(cboCourseName.SelectedValue.ToString());
            if (cboCourseName.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Name");
                return;
            }           
            CourseToTraineeDAL.addCourseToTrainee(coursetotraineeBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToDataGridViewCoursesToTrainee();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
