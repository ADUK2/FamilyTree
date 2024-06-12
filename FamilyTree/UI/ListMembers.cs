using FamilyTree.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.UI
{
    public partial class ListMembers : Form
    {
        private Member member = new Member();
        public ListMembers()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void LoadMembers()
        {
            List<Member> members = member.GetAllMembers();

            // Xóa bỏ dữ liệu cũ trước khi tải dữ liệu mới
            dataGridView1.Rows.Clear();

            // Thêm các cột vào DataGridView nếu chưa tồn tại
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("MemberID", "ID");
                dataGridView1.Columns.Add("Name", "Tên");
                dataGridView1.Columns.Add("Gender", "Giới tính");
                dataGridView1.Columns.Add("BirthDate", "Năm sinh");
                dataGridView1.Columns.Add("Address", "Địa chỉ");
            }

            // Thêm dữ liệu mới vào DataGridView
            foreach (Member member in members)
            {
                string formattedDate = member.BirthDate.HasValue ? member.BirthDate.Value.ToString("dd/MM/yyyy") : "";
                // Thêm một hàng mới với dữ liệu tương ứng
                dataGridView1.Rows.Add(member.MemberID,member.Name, member.Gender, formattedDate, member.Address);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Chỉ được chọn 1 thành viên!!!");
                    return;
                }
                int memberId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MemberID"].Value);
                EditMember formEditMember = new EditMember(memberId);
                formEditMember.StartPosition = FormStartPosition.CenterParent;
                formEditMember.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên bạn muốn chỉnh sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<int> selectedMemberIDs = new List<int>();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int memberID = (int)row.Cells["MemberID"].Value;
                    selectedMemberIDs.Add(memberID);
                }
                if (selectedMemberIDs.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa thành viên được chọn?", "Xóa", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Member member = new Member();
                        bool result = member.DeleteMembers(selectedMemberIDs);
                        if (result)
                        {
                            MessageBox.Show("Xóa thành công !!!");
                            LoadMembers();
                        }
                        else
                        {
                            MessageBox.Show("Gặp lỗi khi xóa !!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không có thành viên nào được chọn.");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên bạn muốn xóa.");
            }
        }
    }
}
