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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;

            Account account = new Account();
            bool isAuthenticated = account.Login(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!");
                // Mở form chính hoặc thực hiện các hành động khác sau khi đăng nhập thành công
                this.Hide();
                FirstTimeLogin firstTimeLogin = new FirstTimeLogin();
                firstTimeLogin.Show();
                /*Achievements achievements = new Achievements();
                achievements.Show();*/
                /*EndAcknowledgment endAcknowledgment = new EndAcknowledgment();
                endAcknowledgment.Show();*/
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
