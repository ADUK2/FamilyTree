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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            customizeDesing();

        }

        private void customizeDesing()
        {
            panelSubMember.Visible = false;
            panelSubMemberDeaths.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMember.Visible)
            {
                panelSubMember.Visible = false;
            }
            if (panelSubMemberDeaths.Visible)
            {
                panelSubMemberDeaths.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if(!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMember);
        }

        private void btnListMembers_Click(object sender, EventArgs e)
        {
            openChildForm(new ListMembers());
            hideSubMenu();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            openChildForm(new AddMember());
            hideSubMenu();
        }

        

        private void btnAddMemberAchivement_Click(object sender, EventArgs e)
        {
            openChildForm(new AddMemberAchivement());
            hideSubMenu();
        }

        private void btnAddMemberDeath_Click(object sender, EventArgs e)
        {
            openChildForm(new AddMemberDeath());
            hideSubMenu();
        }

        private void btnYearlyReport_Click(object sender, EventArgs e)
        {
            openChildForm(new FormYearlyReport());
            hideSubMenu();
        }

        private void btnMemberDeath_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMemberDeaths);
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            panelChildForm.BringToFront();
            childForm.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchName = tbSearch.Text;
            openChildForm(new SearchMembers(searchName));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = tbSearch.Text;
            openChildForm(new SearchMembers(searchName));
        }

        private void btnListMemberDeath_Click(object sender, EventArgs e)
        {
            openChildForm(new ListMemberDeaths());
            hideSubMenu();
        }
    }
}
