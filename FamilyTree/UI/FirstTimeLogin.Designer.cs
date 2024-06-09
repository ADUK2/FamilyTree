namespace FamilyTree.UI
{
    partial class FirstTimeLogin
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
            this.cancelFormButton = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHometowns = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbOldmember = new System.Windows.Forms.ComboBox();
            this.lbOldmember = new System.Windows.Forms.Label();
            this.lbRelationships = new System.Windows.Forms.Label();
            this.dateOfEventBox = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfEvent = new System.Windows.Forms.Label();
            this.cbRelationships = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(382, -51);
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
            this.label2.Location = new System.Drawing.Point(119, 133);
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
            this.label4.Location = new System.Drawing.Point(737, 133);
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
            this.label6.Location = new System.Drawing.Point(119, 255);
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
            this.label7.Location = new System.Drawing.Point(119, 342);
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
            this.label8.Location = new System.Drawing.Point(119, 428);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nghề nghiệp";
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(124, 182);
            this.tbFullname.Margin = new System.Windows.Forms.Padding(4);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(279, 22);
            this.tbFullname.TabIndex = 9;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGender.Location = new System.Drawing.Point(743, 180);
            this.cbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(160, 24);
            this.cbGender.TabIndex = 11;
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthBox.Location = new System.Drawing.Point(124, 300);
            this.dateOfBirthBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(240, 22);
            this.dateOfBirthBox.TabIndex = 12;
            // 
            // cbOccupations
            // 
            this.cbOccupations.FormattingEnabled = true;
            this.cbOccupations.Location = new System.Drawing.Point(124, 482);
            this.cbOccupations.Margin = new System.Windows.Forms.Padding(4);
            this.cbOccupations.Name = "cbOccupations";
            this.cbOccupations.Size = new System.Drawing.Size(279, 24);
            this.cbOccupations.TabIndex = 16;
            // 
            // cancelFormButton
            // 
            this.cancelFormButton.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelFormButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelFormButton.Location = new System.Drawing.Point(947, 763);
            this.cancelFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelFormButton.Name = "cancelFormButton";
            this.cancelFormButton.Size = new System.Drawing.Size(129, 49);
            this.cancelFormButton.TabIndex = 19;
            this.cancelFormButton.Text = "Hủy";
            this.cancelFormButton.UseVisualStyleBackColor = true;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(124, 573);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(949, 22);
            this.tbAddress.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 529);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa chỉ";
            // 
            // cbHometowns
            // 
            this.cbHometowns.FormattingEnabled = true;
            this.cbHometowns.Location = new System.Drawing.Point(124, 385);
            this.cbHometowns.Margin = new System.Windows.Forms.Padding(4);
            this.cbHometowns.Name = "cbHometowns";
            this.cbHometowns.Size = new System.Drawing.Size(279, 24);
            this.cbHometowns.TabIndex = 22;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aqua;
            this.btn_Save.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(742, 764);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 48);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbOldmember
            // 
            this.cbOldmember.FormattingEnabled = true;
            this.cbOldmember.Location = new System.Drawing.Point(124, 687);
            this.cbOldmember.Margin = new System.Windows.Forms.Padding(4);
            this.cbOldmember.Name = "cbOldmember";
            this.cbOldmember.Size = new System.Drawing.Size(279, 24);
            this.cbOldmember.TabIndex = 25;
            // 
            // lbOldmember
            // 
            this.lbOldmember.AutoSize = true;
            this.lbOldmember.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldmember.Location = new System.Drawing.Point(119, 639);
            this.lbOldmember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOldmember.Name = "lbOldmember";
            this.lbOldmember.Size = new System.Drawing.Size(155, 29);
            this.lbOldmember.TabIndex = 24;
            this.lbOldmember.Text = "Thành viên cũ";
            // 
            // lbRelationships
            // 
            this.lbRelationships.AutoSize = true;
            this.lbRelationships.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelationships.Location = new System.Drawing.Point(527, 639);
            this.lbRelationships.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRelationships.Name = "lbRelationships";
            this.lbRelationships.Size = new System.Drawing.Size(137, 29);
            this.lbRelationships.TabIndex = 26;
            this.lbRelationships.Text = "Mối quan hệ";
            // 
            // dateOfEventBox
            //
            this.dateOfEventBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfEventBox.Location = new System.Drawing.Point(780, 689);
            this.dateOfEventBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfEventBox.Name = "dateOfEventBox";
            this.dateOfEventBox.Size = new System.Drawing.Size(240, 22);
            this.dateOfEventBox.TabIndex = 29;
            // 
            // lbDateOfEvent
            // 
            this.lbDateOfEvent.AutoSize = true;
            this.lbDateOfEvent.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfEvent.Location = new System.Drawing.Point(784, 639);
            this.lbDateOfEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateOfEvent.Name = "lbDateOfEvent";
            this.lbDateOfEvent.Size = new System.Drawing.Size(166, 29);
            this.lbDateOfEvent.TabIndex = 28;
            this.lbDateOfEvent.Text = "Ngày phát sinh";
            // 
            // cbRelationships
            // 
            this.cbRelationships.FormattingEnabled = true;
            this.cbRelationships.Location = new System.Drawing.Point(532, 687);
            this.cbRelationships.Name = "cbRelationships";
            this.cbRelationships.Size = new System.Drawing.Size(121, 24);
            this.cbRelationships.TabIndex = 30;
            // 
            // FirstTimeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 843);
            this.Controls.Add(this.cbRelationships);
            this.Controls.Add(this.dateOfEventBox);
            this.Controls.Add(this.lbDateOfEvent);
            this.Controls.Add(this.lbRelationships);
            this.Controls.Add(this.cbOldmember);
            this.Controls.Add(this.lbOldmember);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cbHometowns);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelFormButton);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirstTimeLogin";
            this.Text = "FirstTimeLogin";
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
        private System.Windows.Forms.Button cancelFormButton;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHometowns;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbOldmember;
        private System.Windows.Forms.Label lbOldmember;
        private System.Windows.Forms.Label lbRelationships;
        private System.Windows.Forms.DateTimePicker dateOfEventBox;
        private System.Windows.Forms.Label lbDateOfEvent;
        private System.Windows.Forms.ComboBox cbRelationships;
    }
}