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
    public partial class TrainerCourseGUI : Form
    {
        private StaffBLL _staffBLL = new StaffBLL();
        public TrainerCourseGUI(StaffBLL staffBLL)
        {
            InitializeComponent();
            this._staffBLL = staffBLL;
        }

        private void TrainerCourseGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToDataGridViewTrainerCourse();
        }
        public void LoadDataToDataGridViewTrainerCourse()
        {
            this.dgvTrainerCourse.Rows.Clear();
            List<CourseBLL> trainercourselist = new List<CourseBLL>();
            trainercourselist = TrainerCourseDAL.getTrainerList(this._staffBLL);
            foreach (CourseBLL row in trainercourselist)
            {
                this.dgvTrainerCourse.Rows.Add(row.Categoryid, row.Courseid, row.Coursename, row.Coursedescription);
            }
        }
    }
}
