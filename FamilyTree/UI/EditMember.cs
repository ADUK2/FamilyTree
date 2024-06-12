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
    public partial class EditMember : Form
    {
        private Member member= new Member();
        private int memberId;
        public EditMember(int  memberId)
        {
            this.memberId = memberId;
            InitializeComponent();
            LoadMemberData(memberId);
            LoadHometowns();
            LoadOccupations();
            // Load giá trị của combobox Hometowns từ HometownID của member
            foreach (ComboBoxItem item in cbHometowns.Items)
            {
                if ((int)item.Value == member.HometownID)
                {
                    cbHometowns.SelectedItem = item;
                    break;
                }
            }

            // Load giá trị của combobox Occupations từ OccupationID của member
            foreach (ComboBoxItem item in cbOccupations.Items)
            {
                if ((int)item.Value == member.OccupationID)
                {
                    cbOccupations.SelectedItem = item;
                    break;
                }
            }
        }

        private void LoadOccupations()
        {
            Dictionary<int, string> titles = member.GetOccupationsTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbOccupations.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void LoadHometowns()
        {
            Dictionary<int, string> titles = member.GetHometownsTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbHometowns.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }
        }

        private void LoadMemberData(int id)
        {
            member = member.LoadMember(id);
            lbName.Text = member.Name;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedHometown = (ComboBoxItem)cbHometowns.SelectedItem;
            int hometownID = selectedHometown.Value;
            var selectedOccupation = (ComboBoxItem)cbOccupations.SelectedItem;
            int OccupationID = selectedOccupation.Value;
            member.HometownID = hometownID;
            member.OccupationID = OccupationID;
            bool result = member.UpdateMember(member);
            if (result)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
