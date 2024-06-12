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
    public partial class AddMemberAchivement : Form
    {

        Member member = new Member();

        public AddMemberAchivement()
        {
            InitializeComponent();
            LoadAchievements();
            LoadMember();

        }

        private void LoadMember()
        {
            List<Member> members = member.GetAllMembers();
            foreach (var member in members)
            {
                cbMembers.Items.Add(new ComboBoxItem { Text = member.Name, Value = member.MemberID });
            }
        }


        private void LoadAchievements()
        {
            Dictionary<int, string> titles = member.GetAchievementTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbAchievements.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedMember = (ComboBoxItem)cbMembers.SelectedItem;
            if (selectedMember == null)
            {
                MessageBox.Show("Vui lòng chọn một thành viên.");
                return;
            }
            int memberID = selectedMember.Value;
            var selectedAchievement = (ComboBoxItem)cbAchievements.SelectedItem;
            if (selectedAchievement == null)
            {
                MessageBox.Show("Vui lòng chọn một thành tích.");
                return;
            }
            int achivementID = selectedAchievement.Value;
            DateTime? eventDate = dateOfEventBox.Value;
            if (eventDate == null)
            {
                MessageBox.Show("Vui lòng chọn ngày sự kiện.");
                return;
            }
            bool result = member.AddAchievement(memberID, achivementID, eventDate);
            if (result)
            {
                MessageBox.Show("Thêm thành tích thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thành tích thất bại!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
