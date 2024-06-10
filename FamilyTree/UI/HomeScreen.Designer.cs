namespace FamilyTree.UI
{
    partial class HomeScreen
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSubMember = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnListMembers = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnAddMemberAchivement = new System.Windows.Forms.Button();
            this.btnAddMemberDeath = new System.Windows.Forms.Button();
            this.btnYearlyReport = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelSubMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.panelSideMenu.Controls.Add(this.btnYearlyReport);
            this.panelSideMenu.Controls.Add(this.btnAddMemberDeath);
            this.panelSideMenu.Controls.Add(this.btnAddMemberAchivement);
            this.panelSideMenu.Controls.Add(this.panelSubMember);
            this.panelSideMenu.Controls.Add(this.btnMembers);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 603);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelSubMember
            // 
            this.panelSubMember.BackColor = System.Drawing.Color.LightGreen;
            this.panelSubMember.Controls.Add(this.btnAddMember);
            this.panelSubMember.Controls.Add(this.btnListMembers);
            this.panelSubMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMember.Location = new System.Drawing.Point(0, 145);
            this.panelSubMember.Name = "panelSubMember";
            this.panelSubMember.Size = new System.Drawing.Size(250, 80);
            this.panelSubMember.TabIndex = 1;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnAddMember.Location = new System.Drawing.Point(0, 40);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddMember.Size = new System.Drawing.Size(250, 40);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Tiếp nhận thành viên";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnListMembers
            // 
            this.btnListMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnListMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMembers.FlatAppearance.BorderSize = 0;
            this.btnListMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnListMembers.Location = new System.Drawing.Point(0, 0);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListMembers.Size = new System.Drawing.Size(250, 40);
            this.btnListMembers.TabIndex = 0;
            this.btnListMembers.Text = "Danh sách thành viên";
            this.btnListMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMembers.UseVisualStyleBackColor = false;
            this.btnListMembers.Click += new System.EventHandler(this.btnListMembers_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnMembers.Location = new System.Drawing.Point(0, 100);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(250, 45);
            this.btnMembers.TabIndex = 0;
            this.btnMembers.Text = "Thành viên";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(782, 603);
            this.panelChildForm.TabIndex = 1;
            // 
            // btnAddMemberAchivement
            // 
            this.btnAddMemberAchivement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMemberAchivement.FlatAppearance.BorderSize = 0;
            this.btnAddMemberAchivement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMemberAchivement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnAddMemberAchivement.Location = new System.Drawing.Point(0, 225);
            this.btnAddMemberAchivement.Name = "btnAddMemberAchivement";
            this.btnAddMemberAchivement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddMemberAchivement.Size = new System.Drawing.Size(250, 45);
            this.btnAddMemberAchivement.TabIndex = 3;
            this.btnAddMemberAchivement.Text = "Ghi nhận thành tích";
            this.btnAddMemberAchivement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMemberAchivement.UseVisualStyleBackColor = true;
            this.btnAddMemberAchivement.Click += new System.EventHandler(this.btnAddMemberAchivement_Click);
            // 
            // btnAddMemberDeath
            // 
            this.btnAddMemberDeath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMemberDeath.FlatAppearance.BorderSize = 0;
            this.btnAddMemberDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMemberDeath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnAddMemberDeath.Location = new System.Drawing.Point(0, 270);
            this.btnAddMemberDeath.Name = "btnAddMemberDeath";
            this.btnAddMemberDeath.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddMemberDeath.Size = new System.Drawing.Size(250, 45);
            this.btnAddMemberDeath.TabIndex = 6;
            this.btnAddMemberDeath.Text = "Ghi nhận kết thúc";
            this.btnAddMemberDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMemberDeath.UseVisualStyleBackColor = true;
            this.btnAddMemberDeath.Click += new System.EventHandler(this.btnAddMemberDeath_Click);
            // 
            // btnYearlyReport
            // 
            this.btnYearlyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearlyReport.FlatAppearance.BorderSize = 0;
            this.btnYearlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnYearlyReport.Location = new System.Drawing.Point(0, 315);
            this.btnYearlyReport.Name = "btnYearlyReport";
            this.btnYearlyReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnYearlyReport.Size = new System.Drawing.Size(250, 45);
            this.btnYearlyReport.TabIndex = 7;
            this.btnYearlyReport.Text = "Báo cáo năm";
            this.btnYearlyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearlyReport.UseVisualStyleBackColor = true;
            this.btnYearlyReport.Click += new System.EventHandler(this.btnYearlyReport_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSubMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSubMember;
        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnAddMemberAchivement;
        private System.Windows.Forms.Button btnAddMemberDeath;
        private System.Windows.Forms.Button btnYearlyReport;
    }
}