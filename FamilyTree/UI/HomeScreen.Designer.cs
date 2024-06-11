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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMembers = new System.Windows.Forms.Button();
            this.panelSubMember = new System.Windows.Forms.Panel();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnListMembers = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnAddMemberAchivement = new System.Windows.Forms.Button();
            this.btnAddMemberDeath = new System.Windows.Forms.Button();
            this.btnYearlyReport = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 603);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 23);
            this.panel1.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(175, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 22);
            this.tbSearch.TabIndex = 8;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnMembers.Location = new System.Drawing.Point(0, 123);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(250, 45);
            this.btnMembers.TabIndex = 10;
            this.btnMembers.Text = "Thành viên";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = true;
            // 
            // panelSubMember
            // 
            this.panelSubMember.BackColor = System.Drawing.Color.LightGreen;
            this.panelSubMember.Controls.Add(this.btnAddMember);
            this.panelSubMember.Controls.Add(this.btnListMembers);
            this.panelSubMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMember.Location = new System.Drawing.Point(0, 168);
            this.panelSubMember.Name = "panelSubMember";
            this.panelSubMember.Size = new System.Drawing.Size(250, 80);
            this.panelSubMember.TabIndex = 11;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnAddMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMember.FlatAppearance.BorderSize = 0;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnAddMember.Location = new System.Drawing.Point(0, 40);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddMember.Size = new System.Drawing.Size(250, 40);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Tiếp nhận thành viên";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.UseVisualStyleBackColor = false;
            // 
            // btnListMembers
            // 
            this.btnListMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(95)))), ((int)(((byte)(45)))));
            this.btnListMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMembers.FlatAppearance.BorderSize = 0;
            this.btnListMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnListMembers.Location = new System.Drawing.Point(0, 0);
            this.btnListMembers.Name = "btnListMembers";
            this.btnListMembers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListMembers.Size = new System.Drawing.Size(250, 40);
            this.btnListMembers.TabIndex = 3;
            this.btnListMembers.Text = "Danh sách thành viên";
            this.btnListMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMembers.UseVisualStyleBackColor = false;
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
            this.btnAddMemberAchivement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMemberAchivement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnAddMemberAchivement.Location = new System.Drawing.Point(0, 248);
            this.btnAddMemberAchivement.Name = "btnAddMemberAchivement";
            this.btnAddMemberAchivement.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddMemberAchivement.Size = new System.Drawing.Size(250, 45);
            this.btnAddMemberAchivement.TabIndex = 12;
            this.btnAddMemberAchivement.Text = "Ghi nhận thành tích";
            this.btnAddMemberAchivement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMemberAchivement.UseVisualStyleBackColor = true;
            // 
            // btnAddMemberDeath
            // 
            this.btnAddMemberDeath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMemberDeath.FlatAppearance.BorderSize = 0;
            this.btnAddMemberDeath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMemberDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMemberDeath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnAddMemberDeath.Location = new System.Drawing.Point(0, 293);
            this.btnAddMemberDeath.Name = "btnAddMemberDeath";
            this.btnAddMemberDeath.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddMemberDeath.Size = new System.Drawing.Size(250, 45);
            this.btnAddMemberDeath.TabIndex = 13;
            this.btnAddMemberDeath.Text = "Ghi nhận kết thúc";
            this.btnAddMemberDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMemberDeath.UseVisualStyleBackColor = true;
            // 
            // btnYearlyReport
            // 
            this.btnYearlyReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearlyReport.FlatAppearance.BorderSize = 0;
            this.btnYearlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlyReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(74)))));
            this.btnYearlyReport.Location = new System.Drawing.Point(0, 338);
            this.btnYearlyReport.Name = "btnYearlyReport";
            this.btnYearlyReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnYearlyReport.Size = new System.Drawing.Size(250, 45);
            this.btnYearlyReport.TabIndex = 14;
            this.btnYearlyReport.Text = "Báo cáo năm";
            this.btnYearlyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearlyReport.UseVisualStyleBackColor = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSubMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnYearlyReport;
        private System.Windows.Forms.Button btnAddMemberDeath;
        private System.Windows.Forms.Button btnAddMemberAchivement;
        private System.Windows.Forms.Panel panelSubMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnListMembers;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Panel panelChildForm;
    }
}