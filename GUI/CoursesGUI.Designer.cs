namespace GUI
{
    partial class CoursesGUI
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCourse = new System.Windows.Forms.DataGridView();
            this.clmnCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnCourseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbocategoryname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddtopic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(502, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Location = new System.Drawing.Point(35, 24);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(187, 21);
            this.cboSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(251, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(226, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // dgvCourse
            // 
            this.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCategoryId,
            this.ClmnCourseId,
            this.ClmCategoryName,
            this.ClmnCourseName,
            this.ClmnCourseDescription});
            this.dgvCourse.Location = new System.Drawing.Point(35, 51);
            this.dgvCourse.Name = "dgvCourse";
            this.dgvCourse.Size = new System.Drawing.Size(572, 150);
            this.dgvCourse.TabIndex = 3;
            // 
            // clmnCategoryId
            // 
            this.clmnCategoryId.HeaderText = "Category Id";
            this.clmnCategoryId.Name = "clmnCategoryId";
            this.clmnCategoryId.Visible = false;
            // 
            // ClmnCourseId
            // 
            this.ClmnCourseId.HeaderText = "Course Id";
            this.ClmnCourseId.Name = "ClmnCourseId";
            this.ClmnCourseId.Visible = false;
            // 
            // ClmCategoryName
            // 
            this.ClmCategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmCategoryName.HeaderText = "Category Name";
            this.ClmCategoryName.Name = "ClmCategoryName";
            // 
            // ClmnCourseName
            // 
            this.ClmnCourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmnCourseName.HeaderText = "Course Name";
            this.ClmnCourseName.Name = "ClmnCourseName";
            // 
            // ClmnCourseDescription
            // 
            this.ClmnCourseDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmnCourseDescription.HeaderText = "Course Description";
            this.ClmnCourseDescription.Name = "ClmnCourseDescription";
            // 
            // cbocategoryname
            // 
            this.cbocategoryname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoryname.FormattingEnabled = true;
            this.cbocategoryname.Location = new System.Drawing.Point(32, 235);
            this.cbocategoryname.Name = "cbocategoryname";
            this.cbocategoryname.Size = new System.Drawing.Size(575, 21);
            this.cbocategoryname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course Name:";
            // 
            // txtcoursename
            // 
            this.txtcoursename.Location = new System.Drawing.Point(32, 288);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(575, 20);
            this.txtcoursename.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(35, 336);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(572, 79);
            this.txtDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 421);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 421);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(276, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(393, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddtopic
            // 
            this.btnAddtopic.Location = new System.Drawing.Point(502, 421);
            this.btnAddtopic.Name = "btnAddtopic";
            this.btnAddtopic.Size = new System.Drawing.Size(105, 23);
            this.btnAddtopic.TabIndex = 15;
            this.btnAddtopic.Text = "Add Topic";
            this.btnAddtopic.UseVisualStyleBackColor = true;
            this.btnAddtopic.Click += new System.EventHandler(this.btnAddtopic_Click);
            // 
            // CoursesGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 488);
            this.Controls.Add(this.btnAddtopic);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtcoursename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbocategoryname);
            this.Controls.Add(this.dgvCourse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "CoursesGUI";
            this.Text = "CoursesGUI";
            this.Load += new System.EventHandler(this.CoursesGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCourse;
        private System.Windows.Forms.ComboBox cbocategoryname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddtopic;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCourseDescription;
    }
}