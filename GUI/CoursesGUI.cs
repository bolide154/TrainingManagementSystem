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
    public partial class CoursesGUI : Form
    {
        public CoursesGUI()
        {
            InitializeComponent();
        }

        private void CoursesGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToDataGridViewCourses();
            this.LoadDataToComBoBoxCategory();
            this.LoadDataToComBoBox();
        }
        private void LoadDataToComBoBox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("");
            keyArr.Add("Course Name");
            keyArr.Add("Course Description");
            this.cboSearch.DataSource = keyArr;
        }
        public void LoadDataToDataGridViewCourses()
        {
            this.dgvCourse.Rows.Clear();
            List<CourseBLL> courseslist = new List<CourseBLL>();
            courseslist = CourseDAL.getCourseList();
            foreach (CourseBLL row in courseslist)
            {
                CategoriesBLL categoriesBLL = CategoriesDAL.getCategoryById(row.Categoryid);
                this.dgvCourse.Rows.Add(row.Categoryid,row.Courseid, categoriesBLL.Categoryname, row.Coursename, row.Coursedescription);
            }
            this.getSelectedValue();
            this.dgvCourse.SelectionChanged += new EventHandler(dgvCourse_SelectionChanged);

        }
        public void LoadDataToComBoBoxCategory()
        {
            cbocategoryname.DataSource = CategoriesDAL.getCategoriesList();            
            cbocategoryname.ValueMember = "categoryid";
            cbocategoryname.DisplayMember = "categoryname";
        }

        private void dgvCourse_SelectionChanged(object sender, EventArgs e)
        {
            this.getSelectedValue();
        }

        private void getSelectedValue()
        {
            if (this.dgvCourse.SelectedCells.Count > 0 && this.dgvCourse.CurrentRow.Index < this.dgvCourse.Rows.Count - 1)
            {
                cbocategoryname.Text = dgvCourse.CurrentRow.Cells[2].Value.ToString();
                txtcoursename.Text = dgvCourse.CurrentRow.Cells[3].Value.ToString();
                txtDescription.Text = dgvCourse.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                cbocategoryname.Text = "";
                txtcoursename.Text = "";
                txtDescription.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseBLL courseBLL = new CourseBLL();
            courseBLL.Categoryid = int.Parse(cbocategoryname.SelectedValue.ToString());
            if(cbocategoryname.SelectedItem.ToString()=="")
            {
                MessageBox.Show("please choose Category");
                return;
            }
            
            courseBLL.Coursename = txtcoursename.Text.ToString();
            if (txtcoursename.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Name");
                return;
            }
            courseBLL.Coursedescription = txtDescription.Text.ToString();
            if (txtDescription.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Description");
                return;
            }
            CourseDAL.addCourse(courseBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToDataGridViewCourses();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvCourse.SelectedCells.Count > 0)
            {

                int selectedrowindex = this.dgvCourse.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvCourse.Rows[selectedrowindex];

                CourseBLL courseBLL = new CourseBLL( Convert.ToInt32(selectedRow.Cells["ClmnCourseId"].Value), Convert.ToInt32(selectedRow.Cells["clmnCategoryId"].Value), this.txtcoursename.Text, this.txtDescription.Text);

                courseBLL.Categoryid = int.Parse(cbocategoryname.SelectedValue.ToString());
                if (cbocategoryname.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("please choose Category");
                    return;
                }
                courseBLL.Coursename = this.txtcoursename.Text;
                if (courseBLL.Coursename == "")
                {
                    MessageBox.Show("Please enter Name");
                    return;
                }
                courseBLL.Coursedescription = this.txtDescription.Text;
                if (courseBLL.Coursedescription == "")
                {
                    MessageBox.Show("plese enter Description");
                    return;
                }
                CourseDAL.saveCourse(courseBLL);
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToDataGridViewCourses();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvCourse.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvCourse.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvCourse.Rows[selectedrowindex];
                CourseBLL courseBLL = new CourseBLL(Convert.ToInt32(selectedRow.Cells["ClmnCourseId"].Value), Convert.ToInt32(selectedRow.Cells["clmnCategoryId"].Value),selectedRow.Cells["ClmnCourseName"].Value.ToString(), selectedRow.Cells["ClmnCourseDescription"].Value.ToString());
                DialogResult result = MessageBox.Show("Do you want to delete Course: " + selectedRow.Cells["ClmnCourseName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:

                        if (CourseToTraineeDAL.getCourseOfTrainee1(courseBLL.Courseid) != null)
                        {
                            MessageBox.Show("Can't delete! Please delete all course to trainee of  " + selectedRow.Cells["ClmnCourseName"].Value + " before delete this Course!", "Error");
                            break;
                        }
                        else
                        {
                            CourseDAL.deleteCourse(courseBLL);
                            MessageBox.Show("Delete complete!", "Success");
                            this.LoadDataToDataGridViewCourses();
                            break;
                        }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          

            string key = this.txtSearch.Text;

            if (key == "".Trim())
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            if (this.cboSearch.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Please choose keyword!", "Notice");
                return;
            }
            string catalog = "";
           
            if (this.cboSearch.SelectedItem.ToString() == "Course Name") // xem lại cái Name 
            {
                catalog = "coursename";
            }
            if (this.cboSearch.SelectedItem.ToString() == "Course Description") // xem lại cái Name 
            {
                catalog = "coursedescription";
            }

            CourseBLL courseBLL = new CourseBLL();
            List<CourseBLL> courseList = new List<CourseBLL>(); //booktausArr
            courseList = CourseDAL.search(catalog, key);
            this.dgvCourse.Rows.Clear();
            if (courseList != null)
            {
                foreach (CourseBLL row in courseList)
                {
                    CategoriesBLL categoriesBLL = CategoriesDAL.getCategoryById(row.Categoryid);
                    this.dgvCourse.Rows.Add(row.Categoryid,row.Courseid,categoriesBLL.Categoryname, row.Coursename, row.Coursedescription);
                }

            }

        }
    }
}
