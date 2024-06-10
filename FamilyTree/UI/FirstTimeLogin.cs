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
            LoadRelationshipsTitles();

            // Check member
            if (!CheckExistingMembers())
            {
                HideExistingMemberFields();
            }
        }

        private void LoadOldMember()
        {
            List<Member> members = member.GetRootMembers();
            cbOldmember.Items.Clear();
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
            
            Dictionary<int, string> titles = member.GetHometownsTitles();
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

        private void LoadRelationshipsTitles()
        {
            Dictionary<int, string> titles = member.GetRelationshipsTitles();
            foreach ( var title in titles)
            {
                cbRelationships.Items.Add(new ComboBoxItem { Text = title.Value, Value=title.Key });
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

            if (!CheckExistingMembers())
            {
                // Lấy thông tin từ các điều khiển
                string fullName = tbFullname.Text;
                string gender = cbGender.SelectedItem?.ToString();
                DateTime birthDate = dateOfBirthBox.Value;
                string address = tbAddress.Text;
                var selectedHometown = (ComboBoxItem)cbHometowns.SelectedItem;
                int hometownID = selectedHometown.Value;
                var selectedOccupation = (ComboBoxItem)cbOccupations.SelectedItem;
                int occupationID = selectedOccupation.Value;

                // Kiểm tra các thông tin bắt buộc
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) || hometownID == 0 || occupationID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Xác định giá trị isRoot và Generation
                bool isRoot = true;
                int generation = 1; // Đời 1 nếu không có thành viên nào tồn tại

                // Tạo đối tượng Member và thêm vào cơ sở dữ liệu
                Member member = new Member();
                int newMemberID = member.AddMember(fullName, gender, birthDate, address, occupationID, hometownID, isRoot, generation);

                if (newMemberID > 0)
                {
                    MessageBox.Show("Member added successfully!");
                    LoadOldMember(); // Tải lại danh sách thành viên cũ có isRoot = 1
                }
                else
                {
                    MessageBox.Show("Failed to add member.");
                }
            }
            else
            {
                // Lấy thông tin từ các điều khiển
                string fullName = tbFullname.Text;
                string gender = cbGender.SelectedItem?.ToString();
                DateTime birthDate = dateOfBirthBox.Value;
                string address = tbAddress.Text;
                var selectedHometown = (ComboBoxItem)cbHometowns.SelectedItem;
                int hometownID = selectedHometown.Value;
                var selectedOccupation = (ComboBoxItem)cbOccupations.SelectedItem;
                int occupationID = selectedOccupation.Value;
                var selectedOldmember = (ComboBoxItem)cbOldmember.SelectedItem;
                int oldMemberID = selectedOldmember.Value;
                var selectedRelationship = (ComboBoxItem)cbRelationships.SelectedItem;
                int relationshipTypeID = selectedRelationship.Value;
                DateTime eventDate = dateOfEventBox.Value;

                Member member = new Member();

                // Kiểm tra các thông tin bắt buộc
                if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(gender) || hometownID == 0 || occupationID == 0)
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Xác định giá trị isRoot
                bool isRoot = (relationshipTypeID == 1); // Giả sử relationshipTypeID = 1 đại diện cho quan hệ "con"

                // Xác định giá trị Generation
                int oldMemberGeneration = member.GetMemberGeneration(oldMemberID);
                int generation = (relationshipTypeID == 1) ? oldMemberGeneration + 1 : oldMemberGeneration;

                // Tạo đối tượng Member và thêm vào cơ sở dữ liệu
                
                int newMemberID = member.AddMember(fullName, gender, birthDate, address, occupationID, hometownID, isRoot, generation);

                // Nếu thêm thành công, thêm mối quan hệ
                if (newMemberID > 0)
                {
                    member.AddRelationship(newMemberID, oldMemberID, relationshipTypeID, eventDate);

                    MessageBox.Show("Member added successfully!");
                    LoadOldMember(); // Tải lại danh sách thành viên cũ có isRoot = 1
                }
                else
                {
                    MessageBox.Show("Failed to add member.");
                }
            }

        }

        
    }
}
