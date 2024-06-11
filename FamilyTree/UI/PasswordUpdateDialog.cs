using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.UI
{

    public partial class PasswordUpdateDialog : Form
    {
        private string userEmail;
        private Account account = new Account();
        public PasswordUpdateDialog(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }

            try
            {
                if (account.UpdatePassword(userEmail, newPassword))
                {
                    MessageBox.Show("Mật khẩu đã được cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }

    
}
