namespace GUI
{
    partial class TopicGUI
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
            this.dgvTopic = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopicName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAssignTrainer = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboCourseName = new System.Windows.Forms.ComboBox();
            this.clmnTopicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTopic
            // 
            this.dgvTopic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTopicId,
            this.clmnCourseId,
            this.clmnCourseName,
            this.clmnTopicName,
            this.clmnDescription});
            this.dgvTopic.Location = new System.Drawing.Point(21, 23);
            this.dgvTopic.Name = "dgvTopic";
            this.dgvTopic.Size = new System.Drawing.Size(483, 150);
            this.dgvTopic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Topic Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description:";
            // 
            // txtTopicName
            // 
            this.txtTopicName.Location = new System.Drawing.Point(24, 256);
            this.txtTopicName.Name = "txtTopicName";
            this.txtTopicName.Size = new System.Drawing.Size(480, 20);
            this.txtTopicName.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(21, 303);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(483, 102);
            this.txtDescription.TabIndex = 6;
            // 
            // btnAssignTrainer
            // 
            this.btnAssignTrainer.Location = new System.Drawing.Point(165, 411);
            this.btnAssignTrainer.Name = "btnAssignTrainer";
            this.btnAssignTrainer.Size = new System.Drawing.Size(110, 23);
            this.btnAssignTrainer.TabIndex = 7;
            this.btnAssignTrainer.Text = "Assign Trainer";
            this.btnAssignTrainer.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(281, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(398, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboCourseName
            // 
            this.cboCourseName.FormattingEnabled = true;
            this.cboCourseName.Location = new System.Drawing.Point(24, 206);
            this.cboCourseName.Name = "cboCourseName";
            this.cboCourseName.Size = new System.Drawing.Size(480, 21);
            this.cboCourseName.TabIndex = 10;
            // 
            // clmnTopicId
            // 
            this.clmnTopicId.HeaderText = "Topic Id";
            this.clmnTopicId.Name = "clmnTopicId";
            this.clmnTopicId.Visible = false;
            // 
            // clmnCourseId
            // 
            this.clmnCourseId.HeaderText = "Course Id";
            this.clmnCourseId.Name = "clmnCourseId";
            this.clmnCourseId.Visible = false;
            // 
            // clmnCourseName
            // 
            this.clmnCourseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnCourseName.HeaderText = "Course Name";
            this.clmnCourseName.Name = "clmnCourseName";
            // 
            // clmnTopicName
            // 
            this.clmnTopicName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnTopicName.HeaderText = "Topic Name";
            this.clmnTopicName.Name = "clmnTopicName";
            // 
            // clmnDescription
            // 
            this.clmnDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDescription.HeaderText = "Description";
            this.clmnDescription.Name = "clmnDescription";
            // 
            // TopicGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 448);
            this.Controls.Add(this.cboCourseName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAssignTrainer);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTopicName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTopic);
            this.Name = "TopicGUI";
            this.Text = "TopicGUI";
            this.Load += new System.EventHandler(this.TopicGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTopicName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAssignTrainer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTopicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDescription;
    }
}