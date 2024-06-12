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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYearlyReport));
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.dtpFromYear = new System.Windows.Forms.DateTimePicker();
            this.dtpToYear = new System.Windows.Forms.DateTimePicker();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Báo cáo tăng giảm thành viên",
            "Báo cáo thành tích các thành viên"});
            this.cmbReportType.Location = new System.Drawing.Point(12, 9);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(260, 24);
            this.cmbReportType.TabIndex = 0;
            // 
            // dtpFromYear
            // 
            this.dtpFromYear.CustomFormat = "yyyy";
            this.dtpFromYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromYear.Location = new System.Drawing.Point(12, 39);
            this.dtpFromYear.Name = "dtpFromYear";
            this.dtpFromYear.ShowUpDown = true;
            this.dtpFromYear.Size = new System.Drawing.Size(120, 20);
            this.dtpFromYear.TabIndex = 1;
            // 
            // dtpToYear
            // 
            this.dtpToYear.CustomFormat = "yyyy";
            this.dtpToYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToYear.Location = new System.Drawing.Point(138, 39);
            this.dtpToYear.Name = "dtpToYear";
            this.dtpToYear.ShowUpDown = true;
            this.dtpToYear.Size = new System.Drawing.Size(120, 20);
            this.dtpToYear.TabIndex = 2;
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
            // btnGenerateReport
            // 
            this.btnGenerateReport.ActiveBorderThickness = 1;
            this.btnGenerateReport.ActiveCornerRadius = 20;
            this.btnGenerateReport.ActiveFillColor = System.Drawing.Color.Aqua;
            this.btnGenerateReport.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerateReport.ActiveLineColor = System.Drawing.Color.Aqua;
            this.btnGenerateReport.BackColor = System.Drawing.Color.White;
            this.btnGenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.BackgroundImage")));
            this.btnGenerateReport.ButtonText = "Tạo Báo Cáo";
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.IdleBorderThickness = 1;
            this.btnGenerateReport.IdleCornerRadius = 20;
            this.btnGenerateReport.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGenerateReport.IdleForecolor = System.Drawing.Color.White;
            this.btnGenerateReport.IdleLineColor = System.Drawing.Color.Cyan;
            this.btnGenerateReport.Location = new System.Drawing.Point(14, 63);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(125, 34);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // FormYearlyReport
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvReport);
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
        private System.Windows.Forms.DataGridView dgvReport;

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnGenerateReport;
    }
}