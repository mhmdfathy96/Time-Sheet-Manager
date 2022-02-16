
namespace BmgManagerSheet
{
    partial class Attendancebyday
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendancebyday));
            this.AttendanceBDGV = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.Backbtn2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GetThisDay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AttendanceBDGV
            // 
            this.AttendanceBDGV.AllowUserToAddRows = false;
            this.AttendanceBDGV.AllowUserToDeleteRows = false;
            this.AttendanceBDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.AttendanceBDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceBDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colStart,
            this.colEnd,
            this.colTotal,
            this.colOver,
            this.colHoliday});
            this.AttendanceBDGV.Location = new System.Drawing.Point(40, 86);
            this.AttendanceBDGV.Name = "AttendanceBDGV";
            this.AttendanceBDGV.ReadOnly = true;
            this.AttendanceBDGV.Size = new System.Drawing.Size(694, 360);
            this.AttendanceBDGV.TabIndex = 11;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Name";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 150;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Start";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "End";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Regular";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colOver
            // 
            this.colOver.HeaderText = "Overtime";
            this.colOver.Name = "colOver";
            this.colOver.ReadOnly = true;
            // 
            // colHoliday
            // 
            this.colHoliday.HeaderText = "HolidayHours";
            this.colHoliday.Name = "colHoliday";
            this.colHoliday.ReadOnly = true;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Location = new System.Drawing.Point(325, 35);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(203, 20);
            this.DatePicker.TabIndex = 12;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // Backbtn2
            // 
            this.Backbtn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Backbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backbtn2.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn2.Location = new System.Drawing.Point(12, 12);
            this.Backbtn2.Name = "Backbtn2";
            this.Backbtn2.Size = new System.Drawing.Size(62, 31);
            this.Backbtn2.TabIndex = 13;
            this.Backbtn2.Text = "back";
            this.Backbtn2.UseVisualStyleBackColor = false;
            this.Backbtn2.Click += new System.EventHandler(this.Backbtn2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 50;
            this.progressBar1.Visible = false;
            // 
            // GetThisDay
            // 
            this.GetThisDay.BackColor = System.Drawing.Color.IndianRed;
            this.GetThisDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GetThisDay.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetThisDay.Location = new System.Drawing.Point(544, 32);
            this.GetThisDay.Name = "GetThisDay";
            this.GetThisDay.Size = new System.Drawing.Size(62, 31);
            this.GetThisDay.TabIndex = 15;
            this.GetThisDay.Text = "Get";
            this.GetThisDay.UseVisualStyleBackColor = false;
            this.GetThisDay.Click += new System.EventHandler(this.GetThisDay_Click);
            // 
            // Attendancebyday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.GetThisDay);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Backbtn2);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.AttendanceBDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Attendancebyday";
            this.Text = "Attendancebyday";
            this.Load += new System.EventHandler(this.Attendancebyday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AttendanceBDGV;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button Backbtn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoliday;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button GetThisDay;
    }
}