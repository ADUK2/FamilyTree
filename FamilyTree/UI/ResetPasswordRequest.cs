using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.UI
{
    public partial class ResetPasswordRequest : Form
    {
        private Account account = new Account();

        public ResetPasswordRequest()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            
            try
            {
                if (account.GenerateVerificationCode(email))
                {
                    MessageBox.Show("Mã xác thực đã được gửi đến email của bạn!");
                    txtEmail.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Gửi mã xác thực thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string code = txtVerificationCode.Text;
            Account account = new Account();
            bool isValidCode = account.CheckVerificationCode(email, code);
            if (isValidCode)
            {
                MessageBox.Show("Mã xác thực đúng. Bạn có thể đặt mật khẩu mới!");
                DialogResult = DialogResult.OK;
                PasswordUpdateDialog passwordUpdateDialog = new PasswordUpdateDialog(email);
                passwordUpdateDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please check your email and try again.");
            }
        }
    }
}
