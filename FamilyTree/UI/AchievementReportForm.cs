using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FamilyTree.UI
{
    public partial class AchievementReportForm : Form
    {
        private string connectionString = "Data Source=QUANG;Initial Catalog=FamilyTreeDB;Integrated Security=True;Encrypt=False";

        public AchievementReportForm()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            LoadAchievementReport(dateTimePickerFrom.Value, dateTimePickerTo.Value);
        }

        private void LoadAchievementReport(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT a.AchievementName, COUNT(ma.AchievementID) AS AchievementCount " +
                               "FROM Achievements a " +
                               "LEFT JOIN MemberAchievements ma ON a.AchievementID = ma.AchievementID " +
                               "WHERE ma.AchievementDate BETWEEN @fromDate AND @toDate " +
                               "GROUP BY a.AchievementName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewAchievements.Rows.Clear();
                int stt = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewAchievements.Rows.Add(stt, row["AchievementName"], row["AchievementCount"]);
                    stt++;
                }
            }
        }
    }
}
