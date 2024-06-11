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
    public partial class SearchMembers : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private DataGridView dataGridViewMembers;
        private DataGridViewTextBoxColumn ColumnSTT;
        private DataGridViewTextBoxColumn ColumnFullName;
        private DataGridViewTextBoxColumn ColumnBirthDate;
        private DataGridViewTextBoxColumn ColumnGeneration;
        private DataGridViewTextBoxColumn ColumnParent;
        private string searchName;
        public SearchMembers(string searchName1)
        {
            this.searchName = searchName1;
            InitializeComponent();
            LoadMembers(searchName);
        }
        private void LoadMembers(string searchName = "")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT m.MemberID, m.FullName, m.BirthDate, m.Generation, " +
                               "CASE WHEN r.RelationshipType = 'Con' THEN p.FullName ELSE 'Không rõ' END AS Parent " +
                               "FROM Members m " +
                               "LEFT JOIN MemberRelationships mr ON m.MemberID = mr.MemberID1 " +
                               "LEFT JOIN Relationships r ON mr.RelationshipID = r.RelationshipID " +
                               "LEFT JOIN Members p ON mr.MemberID2 = p.MemberID " + // LEFT JOIN để lấy tên của cha/mẹ
                               "WHERE m.FullName LIKE @searchName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewMembers.Rows.Clear();
                int stt = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewMembers.Rows.Add(stt, row["FullName"], Convert.ToDateTime(row["BirthDate"]).ToString("dd/MM/yyyy"), row["Generation"], row["Parent"]);
                    stt++;
                }
            }
        }
       
    }
}
