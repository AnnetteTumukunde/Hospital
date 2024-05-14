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
using System.Security.Cryptography;

namespace Hospital
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=TUMUKUNDE\SQLEXPRESS;Initial Catalog=Hospital_DB;Integrated Security=True;Encrypt=False");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (passwordTxt.Text.Equals(confirmpwdTxt.Text))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Patient (fullname, email, password, role) VALUES (@v_fullname, @v_email, @v_password, @v_role)", conn);
                cmd.Parameters.AddWithValue("@v_fullname", fullnameTxt.Text);
                cmd.Parameters.AddWithValue("@v_email", emailTxt.Text);
                cmd.Parameters.AddWithValue("@v_password", encryptPwd(passwordTxt.Text));
                cmd.Parameters.AddWithValue("@v_role", "PATIENT");
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Patient " + fullnameTxt.Text + " registered successfully!");
                Login loginform = new Login();
                loginform.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Unmatched password");
            }
        }

        private string encryptPwd(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Hash  computation
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
