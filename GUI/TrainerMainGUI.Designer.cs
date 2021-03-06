﻿namespace GUI
{
    partial class TrainerMainGUI
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
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrainee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(103, 111);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayName.TabIndex = 11;
            this.lblDisplayName.Text = "label4";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(103, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 156);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // mnuHome
            // 
            this.mnuHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuiLogout,
            this.mnuiExit});
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(52, 20);
            this.mnuHome.Text = "Home";
            // 
            // mnuiLogout
            // 
            this.mnuiLogout.Name = "mnuiLogout";
            this.mnuiLogout.Size = new System.Drawing.Size(112, 22);
            this.mnuiLogout.Text = "Logout";
            this.mnuiLogout.Click += new System.EventHandler(this.mnuiLogout_Click);
            // 
            // mnuiExit
            // 
            this.mnuiExit.Name = "mnuiExit";
            this.mnuiExit.Size = new System.Drawing.Size(112, 22);
            this.mnuiExit.Text = "Exit";
            this.mnuiExit.Click += new System.EventHandler(this.mnuiExit_Click);
            // 
            // mnuTrainee
            // 
            this.mnuTrainee.Name = "mnuTrainee";
            this.mnuTrainee.Size = new System.Drawing.Size(53, 20);
            this.mnuTrainee.Text = "Profile";
            this.mnuTrainee.Click += new System.EventHandler(this.mnuTrainee_Click);
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(56, 20);
            this.mnuCategory.Text = "Course";
            this.mnuCategory.Click += new System.EventHandler(this.mnuCategory_Click);
            // 
            // mnuCourse
            // 
            this.mnuCourse.Name = "mnuCourse";
            this.mnuCourse.Size = new System.Drawing.Size(22, 20);
            this.mnuCourse.Text = " ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuTrainee,
            this.mnuCategory,
            this.mnuCourse});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrainerMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 337);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TrainerMainGUI";
            this.Text = "TrainerMainGUI";
            this.Load += new System.EventHandler(this.TrainerMainGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuiLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuiExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTrainee;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}