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
    public partial class UserControldays : UserControl
    {       

        public static string static_day;
        public UserControldays()
        {
            InitializeComponent();
        }


        public void days(int numday)
        {
            lbdays.Text = numday + "";
        }

        private void UserControldays_Click(object sender, EventArgs e)
        {
            //start timer if UserControldays is Clicked
            timer1.Start();
            static_day = lbdays.Text;
            rendezvous eventform = new rendezvous();
            eventform.Show();
        }

        private void displayEvent()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E5OF3R7;Initial Catalog=db_calendar;Integrated Security=True");
            conn.Open();
            String sql = "SELECT * FROM tbl_calendar where date = @date";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@date", Form1.static_month + "/"  + lbdays.Text + "/" + Form1.static_year );

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lbevent.Text = reader["event"].ToString();
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();

        }
    }
}
