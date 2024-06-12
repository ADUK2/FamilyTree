using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using FamilyTree.UI;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace FamilyTree
{
    public partial class Register : Form
    {

        SqlCommand cnn;
        SqlConnection con;

        public Register()
        {
            InitializeComponent();
        }

        private void lbBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }



        private void bunifuTextBoxPassword_TextChange(object sender, EventArgs e)
        {
            string password = bunifuTextBoxPassword.Text;
            bool isStrong = CheckPasswordStrength(password);

            if (string.IsNullOrEmpty(password))
            {
                lbResult.Text = "VD: aA12345!";
                lbResult.ForeColor = System.Drawing.Color.Red;
            }
            else if (!isStrong)
            {
                lbResult.Text = "Mật khẩu không đủ mạnh!";
                lbResult.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbResult.Text = "Mật khẩu đủ mạnh!";
                lbResult.ForeColor = System.Drawing.Color.Green;
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

        private void bunifuTextBoxEmail_TextChange(object sender, EventArgs e)
        {
            string email = bunifuTextBoxEmail.Text;
            bool isValid = ValidateEmail(email);

            // Cập nhật label cảnh báo
            lbResutlEmail.Text = isValid ? "Email hợp lệ" : "Email không hợp lệ";
            lbResutlEmail.ForeColor = isValid ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private bool ValidateEmail(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void bunifuTextBoxUsername_TextChange(object sender, EventArgs e)
        {
            string username = bunifuTextBoxUsername.Text;
            bool isValid = ValidateUsername(username);

            if (string.IsNullOrEmpty(username))
            {
                lbUsername.Text = "Tài khoản phải hơn 6 ký tự.";
                lbUsername.ForeColor = System.Drawing.Color.Red;
            }
            else if (!isValid)
            {
                lbUsername.Text = "Tên người dùng không hợp lệ.";
                lbUsername.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lbUsername.Text = "Tên người dùng hợp lệ.";
                lbUsername.ForeColor = System.Drawing.Color.Green;
            }
        }


        private bool ValidateUsername(string username)
        {
            // Kiểm tra độ dài tối thiểu và tối đa
            if (username.Length < 6 || username.Length > 15)
            {
                return false;
            }

            // Kiểm tra xem username có chứa ký tự đặc biệt hay không
            if (username.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
            {
                return false;
            }

            // Kiểm tra xem username có chứa khoảng trắng ở đầu hoặc cuối hay không
            if (username.StartsWith(" ") || username.EndsWith(" "))
            {
                return false;
            }

            // Nếu tất cả các điều kiện trên được đáp ứng thì username hợp lệ
            return true;
        }

        private void bunifuTextBoxConfirmPassword_TextChange(object sender, EventArgs e)
        {
            // Kiểm tra mật khẩu xác nhận khi người dùng nhập vào
            string password = bunifuTextBoxPassword.Text;
            string confirmPassword = bunifuTextBoxConfirmPassword.Text;
            bool isConfirmed = ConfirmPassword(password, confirmPassword);

            // Cập nhật label cảnh báo
            lbConfirmPassword.Text = isConfirmed ? "Xác nhận mật khẩu thành công" : "Xác nhận mật khẩu không thành công";
            lbConfirmPassword.ForeColor = isConfirmed ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        private bool ConfirmPassword(string password, string confirmPassword)
        {
            // Kiểm tra xem hai mật khẩu có giống nhau hay không
            return password == confirmPassword;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = bunifuTextBoxUsername.Text;
            string password = bunifuTextBoxPassword.Text;
            string confirmPassword = bunifuTextBoxConfirmPassword.Text;
            string email = bunifuTextBoxEmail.Text;

            if (!ValidateUsername(username))
            {
                MessageBox.Show("Tên người dùng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckPasswordStrength(password))
            {
                MessageBox.Show("Mật khẩu không đủ mạnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ConfirmPassword(password, confirmPassword))
            {
                MessageBox.Show("Xác nhận mật khẩu không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account account = new Account()
            {
                Username = username,
                Password = password,
                Email = email,
            };
            try
            {
                account.AddUser(account);
                MessageBox.Show("Account registered successfully!");
                this.Close();
                HomeScreen homeScreen = new HomeScreen();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
