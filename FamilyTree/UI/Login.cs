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
<<<<<<< HEAD
            tbPassword.TextChanged += bunifuTextBoxPassword_TextChange;
=======
>>>>>>> 0a9e27d (Logic, UI Register Form)
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void bunifuThinButtonLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            Account account = new Account();
            bool isAuthenticated = account.Login(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!");
                // Mở form chính hoặc thực hiện các hành động khác sau khi đăng nhập thành công
                this.Hide();
                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void forgotpassword_Click(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void bunifuTextBoxPassword_TextChange(object sender, EventArgs e)
        {
            string password = tbPassword.Text;
            bool isStrong = CheckPasswordStrength(password);

            if (isStrong)
            {
                lbResult.Text = "Mật khẩu đủ mạnh!";
                lbResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbResult.Text = "Mật khẩu không đủ mạnh!";
                lbResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool CheckPasswordStrength(string password)
        {
            // Kiểm tra độ dài mật khẩu
            if (password.Length < 8)
            {
                return false;
            }

            // Kiểm tra ít nhất 1 chữ cái thường
            if (!password.Any(char.IsLower))
            {
                return false;
            }

            // Kiểm tra ít nhất 1 chữ cái hoa
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Kiểm tra ít nhất 1 chữ số
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            // Kiểm tra ít nhất 1 ký tự đặc biệt
            if (!Regex.IsMatch(password, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]"))
            {
                return false;
            }

            // Mật khẩu đủ mạnh
            return true;
        }

        private void bunifuThinButtonLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
=======
        
>>>>>>> 0a9e27d (Logic, UI Register Form)
    }
}
