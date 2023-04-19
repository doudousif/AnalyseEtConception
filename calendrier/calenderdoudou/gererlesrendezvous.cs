using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calenderdoudou
{
    public partial class gererlesrendezvous : Form
    {

        private bool eventSelected = false;

        public gererlesrendezvous()
        {
            InitializeComponent();

        }

        private void listdesrendezvous()
        {
            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            string sql = "SELECT Distinct event, date FROM tbl_calendar";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                List<string> eventNames = new List<string>();
                while (reader.Read())
                {
                    string eventName = reader.GetString(0);
                    if (!eventNames.Contains(eventName)) // check if event name already exists in the list
                    {
                        eventNames.Add(eventName);
                        lirdv.Items.Add(eventName);
                    }
                }
            }
        }


        private void gererlesrendezvous_Load(object sender, EventArgs e)
        {
            listdesrendezvous();

            // Disable the btnmodifier button until an event is selected
            btnmodifierrendevous.Enabled = false;
        }

        private void lirdv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lirdv.SelectedItem == null)
            {
                
                return;
            }

            string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
            string sql = "SELECT date, startevent, endevent, workers FROM tbl_calendar WHERE event = @eventName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@eventName", lirdv.SelectedItem.ToString());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    lbdate2.Text = reader.GetDateTime(0).ToString();
                    lbdebut4.Text = reader.GetTimeSpan(1).ToString();
                    lbfin5.Text = reader.GetTimeSpan(2).ToString();
                    string[] workers = reader.GetString(3).Split(',');
                    ltemployee.Items.Clear();
                    foreach (string worker in workers)
                    {
                        ltemployee.Items.Add(worker.Trim());
                    }
                }
                else
                {
                    lbdate2.Text = "No date available";
                    lbdebut4.Text = "";
                    lbfin5.Text = "";
                    ltemployee.Items.Clear();
                }
            }
            eventSelected = true;

            // Enable the btnmodifier button if an event is selected
            btnmodifierrendevous.Enabled = true;

        }


        private int GetSelectedEventId()
        {
            // Retrieve the eventId of the selected event from the previous form or from the current form if it is passed as a parameter.
            int eventId = 0; // or any default value
                             // TODO: Retrieve the eventId value
            return eventId;
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {



            if (lirdv.SelectedIndex >= 0) // check if an event is selected
            {
                string eventName = lirdv.SelectedItem.ToString();
                List<string> workers = ltemployee.Items.Cast<string>().ToList(); // get the list of workers
                ModifierRendezVousForm modifierForm = new ModifierRendezVousForm(eventName, workers);
                modifierForm.ShowDialog(); // show the form as a modal dialog

                // Set the label text to the selected event name
                label6.Text = eventName;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous à modifier.");
            }

            GetSelectedEventId();
        }

        private void btnsuppr_Click(object sender, EventArgs e)
        {
            if (lirdv.SelectedItem != null)
            {
                string eventName = lirdv.SelectedItem.ToString();
                DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer l'événement {eventName} ?", "Confirmer la suppression", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connectionString = "Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True";
                    string sql = "DELETE FROM tbl_calendar WHERE event = @eventName";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@eventName", eventName);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            lirdv.Items.Remove(eventName);
                            MessageBox.Show("L'événement a été supprimé avec succès.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un événement à supprimer.");
            }
            btnmodifierrendevous.Enabled = true;

        }





    }
}
