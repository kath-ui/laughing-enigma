namespace Planner_Indicator
{
    partial class CalendarItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DayLabel = new System.Windows.Forms.Label();
            this.eventsList = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Location = new System.Drawing.Point(41, 10);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(44, 16);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "label1";
            // 
            // eventsList
            // 
            this.eventsList.Location = new System.Drawing.Point(0, 38);
            this.eventsList.Multiline = true;
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(187, 142);
            this.eventsList.TabIndex = 1;
            this.eventsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eventsList.TextChanged += new System.EventHandler(this.eventsList_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CalendarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.DayLabel);
            this.Name = "CalendarItem";
            this.Size = new System.Drawing.Size(187, 203);
            this.Load += new System.EventHandler(this.CalendarItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.TextBox eventsList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
