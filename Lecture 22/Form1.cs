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

namespace Lecture_22
{
    public partial class Form1 : Form
    {
        // This is a description of how to create a connection to
        // SQL Sever
        string connectionString = "Data Source=.;" +
            "Initial Catalog=IU_VP_Script_DB;" +
            "Integrated Security=True";

        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGridview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // If you want to run any sql command on SQL Server from your
            // application, you need to use SqlCommand
            string commandString = $"Insert into Students(StudentName) values('{txtName.Text}')";
            SqlCommand command = new SqlCommand(commandString, connection);

            // To run the command on SQL Server from your application
            connection.Open();
            command.ExecuteNonQuery(); // This will execute commands that are not queries (not select)
            connection.Close();

            RefreshDataGridview();
            txtName.Text = "";
            MessageBox.Show("تمت الاضافة بنجاح");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // If you want to run any sql command on SQL Server from your
            // application, you need to use SqlCommand
            string commandString = $"Update Students Set StudentName = '{txtName.Text}' where StudentId = {txtId.Text}";
            SqlCommand command = new SqlCommand(commandString, connection);

            // To run the command on SQL Server from your application
            connection.Open();
            command.ExecuteNonQuery(); // This will execute commands that are not queries (not select)
            connection.Close();

            RefreshDataGridview();
            txtName.Text = "";
            MessageBox.Show("تم التعديل بنجاح");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string commandString = $"Delete from Students where StudentId = {txtId.Text}";
            SqlCommand command = new SqlCommand(commandString, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            RefreshDataGridview();
            txtName.Text = "";
            MessageBox.Show("تم إلغاء القيد بنجاح");
        }

        private void RefreshDataGridview()
        {
            // If you want to run any sql command on SQL Server from your
            // application, you need to use SqlCommand
            string commandString = $"Select * from Students";
            SqlCommand command = new SqlCommand(commandString, connection);

            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvStudents.DataSource = dt;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private string GetStudentById(string studentId)
        {
            string commandString = $"Select * from Students where studentId = {studentId}";
            SqlCommand command = new SqlCommand( commandString, connection);

            string studentReport = "";

            if (!string.IsNullOrEmpty(studentId))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                

                while (reader.Read())
                {
                    studentReport = "Student ID: " + reader.GetInt32(0).ToString() + "\nStudent Name: " + reader.GetString(1);
                }

                connection.Close();
            }
            else
            {
                studentReport = "Record does not exist";
            }

            return studentReport;
        }

        private void btnGetStudentDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetStudentById(txtId.Text));
        }
    }
}
