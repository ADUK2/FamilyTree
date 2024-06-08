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
    public partial class Achievements : Form
    {

        Member member = new Member();

        public Achievements()
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
                cbMembers.Items.Add(new ComboBoxItem { Text = member.Name, Value = member.ID });
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


        private void btn_Save_Click(object sender, EventArgs e)
        {
            var selectedAchievement = (ComboBoxItem)cbAchievements.SelectedItem;
            int achievementsID = selectedAchievement.Value;
            MessageBox.Show("Selected Achievement ID: " + achievementsID);
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
