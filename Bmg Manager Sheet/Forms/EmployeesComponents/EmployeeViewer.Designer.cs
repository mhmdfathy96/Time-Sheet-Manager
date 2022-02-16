
namespace BmgManagerSheet
{
    partial class EmployeeViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeViewer));
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.Backbtn2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpDGV
            // 
            this.EmpDGV.AllowUserToAddRows = false;
            this.EmpDGV.AllowUserToDeleteRows = false;
            this.EmpDGV.AllowUserToOrderColumns = true;
            this.EmpDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStart,
            this.colDate,
            this.colEnd,
            this.gender,
            this.Office});
            this.EmpDGV.Location = new System.Drawing.Point(46, 76);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.ReadOnly = true;
            this.EmpDGV.Size = new System.Drawing.Size(583, 355);
            this.EmpDGV.TabIndex = 11;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "BMG Employees";
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Name";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            this.colStart.Width = 150;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Code";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 50;
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "Email";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            this.colEnd.Width = 150;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // Office
            // 
            this.Office.HeaderText = "Office";
            this.Office.Name = "Office";
            this.Office.ReadOnly = true;
            // 
            // EmployeeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(655, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbtn2);
            this.Controls.Add(this.EmpDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeViewer";
            this.Text = "Employees Viewer";
            this.Load += new System.EventHandler(this.EmployeeViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpDGV;
        private System.Windows.Forms.Button Backbtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
    }
}