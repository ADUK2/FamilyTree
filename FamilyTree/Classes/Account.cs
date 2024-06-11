using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree
{

    public class Account
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string VerificationCode { get; set; }
        public DateTime? VerificationExpiry { get; set; }

        public bool AddUser(Account user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Email, VerificationCode, VerificationExpiry) " +
                               "VALUES (@Username, @Password, @Email, @VerificationCode, @VerificationExpiry)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@VerificationCode", DBNull.Value);
                cmd.Parameters.AddWithValue("@VerificationExpiry", DBNull.Value);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool UpdateUser(Account user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Username = @Username, Password = @Password, Email = @Email, " +
                               "VerificationCode = @VerificationCode, VerificationExpiry = @VerificationExpiry " +
                               "WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@VerificationCode", user.VerificationCode);
                cmd.Parameters.AddWithValue("@VerificationExpiry", user.VerificationExpiry);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }        

        public bool Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count == 1;
            }
        }

        public bool GenerateVerificationCode(string email)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string verificationCode = GenerateRandomCode(6); // Tạo mã xác thực ngẫu nhiên 6 ký tự
                DateTime expiryTime = DateTime.Now.AddMinutes(15); // Mã xác thực có hiệu lực trong 15 phút

                string query = "UPDATE Users SET VerificationCode = @VerificationCode, VerificationExpiry = @VerificationExpiry WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);
                cmd.Parameters.AddWithValue("@VerificationExpiry", expiryTime);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    SendVerificationCodeEmail(email, verificationCode); // Gửi mã xác thực qua email
                    return true;
                }
                return false;
            }
        }

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendVerificationCodeEmail(string email, string verificationCode)
        {            
            const string p = "kbvs ndey gxcq hmsj";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("cgiapha@gmail.com");
            message.To.Add(new MailAddress(email));
            message.Subject = "Password Reset Verification Code";
            message.Body = "Your verification code is: " + verificationCode + "\nThank you!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("cgiapha@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }

        public bool CheckVerificationCode(string email, string code)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email AND VerificationCode = @Code AND VerificationExpiry > GETDATE()";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Code", code);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }

        public bool UpdatePassword(string email, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Password = @Password WHERE Email = @Email";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

    }

}
