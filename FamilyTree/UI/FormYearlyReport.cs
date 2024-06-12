using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.UI
{
    public partial class FormYearlyReport : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public FormYearlyReport()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int fromYear = dtpFromYear.Value.Year;
            int toYear = dtpToYear.Value.Year;

            string reportType = cmbReportType.SelectedItem?.ToString();

            // Kiểm tra xem đã chọn loại báo cáo hay chưa
            if (string.IsNullOrEmpty(reportType))
            {
                MessageBox.Show("Vui lòng chọn loại báo cáo.");
                return;
            }

            if (fromYear > toYear)
            {
                MessageBox.Show("Năm bắt đầu phải nhỏ hơn hoặc bằng năm kết thúc.");
                return;
            }

            string query = "";

            if (reportType == "Báo cáo tăng giảm thành viên")
            {
                query = @"
                SELECT 
                    Y.Nam,
                    ISNULL(B.SoLuongSinh, 0) AS SoLuongSinh,
                    ISNULL(M.SoLuongKetHon, 0) AS SoLuongKetHon,
                    ISNULL(D.SoLuongMat, 0) AS SoLuongMat
                FROM (
                    SELECT DISTINCT YEAR(BirthDate) AS Nam FROM Members WHERE YEAR(BirthDate) BETWEEN @FromYear AND @ToYear
                    UNION
                    SELECT DISTINCT YEAR(EventDate) AS Nam FROM MemberRelationships WHERE YEAR(EventDate) BETWEEN @FromYear AND @ToYear
                    UNION
                    SELECT DISTINCT YEAR(DeathDate) AS Nam FROM MemberDeaths WHERE YEAR(DeathDate) BETWEEN @FromYear AND @ToYear
                ) Y
                LEFT JOIN (
                    SELECT YEAR(BirthDate) AS Nam, COUNT(*) AS SoLuongSinh
                    FROM Members
                    WHERE YEAR(BirthDate) BETWEEN @FromYear AND @ToYear
                    GROUP BY YEAR(BirthDate)
                ) B ON Y.Nam = B.Nam
                LEFT JOIN (
                    SELECT YEAR(EventDate) AS Nam, COUNT(*) AS SoLuongKetHon
                    FROM MemberRelationships
                    WHERE RelationshipID = (SELECT RelationshipID FROM Relationships WHERE RelationshipType = N'Vợ/Chồng')
                      AND YEAR(EventDate) BETWEEN @FromYear AND @ToYear
                    GROUP BY YEAR(EventDate)
                ) M ON Y.Nam = M.Nam
                LEFT JOIN (
                    SELECT YEAR(DeathDate) AS Nam, COUNT(*) AS SoLuongMat
                    FROM MemberDeaths
                    WHERE YEAR(DeathDate) BETWEEN @FromYear AND @ToYear
                    GROUP BY YEAR(DeathDate)
                ) D ON Y.Nam = D.Nam
                ORDER BY Y.Nam;";
                        }
                        else if (reportType == "Báo cáo thành tích các thành viên")
                        {
                            query = @"
                SELECT 
                    a.AchievementName AS LoaiThanhTich,
                    COUNT(*) AS SoLuong
                FROM MemberAchievements ma
                JOIN Achievements a ON ma.AchievementID = a.AchievementID
                WHERE YEAR(ma.AchievementDate) BETWEEN @FromYear AND @ToYear
                GROUP BY a.AchievementName
                ORDER BY a.AchievementName;";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FromYear", fromYear);
                command.Parameters.AddWithValue("@ToYear", toYear);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvReport.DataSource = dataTable;
            }
        }
    }
}
