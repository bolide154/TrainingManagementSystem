namespace GUI
{
    partial class TrainerCourseGUI
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
            this.dgvTrainerCourse = new System.Windows.Forms.DataGridView();
            this.clmnCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainerCourse
            // 
            this.dgvTrainerCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainerCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCourseId,
            this.clmnCategoryId,
            this.clmnName,
            this.clmnDescription});
            this.dgvTrainerCourse.Location = new System.Drawing.Point(23, 24);
            this.dgvTrainerCourse.Name = "dgvTrainerCourse";
            this.dgvTrainerCourse.Size = new System.Drawing.Size(386, 233);
            this.dgvTrainerCourse.TabIndex = 0;
            // 
            // clmnCourseId
            // 
            this.clmnCourseId.HeaderText = "Course Id";
            this.clmnCourseId.Name = "clmnCourseId";
            this.clmnCourseId.Visible = false;
            // 
            // clmnCategoryId
            // 
            this.clmnCategoryId.HeaderText = "Category Id";
            this.clmnCategoryId.Name = "clmnCategoryId";
            this.clmnCategoryId.Visible = false;
            // 
            // clmnName
            // 
            this.clmnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnName.HeaderText = "Name";
            this.clmnName.Name = "clmnName";
            // 
            // clmnDescription
            // 
            this.clmnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDescription.HeaderText = "Description";
            this.clmnDescription.Name = "clmnDescription";
            // 
            // TrainerCourseGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 284);
            this.Controls.Add(this.dgvTrainerCourse);
            this.Name = "TrainerCourseGUI";
            this.Text = "TrainerCourseGUI";
            this.Load += new System.EventHandler(this.TrainerCourseGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainerCourse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrainerCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
    }
}