
namespace BmgManagerSheet
{
    partial class AttendanceControllerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceControllerForm));
            this.startendbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ControllerProgressBar = new System.Windows.Forms.ProgressBar();
            this.RamadanCB = new System.Windows.Forms.CheckBox();
            this.timeviewer = new System.Windows.Forms.DateTimePicker();
            this.dateview = new System.Windows.Forms.DateTimePicker();
            this.HolidayCB = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.startRadio = new System.Windows.Forms.RadioButton();
            this.endRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OptionalRadio = new System.Windows.Forms.RadioButton();
            this.allRadio = new System.Windows.Forms.RadioButton();
            this.selectRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Attendancebtn = new System.Windows.Forms.Button();
            this.OptionalCB = new System.Windows.Forms.ComboBox();
            this.Attendancebdbtn = new System.Windows.Forms.Button();
            this.DeleteDayBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startendbtn
            // 
            this.startendbtn.BackColor = System.Drawing.Color.Lime;
            this.startendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startendbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startendbtn.ForeColor = System.Drawing.Color.Black;
            this.startendbtn.Location = new System.Drawing.Point(303, 322);
            this.startendbtn.Name = "startendbtn";
            this.startendbtn.Size = new System.Drawing.Size(116, 51);
            this.startendbtn.TabIndex = 1;
            this.startendbtn.Text = "Start";
            this.startendbtn.UseVisualStyleBackColor = false;
            this.startendbtn.Click += new System.EventHandler(this.Startendbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.GhostWhite;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 22);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 31);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Red;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.exitbtn.Location = new System.Drawing.Point(526, 351);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(79, 26);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RamadanCB);
            this.panel1.Controls.Add(this.timeviewer);
            this.panel1.Controls.Add(this.dateview);
            this.panel1.Controls.Add(this.HolidayCB);
            this.panel1.Location = new System.Drawing.Point(150, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 139);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ControllerProgressBar
            // 
            this.ControllerProgressBar.Location = new System.Drawing.Point(506, 150);
            this.ControllerProgressBar.Name = "ControllerProgressBar";
            this.ControllerProgressBar.Size = new System.Drawing.Size(100, 23);
            this.ControllerProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ControllerProgressBar.TabIndex = 20;
            this.ControllerProgressBar.Value = 50;
            this.ControllerProgressBar.Visible = false;
            // 
            // RamadanCB
            // 
            this.RamadanCB.AutoSize = true;
            this.RamadanCB.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RamadanCB.Location = new System.Drawing.Point(30, 111);
            this.RamadanCB.Name = "RamadanCB";
            this.RamadanCB.Size = new System.Drawing.Size(170, 21);
            this.RamadanCB.TabIndex = 13;
            this.RamadanCB.Text = "Is it a Ramadan?";
            this.RamadanCB.UseVisualStyleBackColor = true;
            this.RamadanCB.CheckedChanged += new System.EventHandler(this.RamadanCB_CheckedChanged);
            // 
            // timeviewer
            // 
            this.timeviewer.CustomFormat = "HH:mm";
            this.timeviewer.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeviewer.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeviewer.Location = new System.Drawing.Point(136, 60);
            this.timeviewer.Name = "timeviewer";
            this.timeviewer.Size = new System.Drawing.Size(74, 24);
            this.timeviewer.TabIndex = 12;
            this.timeviewer.Value = new System.DateTime(2021, 8, 1, 9, 21, 0, 0);
            this.timeviewer.ValueChanged += new System.EventHandler(this.Timeviewer_ValueChanged);
            // 
            // dateview
            // 
            this.dateview.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateview.Location = new System.Drawing.Point(16, 16);
            this.dateview.Name = "dateview";
            this.dateview.Size = new System.Drawing.Size(304, 24);
            this.dateview.TabIndex = 11;
            this.dateview.Value = new System.DateTime(2021, 12, 14, 21, 21, 0, 0);
            this.dateview.ValueChanged += new System.EventHandler(this.Dateview_ValueChanged);
            // 
            // HolidayCB
            // 
            this.HolidayCB.AutoSize = true;
            this.HolidayCB.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolidayCB.Location = new System.Drawing.Point(30, 90);
            this.HolidayCB.Name = "HolidayCB";
            this.HolidayCB.Size = new System.Drawing.Size(162, 21);
            this.HolidayCB.TabIndex = 7;
            this.HolidayCB.Text = "Is it a Holiday?";
            this.HolidayCB.UseVisualStyleBackColor = true;
            this.HolidayCB.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gold;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // startRadio
            // 
            this.startRadio.AutoSize = true;
            this.startRadio.Checked = true;
            this.startRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRadio.Location = new System.Drawing.Point(0, 0);
            this.startRadio.Name = "startRadio";
            this.startRadio.Size = new System.Drawing.Size(74, 21);
            this.startRadio.TabIndex = 12;
            this.startRadio.TabStop = true;
            this.startRadio.Text = "Start";
            this.startRadio.UseVisualStyleBackColor = true;
            this.startRadio.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // endRadio
            // 
            this.endRadio.AutoSize = true;
            this.endRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endRadio.Location = new System.Drawing.Point(0, 22);
            this.endRadio.Name = "endRadio";
            this.endRadio.Size = new System.Drawing.Size(60, 21);
            this.endRadio.TabIndex = 13;
            this.endRadio.Text = "End";
            this.endRadio.UseVisualStyleBackColor = true;
            this.endRadio.CheckedChanged += new System.EventHandler(this.EndRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptionalRadio);
            this.groupBox1.Controls.Add(this.startRadio);
            this.groupBox1.Controls.Add(this.endRadio);
            this.groupBox1.Location = new System.Drawing.Point(264, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 74);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // OptionalRadio
            // 
            this.OptionalRadio.AutoSize = true;
            this.OptionalRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionalRadio.Location = new System.Drawing.Point(0, 44);
            this.OptionalRadio.Name = "OptionalRadio";
            this.OptionalRadio.Size = new System.Drawing.Size(103, 21);
            this.OptionalRadio.TabIndex = 14;
            this.OptionalRadio.Text = "Optional";
            this.OptionalRadio.UseVisualStyleBackColor = true;
            this.OptionalRadio.CheckedChanged += new System.EventHandler(this.OptionalRadio_CheckedChanged_1);
            // 
            // allRadio
            // 
            this.allRadio.AutoSize = true;
            this.allRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadio.Location = new System.Drawing.Point(7, -2);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(56, 21);
            this.allRadio.TabIndex = 10;
            this.allRadio.Text = "All";
            this.allRadio.UseVisualStyleBackColor = true;
            this.allRadio.CheckedChanged += new System.EventHandler(this.AllRadio_CheckedChanged);
            // 
            // selectRadio
            // 
            this.selectRadio.AutoSize = true;
            this.selectRadio.Checked = true;
            this.selectRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRadio.Location = new System.Drawing.Point(6, 21);
            this.selectRadio.Name = "selectRadio";
            this.selectRadio.Size = new System.Drawing.Size(83, 21);
            this.selectRadio.TabIndex = 11;
            this.selectRadio.TabStop = true;
            this.selectRadio.Text = "Select";
            this.selectRadio.UseVisualStyleBackColor = true;
            this.selectRadio.CheckedChanged += new System.EventHandler(this.SelectRadio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectRadio);
            this.groupBox2.Controls.Add(this.allRadio);
            this.groupBox2.Location = new System.Drawing.Point(491, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 43);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // Attendancebtn
            // 
            this.Attendancebtn.BackColor = System.Drawing.Color.Tomato;
            this.Attendancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Attendancebtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancebtn.ForeColor = System.Drawing.Color.Black;
            this.Attendancebtn.Location = new System.Drawing.Point(36, 233);
            this.Attendancebtn.Name = "Attendancebtn";
            this.Attendancebtn.Size = new System.Drawing.Size(125, 51);
            this.Attendancebtn.TabIndex = 16;
            this.Attendancebtn.Text = "Attendance";
            this.Attendancebtn.UseVisualStyleBackColor = false;
            this.Attendancebtn.Click += new System.EventHandler(this.Attendancebtn_Click);
            // 
            // OptionalCB
            // 
            this.OptionalCB.BackColor = System.Drawing.Color.Gold;
            this.OptionalCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionalCB.Enabled = false;
            this.OptionalCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OptionalCB.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionalCB.FormattingEnabled = true;
            this.OptionalCB.Items.AddRange(new object[] {
            "dayOff",
            "Annual Vacation",
            "Official Holiday",
            "Sickness",
            "workFromHome"});
            this.OptionalCB.Location = new System.Drawing.Point(373, 277);
            this.OptionalCB.Name = "OptionalCB";
            this.OptionalCB.Size = new System.Drawing.Size(194, 25);
            this.OptionalCB.TabIndex = 17;
            this.OptionalCB.SelectedIndexChanged += new System.EventHandler(this.OptionalCB_SelectedIndexChanged);
            // 
            // Attendancebdbtn
            // 
            this.Attendancebdbtn.BackColor = System.Drawing.Color.Yellow;
            this.Attendancebdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Attendancebdbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancebdbtn.ForeColor = System.Drawing.Color.Black;
            this.Attendancebdbtn.Location = new System.Drawing.Point(36, 304);
            this.Attendancebdbtn.Name = "Attendancebdbtn";
            this.Attendancebdbtn.Size = new System.Drawing.Size(125, 51);
            this.Attendancebdbtn.TabIndex = 18;
            this.Attendancebdbtn.Text = "Attendance By Day";
            this.Attendancebdbtn.UseVisualStyleBackColor = false;
            this.Attendancebdbtn.Click += new System.EventHandler(this.Attendancebdbtn_Click);
            // 
            // DeleteDayBtn
            // 
            this.DeleteDayBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.DeleteDayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteDayBtn.Font = new System.Drawing.Font("BankGothic Lt BT", 8F);
            this.DeleteDayBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteDayBtn.Location = new System.Drawing.Point(58, 103);
            this.DeleteDayBtn.Name = "DeleteDayBtn";
            this.DeleteDayBtn.Size = new System.Drawing.Size(86, 32);
            this.DeleteDayBtn.TabIndex = 19;
            this.DeleteDayBtn.Text = "Delete Day";
            this.DeleteDayBtn.UseVisualStyleBackColor = false;
            this.DeleteDayBtn.Click += new System.EventHandler(this.DeleteDayBtn_Click);
            // 
            // AttendanceControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 385);
            this.Controls.Add(this.DeleteDayBtn);
            this.Controls.Add(this.Attendancebdbtn);
            this.Controls.Add(this.OptionalCB);
            this.Controls.Add(this.ControllerProgressBar);
            this.Controls.Add(this.Attendancebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.startendbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttendanceControllerForm";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendanceform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startendbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox HolidayCB;
        private System.Windows.Forms.DateTimePicker dateview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker timeviewer;
        private System.Windows.Forms.RadioButton startRadio;
        private System.Windows.Forms.RadioButton endRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton allRadio;
        private System.Windows.Forms.RadioButton selectRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Attendancebtn;
        private System.Windows.Forms.CheckBox RamadanCB;
        private System.Windows.Forms.RadioButton OptionalRadio;
        private System.Windows.Forms.ComboBox OptionalCB;
        private System.Windows.Forms.Button Attendancebdbtn;
        private System.Windows.Forms.Button DeleteDayBtn;
        private System.Windows.Forms.ProgressBar ControllerProgressBar;
    }
}