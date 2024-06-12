using FamilyTree.Classes;
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
    public partial class ListMemberDeaths : Form
    {
        private Member member = new Member();
        public ListMemberDeaths()
        {
            InitializeComponent();
            
        }

        private void ListMemberDeaths_Load(object sender, EventArgs e)
        {
            // Tự động tải dữ liệu khi form được khởi động
            LoadMemberDeaths();
        }

        private void LoadMemberDeaths()
        {
        // Chuỗi kết nối tới cơ sở dữ liệu của bạn
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


        // Câu lệnh SQL để lấy dữ liệu
        string query = @"
        SELECT 
            MemberDeaths.MemberDeathID,
            Members.FullName,
            MemberDeaths.DeathDate,
            DeathCauses.CauseName,
            BurialPlaces.PlaceName
        FROM 
            MemberDeaths
        JOIN 
            Members ON MemberDeaths.MemberID = Members.MemberID
        JOIN 
            DeathCauses ON MemberDeaths.CauseID = DeathCauses.CauseID
        JOIN 
            BurialPlaces ON MemberDeaths.BurialPlaceID = BurialPlaces.PlaceID;
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Gán dữ liệu vào DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Thiết lập tiêu đề cột cho DataGridView
                    dataGridView1.Columns[0].HeaderText = "ID";
                    dataGridView1.Columns[1].HeaderText = "Họ tên";
                    dataGridView1.Columns[2].HeaderText = "Ngày mất";
                    dataGridView1.Columns[3].HeaderText = "Nguyên nhân";
                    dataGridView1.Columns[4].HeaderText = "Nơi mai táng";


                    // Cấu hình kích thước cột
                    dataGridView1.Columns[0].Width = 40; // ID
                    dataGridView1.Columns[1].Width = 100; // Họ tên
                    dataGridView1.Columns[2].Width = 80; // Ngày mất
                    dataGridView1.Columns[3].Width = 120; // Nguyên nhân
                    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Nơi mai táng
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Chỉ được chọn 1 kết thúc!!!");
                    return;
                }
                int memberDeathId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberDeathID"].Value);
                string name = dataGridView1.SelectedRows[0].Cells["FullName"].Value.ToString();
                EditMemberDeath formEditMemberDeath = new EditMemberDeath(memberDeathId, name);
                formEditMemberDeath.StartPosition = FormStartPosition.CenterParent;
                formEditMemberDeath.ShowDialog(this);
                LoadMemberDeaths();
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên bạn muốn chỉnh sửa.");
            }
            
        }
    }
}
