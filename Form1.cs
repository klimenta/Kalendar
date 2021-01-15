using System;
using System.Windows.Forms;

namespace Kalendar
{
    public partial class Form1 : Form
    {

        //Toggle used for the screen expand
        bool bFormToggle = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 280;            
            mcCalendarL.ShowWeekNumbers = true;
            //Get the current month and show in combobox
            int intMonth = DateTime.Now.Month;
            cbMonth.SelectedIndex = intMonth - 1;
            //Add years from 1999 to 2030 in combobox
            for (int x = 1999; x < 2030; x++)
            {
                cbYear.Items.Add(x.ToString());
            }
            //Show today's date in the labels
            lblLeft.Text = "L: " + mcCalendarL.TodayDate.ToShortDateString();
            lblRight.Text = "R: " + mcCalendarR.TodayDate.ToShortDateString();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCalendar();
        }

        //Shows the calendar on the left when month or year changes in the combos
        private void ShowCalendar()
        {
            DateTime dateLeft = mcCalendarL.SelectionRange.Start;
            DateTime dateRight = mcCalendarR.SelectionRange.Start;
            int year;

            try
            {
                year = int.Parse(cbYear.Text);
            }
            catch
            {
                year = dateLeft.Year;
            }
            
            try
            {
                DateTime selStart = new DateTime(year, cbMonth.SelectedIndex + 1, 1);
                DateTime selEnd = selStart.AddDays(0);
                mcCalendarL.SelectionStart = selStart.AddDays(0);
                mcCalendarL.SelectionEnd = selEnd.AddDays(0);
            }
            catch
            {
                year = dateLeft.Year;
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCalendar();
        }

        //Change year when ENTER key is pressed
        private void cbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) ShowCalendar();
        }

        //Expands/reduces the form when the yellow button is clicked
        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (bFormToggle)
            {
                btnToggle.Text = ">";
                bFormToggle = false;
                this.Width = 280;
            }
            else
            {
                btnToggle.Text = "<";
                bFormToggle = true;
                this.Width = 544;
            }
        }

        private void mcCalendarR_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalculateDiff();
        }

        //Calculate the difference in days between two calendars
        private void CalculateDiff()
        {
            DateTime dateLeft = mcCalendarL.SelectionRange.Start;
            DateTime dateRight = mcCalendarR.SelectionRange.Start;
            lblLeft.Text = "L: " + dateLeft.ToShortDateString();
            lblRight.Text = "R: " + dateRight.ToShortDateString();
            lblDiff.Text = "Diff: " + (dateRight - dateLeft).TotalDays.ToString();
        }

        private void mcCalendarL_DateChanged(object sender, DateRangeEventArgs e)
        {
            CalculateDiff();
        }
    }
}
