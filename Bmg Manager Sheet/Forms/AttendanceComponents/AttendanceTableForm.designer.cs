
namespace BmgManagerSheet
{
    partial class AttendanceTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceTableForm));
            this.exitbtn2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalthismonth = new System.Windows.Forms.Label();
            this.Backbtn2 = new System.Windows.Forms.Button();
            this.Empcombo = new System.Windows.Forms.ComboBox();
            this.Monthcombo = new System.Windows.Forms.ComboBox();
            this.DeleteMonth = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.TableProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn2
            // 
            this.exitbtn2.BackColor = System.Drawing.Color.Red;
            this.exitbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn2.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn2.Location = new System.Drawing.Point(637, 533);
            this.exitbtn2.Name = "exitbtn2";
            this.exitbtn2.Padding = new System.Windows.Forms.Padding(5);
            this.exitbtn2.Size = new System.Drawing.Size(86, 39);
            this.exitbtn2.TabIndex = 6;
            this.exitbtn2.Text = "Exit";
            this.exitbtn2.UseVisualStyleBackColor = false;
            this.exitbtn2.Click += new System.EventHandler(this.Exitbtn2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colStart,
            this.colEnd,
            this.colTotal,
            this.colOver,
            this.colHoliday});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 445);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
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
            // totalthismonth
            // 
            this.totalthismonth.AutoSize = true;
            this.totalthismonth.BackColor = System.Drawing.Color.DarkOrange;
            this.totalthismonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalthismonth.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalthismonth.Location = new System.Drawing.Point(12, 543);
            this.totalthismonth.Name = "totalthismonth";
            this.totalthismonth.Padding = new System.Windows.Forms.Padding(2);
            this.totalthismonth.Size = new System.Drawing.Size(109, 23);
            this.totalthismonth.TabIndex = 11;
            this.totalthismonth.Text = "Total Days";
            this.totalthismonth.Click += new System.EventHandler(this.Totalthismonth_Click);
            // 
            // Backbtn2
            // 
            this.Backbtn2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Backbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backbtn2.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn2.Location = new System.Drawing.Point(12, 17);
            this.Backbtn2.Name = "Backbtn2";
            this.Backbtn2.Size = new System.Drawing.Size(62, 31);
            this.Backbtn2.TabIndex = 12;
            this.Backbtn2.Text = "back";
            this.Backbtn2.UseVisualStyleBackColor = false;
            this.Backbtn2.Click += new System.EventHandler(this.Backbtn2_Click_1);
            // 
            // Empcombo
            // 
            this.Empcombo.BackColor = System.Drawing.Color.Gold;
            this.Empcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Empcombo.Enabled = false;
            this.Empcombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Empcombo.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empcombo.FormattingEnabled = true;
            this.Empcombo.Location = new System.Drawing.Point(267, 12);
            this.Empcombo.Name = "Empcombo";
            this.Empcombo.Size = new System.Drawing.Size(263, 25);
            this.Empcombo.TabIndex = 13;
            this.Empcombo.SelectedIndexChanged += new System.EventHandler(this.Empcombo_SelectedIndexChanged);
            // 
            // Monthcombo
            // 
            this.Monthcombo.BackColor = System.Drawing.Color.Gold;
            this.Monthcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Monthcombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Monthcombo.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthcombo.FormattingEnabled = true;
            this.Monthcombo.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.Monthcombo.Location = new System.Drawing.Point(318, 43);
            this.Monthcombo.Name = "Monthcombo";
            this.Monthcombo.Size = new System.Drawing.Size(132, 25);
            this.Monthcombo.TabIndex = 14;
            this.Monthcombo.SelectedIndexChanged += new System.EventHandler(this.Monthcombo_SelectedIndexChanged);
            // 
            // DeleteMonth
            // 
            this.DeleteMonth.BackColor = System.Drawing.Color.Red;
            this.DeleteMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteMonth.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMonth.Location = new System.Drawing.Point(467, 45);
            this.DeleteMonth.Name = "DeleteMonth";
            this.DeleteMonth.Size = new System.Drawing.Size(75, 23);
            this.DeleteMonth.TabIndex = 15;
            this.DeleteMonth.Text = "Delete";
            this.DeleteMonth.UseVisualStyleBackColor = false;
            this.DeleteMonth.Click += new System.EventHandler(this.DeleteMonth_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.BackColor = System.Drawing.Color.GreenYellow;
            this.Printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Printbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.Location = new System.Drawing.Point(225, 44);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(75, 23);
            this.Printbtn.TabIndex = 16;
            this.Printbtn.Text = "Print";
            this.Printbtn.UseVisualStyleBackColor = false;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // TableProgressBar
            // 
            this.TableProgressBar.Location = new System.Drawing.Point(311, 279);
            this.TableProgressBar.Name = "TableProgressBar";
            this.TableProgressBar.Size = new System.Drawing.Size(100, 23);
            this.TableProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.TableProgressBar.TabIndex = 21;
            this.TableProgressBar.Value = 50;
            this.TableProgressBar.Visible = false;
            // 
            // AttendanceTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(735, 583);
            this.Controls.Add(this.TableProgressBar);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.DeleteMonth);
            this.Controls.Add(this.Monthcombo);
            this.Controls.Add(this.Empcombo);
            this.Controls.Add(this.Backbtn2);
            this.Controls.Add(this.totalthismonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exitbtn2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendanceTableForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Tableform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbtn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalthismonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoliday;
        private System.Windows.Forms.Button Backbtn2;
        private System.Windows.Forms.ComboBox Empcombo;
        private System.Windows.Forms.ComboBox Monthcombo;
        private System.Windows.Forms.Button DeleteMonth;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.ProgressBar TableProgressBar;
    }
}