namespace GUI
{
    partial class TraineeManagementGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvTraineeManagement = new System.Windows.Forms.DataGridView();
            this.clmnTraineeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTraineeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTraineeDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnToeicScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProgramLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnExperienceDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttoeic = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtdetails = new System.Windows.Forms.TextBox();
            this.dtpdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndetele = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraineeManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "Trainee Name"});
            this.cboSearch.Location = new System.Drawing.Point(12, 36);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(158, 21);
            this.cboSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(176, 36);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(285, 20);
            this.txtsearch.TabIndex = 2;
            // 
            // dgvTraineeManagement
            // 
            this.dgvTraineeManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraineeManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTraineeId,
            this.clmnTraineeName,
            this.clmnTraineeDateOfBirth,
            this.clmnToeicScore,
            this.clmnProgramLanguage,
            this.clmnExperienceDetails,
            this.clmnDepartment,
            this.clmnLocation});
            this.dgvTraineeManagement.Location = new System.Drawing.Point(12, 79);
            this.dgvTraineeManagement.Name = "dgvTraineeManagement";
            this.dgvTraineeManagement.Size = new System.Drawing.Size(533, 250);
            this.dgvTraineeManagement.TabIndex = 3;
            this.dgvTraineeManagement.CurrentCellChanged += new System.EventHandler(this.dgvTraineeManagement_CurrentCellChanged);
            // 
            // clmnTraineeId
            // 
            this.clmnTraineeId.HeaderText = "Trainee Id";
            this.clmnTraineeId.Name = "clmnTraineeId";
            // 
            // clmnTraineeName
            // 
            this.clmnTraineeName.HeaderText = "Trainee Name";
            this.clmnTraineeName.Name = "clmnTraineeName";
            // 
            // clmnTraineeDateOfBirth
            // 
            this.clmnTraineeDateOfBirth.HeaderText = "Date Of Birth";
            this.clmnTraineeDateOfBirth.Name = "clmnTraineeDateOfBirth";
            // 
            // clmnToeicScore
            // 
            this.clmnToeicScore.HeaderText = "Toeic Score";
            this.clmnToeicScore.Name = "clmnToeicScore";
            // 
            // clmnProgramLanguage
            // 
            this.clmnProgramLanguage.HeaderText = "Program Language";
            this.clmnProgramLanguage.Name = "clmnProgramLanguage";
            // 
            // clmnExperienceDetails
            // 
            this.clmnExperienceDetails.HeaderText = "Experience Details";
            this.clmnExperienceDetails.Name = "clmnExperienceDetails";
            // 
            // clmnDepartment
            // 
            this.clmnDepartment.HeaderText = "Department";
            this.clmnDepartment.Name = "clmnDepartment";
            // 
            // clmnLocation
            // 
            this.clmnLocation.HeaderText = "Location";
            this.clmnLocation.Name = "clmnLocation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toeic Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Main Programming Language:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Location:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Experience Details:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 372);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(240, 20);
            this.txtname.TabIndex = 11;
            // 
            // txttoeic
            // 
            this.txttoeic.Location = new System.Drawing.Point(12, 476);
            this.txttoeic.Name = "txttoeic";
            this.txttoeic.Size = new System.Drawing.Size(240, 20);
            this.txttoeic.TabIndex = 12;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(12, 535);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(240, 20);
            this.txtdepartment.TabIndex = 13;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(12, 425);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(240, 20);
            this.txtlocation.TabIndex = 14;
            // 
            // txtdetails
            // 
            this.txtdetails.Location = new System.Drawing.Point(307, 476);
            this.txtdetails.Multiline = true;
            this.txtdetails.Name = "txtdetails";
            this.txtdetails.Size = new System.Drawing.Size(238, 79);
            this.txtdetails.TabIndex = 15;
            // 
            // dtpdateofbirth
            // 
            this.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateofbirth.Location = new System.Drawing.Point(307, 369);
            this.dtpdateofbirth.Name = "dtpdateofbirth";
            this.dtpdateofbirth.Size = new System.Drawing.Size(238, 20);
            this.dtpdateofbirth.TabIndex = 16;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(152, 583);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(93, 23);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndetele
            // 
            this.btndetele.Location = new System.Drawing.Point(251, 583);
            this.btndetele.Name = "btndetele";
            this.btndetele.Size = new System.Drawing.Size(91, 23);
            this.btndetele.TabIndex = 19;
            this.btndetele.Text = "Detele";
            this.btndetele.UseVisualStyleBackColor = true;
            this.btndetele.Click += new System.EventHandler(this.btndetele_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(348, 583);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 23);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(452, 583);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(93, 23);
            this.btnclose.TabIndex = 21;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtlanguage
            // 
            this.txtlanguage.Location = new System.Drawing.Point(307, 425);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(238, 20);
            this.txtlanguage.TabIndex = 22;
            // 
            // TraineeManagementGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 616);
            this.Controls.Add(this.txtlanguage);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndetele);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dtpdateofbirth);
            this.Controls.Add(this.txtdetails);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txttoeic);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTraineeManagement);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSearch);
            this.Name = "TraineeManagementGUI";
            this.Text = "TraineeManagement";
            this.Load += new System.EventHandler(this.TraineeManagementGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraineeManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvTraineeManagement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttoeic;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.TextBox txtdetails;
        private System.Windows.Forms.DateTimePicker dtpdateofbirth;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndetele;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTraineeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTraineeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTraineeDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnToeicScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProgramLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnExperienceDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLocation;
        private System.Windows.Forms.TextBox txtlanguage;
    }
}