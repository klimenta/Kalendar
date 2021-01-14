using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mcCalendar.ShowWeekNumbers = true;
            int intMonth = DateTime.Now.Month;
            cbMonth.SelectedIndex = intMonth - 1;
            for (int x = 1999; x < 2030; x++)
            {
                cbYear.Items.Add(x.ToString());
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDate();
        }

        private void CalculateDate()
        {
            DateTime today = mcCalendar.TodayDate;
            int year;
            try
            {
                year = int.Parse(cbYear.Text);
            }
            catch
            {
                year = today.Year;
            }
            
            try
            {
                DateTime selStart = new DateTime(year, cbMonth.SelectedIndex + 1, 1);
                DateTime selEnd = selStart.AddDays(0);
                mcCalendar.SelectionStart = selStart.AddDays(0);
                mcCalendar.SelectionEnd = selEnd.AddDays(0);
            }
            catch
            {
                year = today.Year;
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateDate();
        }

        private void cbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) CalculateDate();
        }
    }
}
