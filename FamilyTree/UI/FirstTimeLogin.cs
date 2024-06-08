using FamilyTree.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.UI
{
    public partial class FirstTimeLogin : Form
    {
        private Member member = new Member();
        public FirstTimeLogin()
        {
            InitializeComponent();
            LoadHometownsTitles();
            LoadOccupationTitles();
            LoadRelationshipTitles();
            LoadOldMember();

            // Check member
            if (!CheckExistingMembers())
            {
                HideExistingMemberFields();
            }

            // sự kiện checkbox Alive
            checkboxAlive.CheckedChanged += aliveCheckBox_CheckedChanged;
        }

        private void LoadOldMember()
        {
            List<Member> members = member.GetAllMembers();
            foreach(var member in members)
            {
                cbOldmember.Items.Add(new ComboBoxItem { Text = member.Name, Value= member.ID});
            }
        }

        private bool CheckExistingMembers()
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = "Data Source=WIN-124DGHNTBQA;Initial Catalog=FamilyTreeDB;Integrated Security=True";

            // Câu lệnh SQL để đếm số lượng thành viên
            string query = "SELECT COUNT(*) FROM Members";

            try
            {
                // Mở kết nối tới cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thực thi câu lệnh SQL và lấy kết quả
                        int memberCount = (int)command.ExecuteScalar();

                        // Kiểm tra số lượng thành viên
                        if (memberCount > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Error checking existing members: " + ex.Message);
                return false;
            }
        }
        private void HideExistingMemberFields()
        {
            cbOldmember.Visible = false;
            cbRelationships.Visible = false;
            dateOfEventBox.Visible = false;
            lbDateOfEvent.Visible = false;
            lbOldmember.Visible = false;
            lbRelationships.Visible = false;
        }

        private void LoadHometownsTitles()
        {
            
            Dictionary<int, string> titles = member.GetDeathcausesTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbHometowns.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void LoadOccupationTitles()
        {
            Dictionary<int, string> titles = member.GetOccupationsTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbOccupations.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void LoadRelationshipTitles()
        {
            Dictionary<int, string> titles = member.GetRelationshipsTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbOccupations.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var oldmember = (ComboBoxItem)cbOldmember.SelectedItem;
            int id = oldmember.Value;
            MessageBox.Show("ID Old Member:" + id);
        }

        private void aliveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateOfDeathBox.Visible = !checkboxAlive.Checked;
        }
    }
}
