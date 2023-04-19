using Microsoft.Azure.Amqp.Framing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calenderdoudou
{
    public partial class rendezvous : Form
    {
        //Create a connection string 
        public rendezvous()
        {
            InitializeComponent();
        }

       

        //Event handler for form load event
        private void rendezvous_Load(object sender, EventArgs e)
        {
            //Set the text of the date textbox to the selected date
            txdate.Text = Form1.static_month + "/" + UserControldays.static_day + "/" + Form1.static_year;

            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            string sql = "SELECT Name FROM Workers";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string workerName = reader.GetString(0);
                    lbWorkers.Items.Add(workerName);
                }
            }
    
        }

        //Event handler for save button click event
        private void btnsave_Click(object sender, EventArgs e)
        {

            //Create a new SqlConnection object with the connection string
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True");
            conn.Open();

            //Check if at least two workers are selected
            if (lbWorkers.SelectedItems.Count < 1)
            {
                MessageBox.Show("Veuillez sélectionner au moins un seul travailleurs.");
                return;
            }





            //Check if the selected date is a Saturday or Sunday
            DateTime selectedDate = DateTime.Parse(txdate.Text);
            DayOfWeek selectedDayOfWeek = selectedDate.DayOfWeek;
            if (selectedDayOfWeek == DayOfWeek.Saturday || selectedDayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Les événements ne peuvent pas être programmés les samedis ou dimanches.");
                return;
            }

            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Les événements ne peuvent pas être programmés dans le passé.");
                return;
            }

            if (string.IsNullOrEmpty(txevent.Text))
            {
                MessageBox.Show("Veuillez entrer un nom d'événement.");
                return;
            }

            //Check if the start and end time are between 8:00 and 17:00
            if (DateTime.Parse(starttime.Text).TimeOfDay < new TimeSpan(8, 0, 0) || DateTime.Parse(endtime.Text).TimeOfDay > new TimeSpan(17, 0, 0))
            {
                MessageBox.Show("L'heure de l'événement doit être comprise entre 8h00 et 17h00.");
                return;
            }

            if (DateTime.Parse(endtime.Text) > DateTime.Parse(starttime.Text))
            {
                

                //Check if any selected worker has an overlapping event time with the selected event time
                List<string> overlappingWorkers = new List<string>();
                foreach (var selectedWorker in lbWorkers.SelectedItems.Cast<string>())
                {
                    String workerSql = "SELECT COUNT(*) FROM tbl_calendar WHERE date = @date AND workers LIKE @workerName AND (@startevent BETWEEN startevent AND endevent OR @endevent BETWEEN startevent AND endevent)";
                    using (SqlCommand workerCmd = new SqlCommand(workerSql, conn))
                    {
                        workerCmd.Parameters.AddWithValue("@date", txdate.Text);
                        workerCmd.Parameters.AddWithValue("@workerName", "%" + selectedWorker + "%");
                        workerCmd.Parameters.AddWithValue("@startevent", starttime.Text);
                        workerCmd.Parameters.AddWithValue("@endevent", endtime.Text);

                        int overlappingWorkerEventCount = Convert.ToInt32(workerCmd.ExecuteScalar());
                        if (overlappingWorkerEventCount > 0)
                        {
                            overlappingWorkers.Add(selectedWorker);
                        }
                    }
                }



                if (overlappingWorkers.Count > 0)
                {
                    MessageBox.Show("Les travailleurs suivants ont des temps d'événements qui se chevauchent : " + string.Join(", ", overlappingWorkers));
                    return;
                }




                //Create a SQL query to insert data into the table
                String sql = "INSERT INTO tbl_calendar(date, event, startevent, endevent, workers) VALUES (@date, @event, @startevent, @endevent, @workers)";

                //Create a SqlCommand object with the query and connection
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;

                //Add parameters to the query for the date, event, startevent, endevent, and workers fields
                cmd.Parameters.AddWithValue("@date", txdate.Text);
                cmd.Parameters.AddWithValue("@event", txevent.Text);
                cmd.Parameters.AddWithValue("@startevent", starttime.Text);
                cmd.Parameters.AddWithValue("@endevent", endtime.Text);
                cmd.Parameters.AddWithValue("@workers", string.Join(",", lbWorkers.SelectedItems.Cast<string>()));

                //Execute the query to insert the data into the table
                cmd.ExecuteNonQuery();

                //Show a message box to confirm that the data was saved
                MessageBox.Show("Enregistré");

                //Close the SqlCommand and SqlConnection objects
                cmd.Dispose();
            }
            else
            {
                //Show an error message if the endtime is not greater than the starttime
                MessageBox.Show("L'heure de fin doit être supérieure à l'heure de début.");


            }
            conn.Close();
        }

       
    }
}
