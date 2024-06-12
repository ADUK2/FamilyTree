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
    public partial class AddMemberDeath : Form
    {
        Member member = new Member();
        public AddMemberDeath()
        {
            InitializeComponent();
            LoadMember();
            LoadCauses();
            LoadPlaces();
            
        }

        private void LoadPlaces()
        {
            Dictionary<int, string> titles = member.GetBurialPlaceTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbPlaces.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void LoadCauses()
        {
            Dictionary<int, string> titles = member.GetDeathcausesTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbCauses.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void LoadMember()
        {
            List<Member> members = member.GetAllMembers();
            foreach (var member in members)
            {
                cbMembers.Items.Add(new ComboBoxItem { Text = member.Name, Value = member.MemberID });
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
            var selectedCause = (ComboBoxItem)cbCauses.SelectedItem;
            if (selectedCause == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên nhân cái chết.");
                return;
            }
            int causeID = selectedCause.Value;
            var selectedPlace = (ComboBoxItem)cbPlaces.SelectedItem;
            if (selectedPlace == null)
            {
                MessageBox.Show("Vui lòng chọn nơi mai táng.");
                return;
            }
            int burialPlaceID = selectedPlace.Value;
            DateTime? dieDate = dateOfDieBox.Value;
            if (dieDate == null)
            {
                MessageBox.Show("Vui lòng chọn ngày cái chết.");
                return;
            }
            bool result = member.AddMemberDeath(memberID, dieDate, causeID, burialPlaceID);
            if (result)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
