using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner_Indicator
{
    public partial class Form1 : Form
    {
        DateTime currentDate = DateTime.Now;
        int currentMonth;
        int currentYear;

        
        private List<DateTime> daysInMonth = new List<DateTime>();
        public Form1()
        {
             currentMonth = currentDate.Month;
            currentYear = currentDate.Year;
            InitializeComponent();
            InitializeCalendar();

            
            label1.Text = currentDate.ToString("MMMM");
            label2.Text = currentDate.ToString("yyyy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InitializeCalendar()
        {
            DateTime firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);
            
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
 
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 0;     
            tableLayoutPanel1.ColumnCount = 7;  
            tableLayoutPanel1.RowCount = (int)Math.Ceiling((double)daysInMonth / 7.0) + 1; 
            tableLayoutPanel1.AutoSize = true;      
            tableLayoutPanel1.Dock = DockStyle.Fill;

            
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));  
            }

            
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); 
            }

            
            string[] dayNames = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int i = 0; i < 7; i++)
            {
                Label label = new Label
                {
                    Text = dayNames[i],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 12, FontStyle.Bold),  
                    
                    BorderStyle = BorderStyle.FixedSingle 
                };

                tableLayoutPanel1.Controls.Add(label, i, 0);  
            }

            
            int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;  

            
            for (int i = 0; i < firstDayOfWeek; i++)
            {
                tableLayoutPanel1.Controls.Add(new Panel(), i, 1); 
            }
          
            for (int day = 1; day <= daysInMonth; day++)
            {
               
                Panel dayPanel = new Panel
                {
                    
                    BorderStyle = BorderStyle.FixedSingle,  
                    Margin = new Padding(0), 
                    Padding = new Padding(5)  
                };

                Label dayLabel = new Label
                {
                    Text = day.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 14)  
                };
                dayPanel.Controls.Add(dayLabel);

                

                var eventList = new string[]
                {

                };
                var calendarItem = new CalendarItem(day, eventList.ToList());

                int row = (int)((firstDayOfWeek + day - 1) / 7) + 1; 
                int col = (firstDayOfWeek + day - 1) % 7; 
                tableLayoutPanel1.Controls.Add(calendarItem, col, row);
            }
        }
        
        
       
        
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        public static List<DateTime> GetDaysInMonth(int month, int year)
        {
            var days = new List<DateTime>();

            var daysCount = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= daysCount; day++)
            {
                days.Add(new DateTime(year, month, day));
            }

            return days;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
