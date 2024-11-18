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
        private int currentMonth=1, currentYear=2024;
        private List<DateTime> daysInMonth = new List<DateTime>();
        public Form1()
        {
            InitializeComponent();
            InitializeCalendar();  
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
            // Get the current date and the first day of the current month
            DateTime currentDate = DateTime.Now;
            int currentMonth = currentDate.Month;
            int currentYear = currentDate.Year;

            DateTime firstDayOfMonth = new DateTime(currentYear, currentMonth, 1);

            // Calculate the number of days in the current month
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);

            // Clear existing controls from the TableLayoutPanel
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 0;  // Reset row count to start fresh

            // Set up the TableLayoutPanel
            tableLayoutPanel1.ColumnCount = 7;  // 7 columns for the days of the week
            tableLayoutPanel1.RowCount = (int)Math.Ceiling((double)daysInMonth / 7.0) + 1; // Header row + rows for days
            tableLayoutPanel1.AutoSize = true; // Allow table to auto-size

            // Set the panel to fill the parent container (form or panel)
            tableLayoutPanel1.Dock = DockStyle.Fill;

            // Set equal width for all columns (7 columns)
            tableLayoutPanel1.ColumnStyles.Clear();
            for (int i = 0; i < 7; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));  // Equal width for all columns
            }

            // Adjust row sizes to ensure cells are large enough
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // Set a fixed height for each row (60px)
            }

            // Add day names (headers) to the first row with a larger font
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
                    
                    BorderStyle = BorderStyle.FixedSingle,  // Black border for each day panel
                    Margin = new Padding(0),  // No margin for a tight fit
                    Padding = new Padding(5)  // Padding inside the panel for the day label
                };

                Label dayLabel = new Label
                {
                    Text = day.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 14)  //  font of day numbers
                };
                dayPanel.Controls.Add(dayLabel);

                // Highlight the current day
                if (day == currentDate.Day)
                {
                    dayPanel.BackColor = Color.LightGreen;  // Highlight current day
                }

                // Add the panel to the tableLayoutPanel, placing it in the correct position
                int row = (int)((firstDayOfWeek + day - 1) / 7) + 1; // Calculate the row number
                int col = (firstDayOfWeek + day - 1) % 7; // Calculate the column number
                tableLayoutPanel1.Controls.Add(dayPanel, col, row);
            }
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
    }
}
