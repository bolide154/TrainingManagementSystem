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
    public partial class CategoriesGUI : Form
    {
        public CategoriesGUI()
        {
            InitializeComponent();
        }

        private void CategoriesGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToDataGridViewCategories();
            this.LoadDataToComBoBox();
        }
        private void LoadDataToComBoBox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("");
            keyArr.Add("Category Name");
            keyArr.Add("Description");            
            //Them 1 vai cai nua. khoang 3-4 cai thoi nha. cai nao quan trong ak :)
            this.cboSearch.DataSource = keyArr;
        }
        public void LoadDataToDataGridViewCategories()
        {
            this.dgvcategories.Rows.Clear();
            List<CategoriesBLL> categorieslist = new List<CategoriesBLL>();
            categorieslist = CategoriesDAL.getCategoriesList();
            foreach (CategoriesBLL row in categorieslist)
            {                
                this.dgvcategories.Rows.Add(row.Categoryid, row.Categoryname, row.Categorydescription);
            }
            this.getSelectedValue();
            this.dgvcategories.SelectionChanged += new EventHandler(dgvcategoriese_SelectionChanged);
        }

        private void dgvcategoriese_SelectionChanged(object sender, EventArgs e)
        {
            this.getSelectedValue();
        }

        private void getSelectedValue()
        {
            if (this.dgvcategories.SelectedCells.Count > 0 && this.dgvcategories.CurrentRow.Index < this.dgvcategories.Rows.Count - 1)
            {
                txtname.Text = dgvcategories.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dgvcategories.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                txtname.Text = "";
                txtDescription.Text = "";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoriesBLL categoriesBLL = new CategoriesBLL();
            categoriesBLL.Categoryname = txtname.Text.ToString();
            if (txtname.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Name");
                return;
            }
            categoriesBLL.Categorydescription = txtDescription.Text.ToString();
            if (txtDescription.Text.ToString() == "")
            {
                MessageBox.Show("Please enter Description");
                return;
            }
            CategoriesDAL.addCategories(categoriesBLL);
            MessageBox.Show("Add success!", "Success");
            this.LoadDataToDataGridViewCategories();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvcategories.SelectedCells.Count > 0)
            {

                int selectedrowindex = this.dgvcategories.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvcategories.Rows[selectedrowindex];

                CategoriesBLL categoriesBLL = new CategoriesBLL(Convert.ToInt32(selectedRow.Cells["clmnCategoryId"].Value), this.txtname.Text, this.txtDescription.Text);

                categoriesBLL.Categoryname = this.txtname.Text;
                if (categoriesBLL.Categoryname == "")
                {
                    MessageBox.Show("Please enter Name");
                    return;
                }
                categoriesBLL.Categorydescription = this.txtDescription.Text;
                if (categoriesBLL.Categorydescription == "")
                {
                    MessageBox.Show("plese enter Description");
                    return;
                }
                CategoriesDAL.saveCategories(categoriesBLL);
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToDataGridViewCategories();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvcategories.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvcategories.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvcategories.Rows[selectedrowindex];
                CategoriesBLL categoriesBLL = new CategoriesBLL(Convert.ToInt32(selectedRow.Cells["clmnCategoryId"].Value),selectedRow.Cells["ClmnCategoryName"].Value.ToString(), selectedRow.Cells["ClmnCategoryDescription"].Value.ToString());
                DialogResult result = MessageBox.Show("Do you want to delete Categories: " + selectedRow.Cells["ClmnCategoryName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:

                        if (CourseDAL.getCourse(categoriesBLL.Categoryid) != null)
                        {
                            MessageBox.Show("Can't delete! Please delete all course of  " + selectedRow.Cells["ClmnCategoryName"].Value + " before delete this Category!", "Error");
                            break;
                        }
                        else
                        {
                            CategoriesDAL.deleteCategories(categoriesBLL);
                            MessageBox.Show("Delete complete!", "Success");
                            this.LoadDataToDataGridViewCategories();
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
            if (this.cboSearch.SelectedItem.ToString() == "Category Name") // xem lại cái Name 
            {
                catalog = "categoryname";
            }
            if (this.cboSearch.SelectedItem.ToString() == "Description") // xem lại cái Name 
            {
                catalog = "categorydescription";
            }
           
            CategoriesBLL categoriesBLL = new CategoriesBLL();
            List<CategoriesBLL> categoriesList = new List<CategoriesBLL>(); //booktausArr
            categoriesList = CategoriesDAL.search(catalog, key);
            this.dgvcategories.Rows.Clear();
            if (categoriesList != null)
            {
                foreach (CategoriesBLL row in categoriesList)
                {
                    this.dgvcategories.Rows.Add(row.Categoryid, row.Categoryname, row.Categorydescription);
                }

            }

        }
    }
}
