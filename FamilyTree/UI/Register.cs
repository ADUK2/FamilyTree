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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-229JBF6T;Initial Catalog=CayGiaPhaDB;Integrated Security=True");
            
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Users values(@UserName,@PasswordHash,@FullName,@Email)",con);

            cnn.Parameters.AddWithValue("@UserName", (textboxUsername.Text));
            cnn.Parameters.AddWithValue("@PasswordHash", (textboxPassword.Text));
            cnn.Parameters.AddWithValue("@FullName", (textboxFullname.Text));
            cnn.Parameters.AddWithValue("@Email", (textboxEmail.Text));

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
            string username = textboxUsername.Text;
            string password = textboxPassword.Text;
            string fullname = textboxFullname.Text;
            string email = textboxEmail.Text;

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
    }
}
