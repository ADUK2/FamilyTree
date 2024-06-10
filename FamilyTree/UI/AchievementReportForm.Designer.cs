using System.Windows.Forms;

namespace FamilyTree.UI
{
    partial class AchievementReportForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewAchievements;
        private DataGridViewTextBoxColumn ColumnSTT;
        private DataGridViewTextBoxColumn ColumnAchievementType;
        private DataGridViewTextBoxColumn ColumnAchievementCount;
        private Label labelFrom;
        private Label labelTo;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Button buttonGenerate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewAchievements = new System.Windows.Forms.DataGridView();
            this.ColumnSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAchievementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAchievementCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchievements)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAchievements
            // 
            this.dataGridViewAchievements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAchievements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSTT,
            this.ColumnAchievementType,
            this.ColumnAchievementCount});
            this.dataGridViewAchievements.Location = new System.Drawing.Point(15, 69);
            this.dataGridViewAchievements.Name = "dataGridViewAchievements";
            this.dataGridViewAchievements.RowHeadersWidth = 51;
            this.dataGridViewAchievements.Size = new System.Drawing.Size(460, 280);
            this.dataGridViewAchievements.TabIndex = 0;
            // 
            // ColumnSTT
            // 
            this.ColumnSTT.HeaderText = "STT";
            this.ColumnSTT.MinimumWidth = 6;
            this.ColumnSTT.Name = "ColumnSTT";
            this.ColumnSTT.ReadOnly = true;
            this.ColumnSTT.Width = 125;
            // 
            // ColumnAchievementType
            // 
            this.ColumnAchievementType.HeaderText = "Loại Thành Tích";
            this.ColumnAchievementType.MinimumWidth = 6;
            this.ColumnAchievementType.Name = "ColumnAchievementType";
            this.ColumnAchievementType.ReadOnly = true;
            this.ColumnAchievementType.Width = 200;
            // 
            // ColumnAchievementCount
            // 
            this.ColumnAchievementCount.HeaderText = "Số Lượng";
            this.ColumnAchievementCount.MinimumWidth = 6;
            this.ColumnAchievementCount.Name = "ColumnAchievementCount";
            this.ColumnAchievementCount.ReadOnly = true;
            this.ColumnAchievementCount.Width = 125;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 15);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(55, 16);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "Từ năm:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(220, 15);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(63, 16);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "Đến năm:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(70, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.ShowUpDown = true;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(280, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.ShowUpDown = true;
            this.dateTimePickerTo.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(420, 10);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // AchievementReportForm
            // 
            this.ClientSize = new System.Drawing.Size(504, 361);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dataGridViewAchievements);
            this.Name = "AchievementReportForm";
            this.Text = "Achievement Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchievements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}
