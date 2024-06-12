namespace FamilyTree.UI
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.cbOccupations = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHometowns = new System.Windows.Forms.ComboBox();
            this.cbOldmember = new System.Windows.Forms.ComboBox();
            this.lbOldmember = new System.Windows.Forms.Label();
            this.lbRelationships = new System.Windows.Forms.Label();
            this.dateOfEventBox = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfEvent = new System.Windows.Forms.Label();
            this.cbRelationships = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(227, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Thành Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày tháng năm sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Quê quán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nghề nghiệp";
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(27, 123);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(345, 22);
            this.tbFullname.TabIndex = 9;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(427, 123);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(160, 24);
            this.cbGender.TabIndex = 11;
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthBox.Location = new System.Drawing.Point(27, 209);
            this.dateOfBirthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(265, 22);
            this.dateOfBirthBox.TabIndex = 12;
            // 
            // cbOccupations
            // 
            this.cbOccupations.FormattingEnabled = true;
            this.cbOccupations.Location = new System.Drawing.Point(27, 292);
            this.cbOccupations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOccupations.Name = "cbOccupations";
            this.cbOccupations.Size = new System.Drawing.Size(345, 24);
            this.cbOccupations.TabIndex = 16;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(27, 377);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(345, 22);
            this.tbAddress.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ";
            // 
            // cbHometowns
            // 
            this.cbHometowns.FormattingEnabled = true;
            this.cbHometowns.Location = new System.Drawing.Point(427, 209);
            this.cbHometowns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHometowns.Name = "cbHometowns";
            this.cbHometowns.Size = new System.Drawing.Size(281, 24);
            this.cbHometowns.TabIndex = 22;
            // 
            // cbOldmember
            // 
            this.cbOldmember.FormattingEnabled = true;
            this.cbOldmember.Location = new System.Drawing.Point(27, 460);
            this.cbOldmember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOldmember.Name = "cbOldmember";
            this.cbOldmember.Size = new System.Drawing.Size(160, 24);
            this.cbOldmember.TabIndex = 24;
            // 
            // lbOldmember
            // 
            this.lbOldmember.AutoSize = true;
            this.lbOldmember.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldmember.Location = new System.Drawing.Point(27, 423);
            this.lbOldmember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOldmember.Name = "lbOldmember";
            this.lbOldmember.Size = new System.Drawing.Size(155, 29);
            this.lbOldmember.TabIndex = 25;
            this.lbOldmember.Text = "Thành viên cũ";
            // 
            // lbRelationships
            // 
            this.lbRelationships.AutoSize = true;
            this.lbRelationships.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelationships.Location = new System.Drawing.Point(251, 423);
            this.lbRelationships.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRelationships.Name = "lbRelationships";
            this.lbRelationships.Size = new System.Drawing.Size(96, 29);
            this.lbRelationships.TabIndex = 26;
            this.lbRelationships.Text = "Quan hệ";
            // 
            // dateOfEventBox
            // 
            this.dateOfEventBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfEventBox.Location = new System.Drawing.Point(443, 460);
            this.dateOfEventBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOfEventBox.Name = "dateOfEventBox";
            this.dateOfEventBox.Size = new System.Drawing.Size(265, 22);
            this.dateOfEventBox.TabIndex = 27;
            // 
            // lbDateOfEvent
            // 
            this.lbDateOfEvent.AutoSize = true;
            this.lbDateOfEvent.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfEvent.Location = new System.Drawing.Point(443, 423);
            this.lbDateOfEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateOfEvent.Name = "lbDateOfEvent";
            this.lbDateOfEvent.Size = new System.Drawing.Size(144, 29);
            this.lbDateOfEvent.TabIndex = 28;
            this.lbDateOfEvent.Text = "Ngày sự kiện";
            // 
            // cbRelationships
            // 
            this.cbRelationships.FormattingEnabled = true;
            this.cbRelationships.Location = new System.Drawing.Point(251, 460);
            this.cbRelationships.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRelationships.Name = "cbRelationships";
            this.cbRelationships.Size = new System.Drawing.Size(148, 24);
            this.cbRelationships.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Địa chỉ";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.Aqua;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.Aqua;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Hủy";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.IdleLineColor = System.Drawing.Color.Cyan;
            this.btnCancel.Location = new System.Drawing.Point(592, 507);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 48);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Aqua;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Aqua;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.Cyan;
            this.btnSave.Location = new System.Drawing.Point(432, 507);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 48);
            this.btnSave.TabIndex = 30;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 681);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbRelationships);
            this.Controls.Add(this.lbDateOfEvent);
            this.Controls.Add(this.dateOfEventBox);
            this.Controls.Add(this.lbRelationships);
            this.Controls.Add(this.lbOldmember);
            this.Controls.Add(this.cbOldmember);
            this.Controls.Add(this.cbHometowns);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbOccupations);
            this.Controls.Add(this.dateOfBirthBox);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddMember";
            this.Text = "Tiếp nhận thành viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker dateOfBirthBox;
        private System.Windows.Forms.ComboBox cbOccupations;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHometowns;
        private System.Windows.Forms.ComboBox cbOldmember;
        private System.Windows.Forms.Label lbOldmember;
        private System.Windows.Forms.Label lbRelationships;
        private System.Windows.Forms.DateTimePicker dateOfEventBox;
        private System.Windows.Forms.Label lbDateOfEvent;
        private System.Windows.Forms.ComboBox cbRelationships;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
    }
}