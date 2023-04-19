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

namespace calenderdoudou
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // Connect to the database
            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Query the database to retrieve all workers
            SqlCommand command = new SqlCommand("SELECT * FROM Workers", connection);
            SqlDataReader reader = command.ExecuteReader();

            // Add workers to the listbox
            while (reader.Read())
            {
                string workerName = reader["Name"].ToString();
                lirdv.Items.Add(workerName);
            }

            // Close the reader
            reader.Close();

            // Query the database to retrieve all events
            command = new SqlCommand("SELECT event FROM tbl_calendar", connection);
            reader = command.ExecuteReader();

            // Add events to the listbox
            while (reader.Read())
            {
                string eventName = reader["event"].ToString();
                ltemployee.Items.Add(eventName);
            }

            // Close the reader and database connection
            reader.Close();
            connection.Close();
        }

        private void lirdv_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Connect to the database
            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Get the selected worker's name
            string selectedWorker = lirdv.SelectedItem.ToString();

            // Query the database to retrieve all events for the selected worker
            SqlCommand command = new SqlCommand("SELECT event FROM tbl_calendar WHERE worker=@worker", connection);
            command.Parameters.AddWithValue("@worker", selectedWorker);
            SqlDataReader reader = command.ExecuteReader();

            // Clear the current items in the ltemployee listbox
            ltemployee.Items.Clear();

            // Add the events for the selected worker to the ltemployee listbox
            while (reader.Read())
            {
                string eventName = reader["event"].ToString();
                ltemployee.Items.Add(eventName);
            }

            // Close the reader and database connection
            reader.Close();
            connection.Close();
        }




    }
}
