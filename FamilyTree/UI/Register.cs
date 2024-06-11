﻿using System;
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

namespace FamilyTree
{
    public partial class Register : Form
    {

        SqlCommand cnn;
        SqlConnection con;

        public Register()
        {
            InitializeComponent();
            bunifuTextBoxPassword.TextChanged += bunifuTextBoxPassword_TextChange;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-229JBF6T;Initial Catalog=CayGiaPhaDB;Integrated Security=True");
            
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Users values(@UserName,@PasswordHash,@FullName,@Email)",con);

            cnn.Parameters.AddWithValue("@UserName", (bunifuTextBoxUsername.Text));
            cnn.Parameters.AddWithValue("@PasswordHash", (bunifuTextBoxPassword.Text));
            cnn.Parameters.AddWithValue("@FullName", (bunifuTextBoxFullName.Text));
            cnn.Parameters.AddWithValue("@Email", (bunifuTextBoxEmail.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Đăng Ký Thành Công");


        }

        private void lbBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = bunifuTextBoxUsername.Text;
            string password = bunifuTextBoxPassword.Text;
            string fullname = bunifuTextBoxFullName.Text;
            string email = bunifuTextBoxEmail.Text;

            Account account = new Account();
            try
            {
                account.AddAccount(username, password);
                MessageBox.Show("Account registered successfully!");
                this.Close(); // Đóng form đăng ký sau khi đăng ký thành công
                //FirstTimeLogin firstTimeLogin = new FirstTimeLogin();
                //firstTimeLogin.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuTextBoxPassword_TextChange(object sender, EventArgs e)
        {
            string password = bunifuTextBoxPassword.Text;
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
    }
}
