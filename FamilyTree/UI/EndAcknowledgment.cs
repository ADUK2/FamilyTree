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
    public partial class EndAcknowledgment : Form
    {
        Member member = new Member();
        public EndAcknowledgment()
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
                cbMembers.Items.Add(new ComboBoxItem { Text = member.Name, Value = member.ID });
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var selectedMember = (ComboBoxItem)cbMembers.SelectedItem;
            int memberID = selectedMember.Value;
            var selectedCause = (ComboBoxItem)cbCauses.SelectedItem;
            int causeID = selectedCause.Value;
            var selectedPlace = (ComboBoxItem)cbPlaces.SelectedItem;
            int burialPlaceID = selectedPlace.Value;
            DateTime selectedDate = dateOfDieBox.Value;
            DateTime deathDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day);
            /*bool result = member.AddMemberDeath(memberID, deathDate, causeID, burialPlaceID);
            if (result)
            {
                MessageBox.Show("Member death added successfully!");
            }
            else
            {
                MessageBox.Show("Failed to add member death.");
            }*/
            MessageBox.Show("Death Date:" + deathDate);
        }
    }
}
