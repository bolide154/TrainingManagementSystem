namespace GUI
{
    partial class ProfileGUI
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtWP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbWP = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lbid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(19, 260);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(374, 20);
            this.txtPhone.TabIndex = 21;
            // 
            // txtWP
            // 
            this.txtWP.Location = new System.Drawing.Point(19, 210);
            this.txtWP.Name = "txtWP";
            this.txtWP.Size = new System.Drawing.Size(371, 20);
            this.txtWP.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(22, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(371, 20);
            this.txtName.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(371, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(19, 244);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 13);
            this.lbPhone.TabIndex = 15;
            this.lbPhone.Text = "Phone:";
            // 
            // lbWP
            // 
            this.lbWP.AutoSize = true;
            this.lbWP.Location = new System.Drawing.Point(19, 194);
            this.lbWP.Name = "lbWP";
            this.lbWP.Size = new System.Drawing.Size(66, 13);
            this.lbWP.TabIndex = 14;
            this.lbWP.Text = "Work Place:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(19, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Name:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(19, 34);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email:";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(19, 139);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(34, 13);
            this.lbType.TabIndex = 13;
            this.lbType.Text = "Type:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(22, 155);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(374, 21);
            this.cboType.TabIndex = 17;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(22, 293);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(15, 13);
            this.lbid.TabIndex = 22;
            this.lbid.Text = "id";
            this.lbid.Visible = false;
            // 
            // ProfileGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 336);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtWP);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbWP);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEmail);
            this.Name = "ProfileGUI";
            this.Text = "ProfileGUI";
            this.Load += new System.EventHandler(this.ProfileGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtWP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbWP;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lbid;
    }
}