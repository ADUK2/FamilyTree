using System.Windows.Forms;

namespace FamilyTree.UI
{
    partial class SearchMembers
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
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGeneration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnFullName,
            this.ColumnBirthDate,
            this.ColumnGeneration,
            this.ColumnParent});
            this.dataGridViewMembers.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.RowHeadersWidth = 51;
            this.dataGridViewMembers.Size = new System.Drawing.Size(562, 400);
            this.dataGridViewMembers.TabIndex = 2;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.HeaderText = "STT";
            this.ColumnSTT.MinimumWidth = 6;
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;
            this.ColumnSTT.Width = 45;
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.HeaderText = "Họ Tên";
            this.ColumnFullName.MinimumWidth = 6;
            this.ColumnFullName.Name = "ColumnFullName";
            this.ColumnFullName.ReadOnly = true;
            this.ColumnFullName.Width = 125;
            // 
            // ColumnBirthDate
            // 
            this.ColumnBirthDate.HeaderText = "Ngày Sinh";
            this.ColumnBirthDate.MinimumWidth = 6;
            this.ColumnBirthDate.Name = "ColumnBirthDate";
            this.ColumnBirthDate.ReadOnly = true;
            this.ColumnBirthDate.Width = 125;
            // 
            // ColumnGeneration
            // 
            this.ColumnGeneration.HeaderText = "Đời";
            this.ColumnGeneration.MinimumWidth = 6;
            this.ColumnGeneration.Name = "ColumnGeneration";
            this.ColumnGeneration.ReadOnly = true;
            this.ColumnGeneration.Width = 45;
            // 
            // ColumnParent
            // 
            this.ColumnParent.HeaderText = "Cha/Mẹ";
            this.ColumnParent.MinimumWidth = 6;
            this.ColumnParent.Name = "ColumnParent";
            this.ColumnParent.ReadOnly = true;
            this.ColumnParent.Width = 170;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thông tin thành viên";
            // 
            // MemberListForm
            // 
            this.ClientSize = new System.Drawing.Size(596, 539);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMembers);
            this.Name = "MemberListForm";
            this.Text = "Danh Sách Thành Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
    }
}