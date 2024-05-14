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
    public partial class DoctorPanel : Form
    {
        private string _doctorEmail;
        public DoctorPanel(string email)
        {
            InitializeComponent();
            _doctorEmail = email;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=TUMUKUNDE\SQLEXPRESS;Initial Catalog=Hospital_DB;Integrated Security=True;Encrypt=False");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            DisplayAppointments();
        }

        private void DisplayAppointments()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT a.appointment_id as ID, p.fullname as patient, d.specialization as service, appointment_date, status FROM Appointment a JOIN Patient p ON a.patient = p.patient_id JOIN Doctor d ON a.doctor = d.email WHERE d.email = '" + _doctorEmail + "'", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Appointment");
            dataGridView1.DataSource = ds.Tables["Appointment"];
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DisplayAppointments();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    appointmentId.Text = row.Cells[0].Value.ToString();
                    patientTxt.Text = row.Cells[1].Value.ToString();
                    serviceTxt.Text = row.Cells[2].Value.ToString();
                    appointmentDate.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (appointmentId.Text.Equals("none"))
            {
                MessageBox.Show("Please select an appointment first");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Appointment SET status = @v_status, appointment_date = @v_appointment_date WHERE appointment_id = @v_appointment_id", conn);
                cmd.Parameters.AddWithValue("@v_appointment_id", appointmentId.Text);
                cmd.Parameters.AddWithValue("@v_status", "APPROVED");
                cmd.Parameters.AddWithValue("@v_appointment_date", appointmentDate.Value.Date);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Appointment approved successfully!");
                DisplayAppointments();
            }
        }

        private void denyBtn_Click(object sender, EventArgs e)
        {
            if (appointmentId.Text.Equals("none"))
            {
                MessageBox.Show("Please select an appointment first");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Appointment SET status = @v_status, appointment_date = @v_appointment_date WHERE appointment_id = @v_appointment_id", conn);
                cmd.Parameters.AddWithValue("@v_appointment_id", appointmentId.Text);
                cmd.Parameters.AddWithValue("@v_status", "DENIED");
                cmd.Parameters.AddWithValue("@v_appointment_date", appointmentDate.Value.Date);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Appointment denied successfully!");
                DisplayAppointments();
            }
        }
    }
}
