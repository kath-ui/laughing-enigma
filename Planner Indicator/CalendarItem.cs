using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner_Indicator
{
    public partial class CalendarItem : UserControl
    {
        public int Day;
        public List<string> Events;
        public CalendarItem(int day, List<string> events)
        {
            BorderStyle = BorderStyle.FixedSingle;
            Margin = new Padding(0);
            Padding = new Padding(5);
            
            Day = day;
            Events = events;
            InitializeComponent();
            Initializecalendar();
        }

        private void Initializecalendar()
        {
            DayLabel.Text = Day.ToString();
            foreach(var ev in Events)
            {
                eventsList.Text += ev + "\n";
            }
        }

        private void CalendarItem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
