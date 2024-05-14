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
    public partial class PatientPanel : Form
    {
        private string _patientId;
        public PatientPanel(string patientID)
        {
            InitializeComponent();
            _patientId = patientID;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=TUMUKUNDE\SQLEXPRESS;Initial Catalog=Hospital_DB;Integrated Security=True;Encrypt=False");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void DisplaySpecialisations(string doctorID)
        {
            SqlCommand cmd = new SqlCommand("SELECT specialization FROM Doctor WHERE email = @v_email", conn);
            cmd.Parameters.AddWithValue("@v_email", doctorID);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (cmd.ExecuteScalar() != null)
            {
                specialityTxt.Text = cmd.ExecuteScalar().ToString();
            } else
            {
                specialityTxt.Text = "Select a doctor";
            }
            conn.Close();
        }

        private void PatientPanel_Load(object sender, EventArgs e)
        {
            DisplayDoctors();
            DisplayPatientAppointment();
        }

        private void DisplayDoctors()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT email, fullname FROM Doctor WHERE role != 'MANAGER'", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Doctor");
            doctorList.DataSource = ds.Tables["Doctor"];
            doctorList.ValueMember = "email";
            doctorList.DisplayMember = "fullname";

            if (doctorList.SelectedValue != null)
            {
                DisplaySpecialisations(doctorList.SelectedValue.ToString());
            }
        }

        private void doctorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doctorList.SelectedValue != null)
            {
                DisplaySpecialisations(doctorList.SelectedValue.ToString());
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Appointment (patient, doctor, appointment_date, status, createdAt) VALUES (@v_patient, @v_doctor, @v_appointment_date, @v_status, @v_createdAt)", conn);
            cmd.Parameters.AddWithValue("@v_patient", _patientId);
            cmd.Parameters.AddWithValue("@v_doctor", doctorList.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@v_appointment_date", appointmentDate.Value.Date);
            cmd.Parameters.AddWithValue("@v_status", "PENDING");
            cmd.Parameters.AddWithValue("@v_createdAt", DateTime.Today);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("New appointment created successfully!");
            DisplayPatientAppointment();
        }

        private void DisplayPatientAppointment()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT a.appointment_id as id, p.fullname as patient, d.fullname as doctor, appointment_date, status FROM Appointment a JOIN Patient p ON a.patient = p.patient_id JOIN Doctor d ON a.doctor = d.email WHERE p.patient_id = '" + _patientId + "'", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Appointment");
            dataGridView1.DataSource = ds.Tables["Appointment"];
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (appointmentId.Text.Equals("none"))
            {
                MessageBox.Show("Please select an appointment first");
            } else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Appointment SET doctor = @v_doctor, appointment_date = @v_appointment_date WHERE appointment_id = @v_appointment_id AND patient = @v_patient", conn);
                cmd.Parameters.AddWithValue("@v_appointment_id", appointmentId.Text);
                cmd.Parameters.AddWithValue("@v_patient", _patientId);
                cmd.Parameters.AddWithValue("@v_doctor", doctorList.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@v_appointment_date", appointmentDate.Value.Date);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Appointment updated successfully!");
                DisplayPatientAppointment();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    appointmentId.Text = row.Cells[0].Value.ToString();
                    doctorList.Text = row.Cells[2].Value.ToString();
                    appointmentDate.Text = row.Cells[3].Value.ToString();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (appointmentId.Text.Equals("none"))
            {
                MessageBox.Show("Please select an appointment first");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Appointment WHERE appointment_id = @v_appointment_id AND patient = @v_patient", conn);
                cmd.Parameters.AddWithValue("@v_appointment_id", appointmentId.Text);
                cmd.Parameters.AddWithValue("@v_patient", _patientId);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Appointment deleted successfully!");
                DisplayPatientAppointment();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DisplayPatientAppointment();
        }
    }
}
