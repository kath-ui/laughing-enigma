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
            var currentDaysMonth = GetDaysInMonth(currentMonth, currentYear);

            foreach(var day in currentDaysMonth)
            {
                
                // Create a new Panel dynamically
                Panel newPanel = new Panel();

                // Set properties for the new Panel
                newPanel.Size = new Size(180, 100);           // Set size (width, height)
                newPanel.BackColor = Color.LightBlue;         // Set background color

                // Optionally, set additional properties like margin, padding, etc.
                newPanel.Margin = new Padding(10);            // Add margin for spacing
                newPanel.Padding = new Padding(5);            // Add internal padding for controls inside the panel

                // Optionally, add controls to the new Panel (e.g., a label inside the panel)
                Label label = new Label();
                label.Text = day.DayOfWeek.ToString() +"\n "+ day.Day;
                label.Dock = DockStyle.Fill;                  // Dock the label to fill the panel
                newPanel.Controls.Add(label);                 // Add the label to the panel

                // Add the new Panel to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(newPanel);
                

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
