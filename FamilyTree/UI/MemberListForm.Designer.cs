using System.Windows.Forms;

namespace FamilyTree.UI
{
    partial class MemberListForm
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
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();

            // Khởi tạo textBoxSearch
            this.textBoxSearch.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 20);
            this.textBoxSearch.TabIndex = 0;

            // Khởi tạo buttonSearch
            this.buttonSearch.Location = new System.Drawing.Point(268, 10);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);

            // Khởi tạo dataGridViewMembers
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.ColumnSTT,
        this.ColumnFullName,
        this.ColumnBirthDate,
        this.ColumnGeneration,
        this.ColumnParent});
            this.dataGridViewMembers.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.Size = new System.Drawing.Size(776, 388);
            this.dataGridViewMembers.TabIndex = 2;

            // Khai báo và khởi tạo cột STT
            this.ColumnSTT.HeaderText = "STT";
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;

            // Khai báo và khởi tạo cột Họ Tên
            this.ColumnFullName.HeaderText = "Họ Tên";
            this.ColumnFullName.Name = "ColumnFullName";
            this.ColumnFullName.ReadOnly = true;

            // Khai báo và khởi tạo cột Ngày Sinh
            this.ColumnBirthDate.HeaderText = "Ngày Sinh";
            this.ColumnBirthDate.Name = "ColumnBirthDate";
            this.ColumnBirthDate.ReadOnly = true;

            // Khai báo và khởi tạo cột Đời
            this.ColumnGeneration.HeaderText = "Đời";
            this.ColumnGeneration.Name = "ColumnGeneration";
            this.ColumnGeneration.ReadOnly = true;

            // Khai báo và khởi tạo cột Cha/Mẹ
            this.ColumnParent.HeaderText = "Cha/Mẹ";
            this.ColumnParent.Name = "ColumnParent";
            this.ColumnParent.ReadOnly = true;

            // Khởi tạo form
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMembers);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Name = "MemberListForm";
            this.Text = "Danh Sách Thành Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }        
        #endregion
    }
}