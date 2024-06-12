using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

       

        private void forgotpassword_Click(object sender, EventArgs e)
        {
            ResetPasswordRequest request = new ResetPasswordRequest();
            request.ShowDialog();
        }

        

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            Account account = new Account();
            bool isAuthenticated = account.Login(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Mở form chính hoặc thực hiện các hành động khác sau khi đăng nhập thành công
                this.Hide();
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
    }
}
