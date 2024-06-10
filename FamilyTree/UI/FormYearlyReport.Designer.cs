namespace FamilyTree.UI
{
    partial class FormYearlyReport
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
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.dtpFromYear = new System.Windows.Forms.DateTimePicker();
            this.dtpToYear = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Báo cáo tăng giảm thành viên",
            "Báo cáo thành tích các thành viên"});
            this.cmbReportType.Location = new System.Drawing.Point(12, 12);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(260, 24);
            this.cmbReportType.TabIndex = 0;
            // 
            // dtpFromYear
            // 
            this.dtpFromYear.CustomFormat = "yyyy";
            this.dtpFromYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromYear.Location = new System.Drawing.Point(12, 42);
            this.dtpFromYear.Name = "dtpFromYear";
            this.dtpFromYear.ShowUpDown = true;
            this.dtpFromYear.Size = new System.Drawing.Size(120, 22);
            this.dtpFromYear.TabIndex = 1;
            // 
            // dtpToYear
            // 
            this.dtpToYear.CustomFormat = "yyyy";
            this.dtpToYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToYear.Location = new System.Drawing.Point(138, 42);
            this.dtpToYear.Name = "dtpToYear";
            this.dtpToYear.ShowUpDown = true;
            this.dtpToYear.Size = new System.Drawing.Size(120, 22);
            this.dtpToYear.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(12, 70);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(246, 23);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "Tạo Báo Cáo";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(12, 99);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(558, 339);
            this.dgvReport.TabIndex = 4;
            // 
            // FormYearlyReport
            // 
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpToYear);
            this.Controls.Add(this.dtpFromYear);
            this.Controls.Add(this.cmbReportType);
            this.Name = "FormYearlyReport";
            this.Text = "Yearly Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.DateTimePicker dtpFromYear;
        private System.Windows.Forms.DateTimePicker dtpToYear;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReport;

        #endregion
    }
}