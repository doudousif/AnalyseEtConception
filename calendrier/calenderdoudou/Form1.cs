using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calenderdoudou
{
    public partial class Form1 : Form
    {
        int month, year;
        
        //lets create a static variable that we can pass to another form for month and year
        public static int static_month, static_year;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displaydays();
        }
        private void displaydays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            LBDATE.Text = "";

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            static_month = month;
            static_year = year;

            //LETS get the first day of the month.
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            // create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            // create a days usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }


           
        }

       

        private void btngerer1_Click(object sender, EventArgs e)
        {
            gererlesrendezvous gererrendezvous = new gererlesrendezvous();
            gererrendezvous.Show();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            // clear the container
            daycontainer.Controls.Clear();
            // increment month to go to the next month
            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            // create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            // create a days usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

       

        private void btnnext_Click(object sender, EventArgs e)
        {
            // clear the container
                daycontainer.Controls.Clear();
            // increment month to go to the next month
            month++;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthname + " " + year;
            DateTime startofthemonth = new DateTime(year, month, 1);
            //get the count of days of the month
            int days = DateTime.DaysInMonth(year, month);
            //convert the startofthemonth to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));
            // create a blank usercontrol
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                daycontainer.Controls.Add(ucblank);

            }
            // create a days usercontrol
            for (int i = 1; i <= days; i++)
            {
                UserControldays ucdays = new UserControldays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
