namespace GUI
{
    partial class CourseToTraineeGUI
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
            this.dgvCourseToTrainee = new System.Windows.Forms.DataGridView();
            this.clmnTraineeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTraineeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseToTrainee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourseToTrainee
            // 
            this.dgvCourseToTrainee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseToTrainee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTraineeId,
            this.clmnCourseId,
            this.clmnTraineeName,
            this.clmnCourseName});
            this.dgvCourseToTrainee.Location = new System.Drawing.Point(12, 12);
            this.dgvCourseToTrainee.Name = "dgvCourseToTrainee";
            this.dgvCourseToTrainee.Size = new System.Drawing.Size(440, 150);
            this.dgvCourseToTrainee.TabIndex = 0;
            // 
            // clmnTraineeId
            // 
            this.clmnTraineeId.HeaderText = "Trainee Id";
            this.clmnTraineeId.Name = "clmnTraineeId";
            this.clmnTraineeId.Visible = false;
            // 
            // clmnCourseId
            // 
            this.clmnCourseId.HeaderText = "Course Id";
            this.clmnCourseId.Name = "clmnCourseId";
            this.clmnCourseId.Visible = false;
            // 
            // clmnTraineeName
            // 
            this.clmnTraineeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTraineeName.HeaderText = "Trainee Name";
            this.clmnTraineeName.Name = "clmnTraineeName";
            // 
            // clmnCourseName
            // 
            this.clmnCourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnCourseName.HeaderText = "Course Name";
            this.clmnCourseName.Name = "clmnCourseName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trainee name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(102, 175);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course name:";
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(16, 231);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(436, 21);
            this.cboCourseName.TabIndex = 4;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(238, 258);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(104, 23);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CourseToTraineeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 295);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.cboCourseName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCourseToTrainee);
            this.Name = "CourseToTraineeGUI";
            this.Text = "CourseToTraineeGUI";
            this.Load += new System.EventHandler(this.CourseToTraineeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseToTrainee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourseToTrainee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTraineeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTraineeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseName;
    }
}