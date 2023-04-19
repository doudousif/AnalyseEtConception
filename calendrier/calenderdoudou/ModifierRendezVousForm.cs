using Microsoft.Azure.Amqp;
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
    public partial class ModifierRendezVousForm : Form
    {
        private string eventName;
        private List<string> workers;
        private List<string> workerEvents; // declare workerEvents as a class-level variable


        public ModifierRendezVousForm(string eventName, List<string> workers)
        {
            InitializeComponent();
            this.eventName = eventName;
            this.workers = workers;

            // Display the workers in the lbworkmodif listbox
            foreach (string worker in workers)
            {
                lbworkmodif.Items.Add(worker);
            }

            // Set the label text to the selected event name
            label6.Text = eventName;

            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            // Retrieve workers from the database and add them to listBox1
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Workers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }

        private void ModifierRendezVousForm_Load(object sender, EventArgs e)
        {
            
        }





        /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            string sql = "SELECT event FROM tbl_calendar WHERE workers = workers";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("worker", "%" + listBox1.SelectedItem.ToString() + "%");
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    listBox2.Items.Clear();
                    while (reader.Read())
                    {
                        listBox2.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    listBox2.Items.Clear();
                    listBox2.Items.Add("No events found for selected worker");
                }
            }
        }
        */












        private void btnenlever_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the lbworkmodif ListBox
            if (lbworkmodif.SelectedItem != null)
            {
                // Get the selected worker
                string selectedWorker = lbworkmodif.SelectedItem.ToString();

                // Remove the selected worker from the ListBox
                lbworkmodif.Items.Remove(selectedWorker);

                // Optional: Delete the selected worker from your database or data source
            }

        }

        private void btnajouter_Click_1(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                if (!lbworkmodif.Items.Contains(item))
                {
                    lbworkmodif.Items.Add(item);
                }
                else
                {
                    MessageBox.Show("employee deja invite list.");
                }
            }
        }







        /*
        private void button1_Click(object sender, EventArgs e)
        {
            // retrieve the selected event from listBox2 and do something with it
            string selectedEvent = listBox2.SelectedItem.ToString();
            MessageBox.Show(selectedEvent);
        }
        */


        private void btnmodifier_Click(object sender, EventArgs e)
        {
            // Retrieve the new event name from the textbox
            string newEventName = nameventmodif.Text.Trim();

            // Check if the new event name is empty
            if (string.IsNullOrWhiteSpace(newEventName))
            {
                MessageBox.Show("Veuillez entrer un nom pour l'événement.");
                return;
            }



            // Retrieve the new date from the dateTimePicker
            DateTime newDate = dateTimemodif.Value.Date;


            // Retrieve the new start and end times from the datetimepickers
            DateTime newStartTime = starttimemodif.Value;
            DateTime newEndTime = endtimemodif.Value;

            // Check if the end time is greater than the start time
            if (newEndTime <= newStartTime)
            {
                MessageBox.Show("L'heure de fin doit être supérieure à l'heure de début.");
                return;
            }

            //Check if at least two workers are selected
            if (lbworkmodif.Items.Count < 1)
            {
                MessageBox.Show("Veuillez sélectionner au moins un seul travailleurs.");
                return;
            }

            // Check if the start time and end time are between 8:00 and 17:00
            TimeSpan startTime = newStartTime.TimeOfDay;
            TimeSpan endTime = newEndTime.TimeOfDay;
            TimeSpan minTime = new TimeSpan(8, 0, 0);
            TimeSpan maxTime = new TimeSpan(17, 0, 0);
            if (startTime < minTime || startTime > maxTime)
            {
                MessageBox.Show("L'heure de début doit être entre 8:00 et 17:00.");
                return;
            }
            if (endTime < minTime || endTime > maxTime)
            {
                MessageBox.Show("L'heure de fin doit être entre 8:00 et 17:00.");
                return;
            }



            //Check if the selected date is a Saturday or Sunday
            DateTime selectedDate = DateTime.Parse(dateTimemodif.Text);
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

            SqlConnection connectionS = new SqlConnection("Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True");
            connectionS.Open();

            //Check if any worker has an overlapping event time with the selected event time
            List<string> overlappingWorkers = new List<string>();
            foreach (var worker in lbworkmodif.Items.Cast<string>())
            {
                String workerSql = "SELECT COUNT(*) FROM tbl_calendar WHERE date = @date AND workers LIKE @workerName AND (@startevent BETWEEN startevent AND endevent OR @endevent BETWEEN startevent AND endevent)";
                using (SqlCommand workerCmd = new SqlCommand(workerSql, connectionS))
                {
                    workerCmd.Parameters.AddWithValue("@date", dateTimemodif.Value.Date);
                    workerCmd.Parameters.AddWithValue("@workerName", "%" + worker + "%");
                    workerCmd.Parameters.AddWithValue("@startevent", starttimemodif.Text);
                    workerCmd.Parameters.AddWithValue("@endevent", endtimemodif.Text);

                    int overlappingWorkerEventCount = Convert.ToInt32(workerCmd.ExecuteScalar());
                    if (overlappingWorkerEventCount > 0)
                    {
                        overlappingWorkers.Add(worker);
                    }
                }
            }

            if (overlappingWorkers.Count > 0)
            {
                MessageBox.Show("Les travailleurs suivants ont des temps d'événements qui se chevauchent : " + string.Join(", ", overlappingWorkers));
                return;
            }





            // Update the event in the database
            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE tbl_calendar SET event = @newEventName, startevent = @newStartTime, endevent = @newEndTime, date = @newDate WHERE event = @oldEventName";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@newEventName", newEventName);
                    cmd.Parameters.AddWithValue("@newStartTime", newStartTime);
                    cmd.Parameters.AddWithValue("@newEndTime", newEndTime);
                    cmd.Parameters.AddWithValue("@newDate", dateTimemodif.Value.Date);
                    cmd.Parameters.AddWithValue("@oldEventName", eventName);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Update the event name in the current form
                        eventName = newEventName;
                        label6.Text = eventName;

                        // Show a message box to indicate the success
                        MessageBox.Show("L'événement a été modifié avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Impossible de modifier l'événement.");
                    }
                }
            }


            // Update the event in the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // First update the tbl_calendar table
                string updateEventQuery = "UPDATE tbl_calendar SET event = @newName, StartEvent = @newStart, EndEvent = @newEnd, Workers = @newWorkers WHERE event = @oldName";
                using (SqlCommand cmd = new SqlCommand(updateEventQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@newName", newEventName);
                    cmd.Parameters.AddWithValue("@newStart", newStartTime.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@newEnd", newEndTime.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@newWorkers", string.Join(",", lbworkmodif.Items.Cast<string>().ToArray()));
                    cmd.Parameters.AddWithValue("@oldName", eventName);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("La mise à jour de l'événement a échoué.");
                    }
                    else
                    {
                        //MessageBox.Show("L'événement a été mis à jour avec succès.");
                    }
                }
            }

           

        }

        private void listemploy_Click(object sender, EventArgs e)
        {
            Employee modifemployee = new Employee();
            modifemployee.ShowDialog(); // show the form as a modal dialog

        }
    }
} 
