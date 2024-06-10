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
        }

        private void hideSubMenu()
        {
            if (panelSubMember.Visible)
            {
                panelSubMember.Visible = false;
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
            //
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

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
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
    }
}
