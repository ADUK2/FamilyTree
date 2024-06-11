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
    public partial class EditMemberDeath : Form
    {
        private Member member = new Member();
        private int memberDeathId;
        private string name;
        private int causeID;
        private int placeID;
        public EditMemberDeath(int memberDeathId, string name)
        {
            InitializeComponent();
            this.memberDeathId = memberDeathId;
            this.name = name;
            LoadMemberDeathData(memberDeathId);
            LoadCauseDeaths();
            LoadPlaces();
            lbName.Text = name;
        }

        private void LoadMemberDeathData(int memberDeathId)
        {
            Tuple<int, int> info = member.LoadMemberDeaths(memberDeathId);
            causeID = info.Item1;
            placeID = info.Item2;
        }

        private void LoadCauseDeaths()
        {
            Dictionary<int, string> titles = member.GetDeathcausesTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbCauses.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }

            foreach (ComboBoxItem item in cbCauses.Items)
            {
                if ((int)item.Value == causeID)
                {
                    cbCauses.SelectedItem = item;
                    break;
                }
            }
        }

        private void LoadPlaces()
        {
            Dictionary<int, string> titles = member.GetBurialPlaceTitles();
            foreach (var title in titles)
            {
                // Thêm một mục mới vào ComboBox với giá trị ID và tiêu đề tương ứng
                cbPlaces.Items.Add(new ComboBoxItem { Text = title.Value, Value = title.Key });
            }

            foreach (ComboBoxItem item in cbPlaces.Items)
            {
                if ((int)item.Value == placeID)
                {
                    cbPlaces.SelectedItem = item;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedCause = (ComboBoxItem)cbCauses.SelectedItem;
            int causeID = selectedCause.Value;
            var selectedPlace = (ComboBoxItem)cbPlaces.SelectedItem;
            int placeID = selectedPlace.Value;
            bool result = member.UpdateMemberDeath(memberDeathId, causeID, placeID);
            if(result)
            {
                MessageBox.Show("Cật nhật thành công");
            }
            else
            {
                MessageBox.Show("Cật nhật thất bại");                
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
