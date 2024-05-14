using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Manager : Form
    {
        private string managerEmail;
        public Manager(string email)
        {
            InitializeComponent();
            managerEmail = email;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=TUMUKUNDE\SQLEXPRESS;Initial Catalog=Hospital_DB;Integrated Security=True;Encrypt=False");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            DisplayAppointments();
        }

        private void DisplayAppointments()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT p.fullname as patient, d.fullname as doctor, appointment_date, status FROM Appointment a JOIN Patient p ON a.patient = p.patient_id JOIN Doctor d ON a.doctor = d.email", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Appointment");
            dataGridView1.DataSource = ds.Tables["Appointment"];
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DisplayAppointments();
        }
    }
}
