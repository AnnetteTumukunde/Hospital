using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=TUMUKUNDE\SQLEXPRESS;Initial Catalog=Hospital_DB;Integrated Security=True;Encrypt=False");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup signupform = new signup();
            signupform.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (validateUser(emailTxt.Text, encryptPwd(passwordTxt.Text)))
            {
                MessageBox.Show("Logged in");
                if (doctorCheck.Checked)
                {
                    SqlCommand cmd = new SqlCommand("SELECT role, email FROM Doctor WHERE email=@v_email", conn);
                    cmd.Parameters.AddWithValue("@v_email", emailTxt.Text);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        if (datareader.HasRows)
                        {
                            datareader.Read();
                            if (datareader["role"].ToString().Equals("MANAGER"))
                            {
                                Manager managerPanel = new Manager(datareader["email"].ToString());
                                this.Hide();
                                managerPanel.Show();
                            } else
                            {
                                DoctorPanel doctorPanel = new DoctorPanel(datareader["email"].ToString());
                                this.Hide();
                                doctorPanel.Show();
                            }
                            conn.Close();
                        }
                    }
                } else
                {
                    SqlCommand cmd = new SqlCommand("SELECT patient_id FROM Patient WHERE email=@v_email", conn);
                    cmd.Parameters.AddWithValue("@v_email", emailTxt.Text);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    using (SqlDataReader datareader = cmd.ExecuteReader())
                    {
                        if (datareader.HasRows)
                        {
                            datareader.Read();
                            PatientPanel patientPanel = new PatientPanel(datareader[0].ToString());
                            this.Hide();
                            patientPanel.Show();
                            conn.Close();
                        }
                    }
                }
            }
        }

        private bool validateUser(string username, string paswd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                if (doctorCheck.Checked)
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM Doctor WHERE email=@v_email and password=@v_pwd", conn);
                } else
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM Patient WHERE email=@v_email and password=@v_pwd", conn);
                }
                cmd.Parameters.AddWithValue("@v_email", username);
                cmd.Parameters.AddWithValue("@v_pwd", paswd);
                int responseNo = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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
