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
    public partial class TopicGUI : Form
    {
        public TopicGUI()
        {
            InitializeComponent();
        }

        private void TopicGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToDataGridViewTopic();
            this.LoadDataToComBoBoxCourse();
        }
        public void LoadDataToComBoBoxCourse()
        {
            cboCourseName.DataSource = CourseDAL.getCourseList();
            cboCourseName.ValueMember = "courseid";
            cboCourseName.DisplayMember = "coursename";
        }
        public void LoadDataToDataGridViewTopic()
        {
            this.dgvTopic.Rows.Clear();
            List<TopicBLL> topiclist = new List<TopicBLL>();
            topiclist = TopicDAL.getTopicList();
            foreach (TopicBLL row in topiclist)
            {
                CourseBLL courseBLL = CourseDAL.getCourseById(row.CourseId);
                this.dgvTopic.Rows.Add(row.TopicId, row.CourseId, courseBLL.Coursename, row.TopicName, row.TopicDescription);
            }
            this.getSelectedValue();
            this.dgvTopic.SelectionChanged += new EventHandler(dgvTopic_SelectionChanged);
        }
        private void dgvTopic_SelectionChanged(object sender, EventArgs e)
        {
            this.getSelectedValue();
        }
        private void getSelectedValue()
        {
            if (this.dgvTopic.SelectedCells.Count > 0 && this.dgvTopic.CurrentRow.Index < this.dgvTopic.Rows.Count - 1)
            {
                cboCourseName.Text = dgvTopic.CurrentRow.Cells[2].Value.ToString();
                txtTopicName.Text = dgvTopic.CurrentRow.Cells[3].Value.ToString();
                txtDescription.Text = dgvTopic.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                cboCourseName.Text = "";
                txtTopicName.Text = "";
                txtDescription.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TopicBLL topicBLL = new TopicBLL();
            topicBLL.CourseId = int.Parse(cboCourseName.SelectedValue.ToString());
            if (cboCourseName.SelectedItem.ToString() == "")
            {
                MessageBox.Show("please choose Course");
                return;
            }

            topicBLL.TopicName = txtTopicName.Text.ToString();
            if (txtTopicName.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Topic Name");
                return;
            }
            topicBLL.TopicDescription = txtDescription.Text.ToString();
            if (txtDescription.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Description");
                return;
            }
            TopicDAL.addTopic(topicBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToDataGridViewTopic();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
