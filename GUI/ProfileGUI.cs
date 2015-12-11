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
    public partial class ProfileGUI : Form
    {
        private StaffBLL _staffBLL = new StaffBLL();
        public ProfileGUI(StaffBLL staffBLL)
        {
            InitializeComponent();
            this._staffBLL = staffBLL;
        }

        private void ProfileGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToTrainer();
            //n
        }
        public void LoadDataToTrainer()
        {
            TrainerBLL trainerBLL = new TrainerBLL();
            trainerBLL = TrainerDAL.getTrainerById(this._staffBLL);

            this.txtEmail.Text = trainerBLL.EmailAddress;
            this.txtName.Text = trainerBLL.TrainerName;
            this.txtWP.Text = trainerBLL.WorkingPlace;
            //this.cboType.Text = trainerBLL.InternalType;
            this.loadDataoToComboboxType();
            foreach (ComboboxItem item in this.cboType.Items)
            {
                //dang nhap tai khoan anh luyen coi
                if (Convert.ToBoolean(item.Value) == trainerBLL.InternalType)
                {
                    this.cboType.SelectedItem = item;
                }
            }
            this.txtPhone.Text = trainerBLL.Telephone;
            this.lbid.Text = trainerBLL.TrainerId.ToString();
        }

        private void loadDataoToComboboxType()
        {
            List<ComboboxItem> comboboxList = new List<ComboboxItem>();
            ComboboxItem item1 = new ComboboxItem();
            item1.Text = "External";
            item1.Value = false;
            comboboxList.Add(item1);
            ComboboxItem item2 = new ComboboxItem();
            item2.Text = "Internal";
            item2.Value = true;
            comboboxList.Add(item2);
            this.cboType.DataSource = comboboxList;
            this.cboType.ValueMember = "Value";
            this.cboType.DisplayMember = "Text";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            TrainerBLL trainerBLL = new TrainerBLL(int.Parse(this.lbid.Text),this.txtEmail.Text, this.txtName.Text,Convert.ToBoolean(cboType.SelectedValue),this.txtWP.Text,this.txtPhone.Text);
            trainerBLL.EmailAddress = this.txtEmail.Text;
            if(this.txtEmail.Text=="")
            {
                MessageBox.Show("please enter Email");
                return;
            }
            trainerBLL.TrainerName = txtName.Text;
            if(txtName.Text=="")
            {
                MessageBox.Show("please enter Name");
                return;
            }
                trainerBLL.InternalType = Convert.ToBoolean(cboType.SelectedValue);
                if (cboType.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("please choose Type");
                    return;
                }
                trainerBLL.WorkingPlace = this.txtWP.Text;
                if (txtWP.Text== "")
                {
                    MessageBox.Show("Please enter Working Place");
                    return;
                }
                trainerBLL.Telephone = this.txtPhone.Text;
                if (txtPhone.Text == "")
                {
                    MessageBox.Show("plese enter Phone");
                    return;
                }
                TrainerDAL.saveTrainerinfomation(trainerBLL);
                MessageBox.Show("Update success!", "Success");
                this.LoadDataToTrainer();

            
        }
    }
}
