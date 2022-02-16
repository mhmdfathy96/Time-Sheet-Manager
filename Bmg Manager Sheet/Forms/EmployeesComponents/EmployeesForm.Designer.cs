
namespace BmgManagerSheet
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.Addbtn = new System.Windows.Forms.Button();
            this.Empcombo = new System.Windows.Forms.ComboBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.AddnewRadio = new System.Windows.Forms.RadioButton();
            this.ExistingRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpFormProgressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.OfficeCombo = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.UserEdit = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Showbtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(495, 422);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(114, 57);
            this.Addbtn.TabIndex = 18;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Visible = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Empcombo
            // 
            this.Empcombo.BackColor = System.Drawing.Color.Gold;
            this.Empcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Empcombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Empcombo.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empcombo.FormattingEnabled = true;
            this.Empcombo.Location = new System.Drawing.Point(229, 42);
            this.Empcombo.Name = "Empcombo";
            this.Empcombo.Size = new System.Drawing.Size(263, 25);
            this.Empcombo.TabIndex = 17;
            this.Empcombo.SelectedIndexChanged += new System.EventHandler(this.Empcombo_SelectedIndexChanged);
            // 
            // codeBox
            // 
            this.codeBox.Enabled = false;
            this.codeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(12, 28);
            this.codeBox.MaxLength = 4;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(114, 26);
            this.codeBox.TabIndex = 19;
            // 
            // AddnewRadio
            // 
            this.AddnewRadio.AutoSize = true;
            this.AddnewRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddnewRadio.Location = new System.Drawing.Point(6, 36);
            this.AddnewRadio.Name = "AddnewRadio";
            this.AddnewRadio.Size = new System.Drawing.Size(62, 21);
            this.AddnewRadio.TabIndex = 11;
            this.AddnewRadio.Text = "Add";
            this.AddnewRadio.UseVisualStyleBackColor = true;
            this.AddnewRadio.CheckedChanged += new System.EventHandler(this.AddnewRadio_CheckedChanged);
            // 
            // ExistingRadio
            // 
            this.ExistingRadio.AutoSize = true;
            this.ExistingRadio.Checked = true;
            this.ExistingRadio.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingRadio.Location = new System.Drawing.Point(6, 0);
            this.ExistingRadio.Name = "ExistingRadio";
            this.ExistingRadio.Size = new System.Drawing.Size(94, 21);
            this.ExistingRadio.TabIndex = 10;
            this.ExistingRadio.TabStop = true;
            this.ExistingRadio.Text = "Existing";
            this.ExistingRadio.UseVisualStyleBackColor = true;
            this.ExistingRadio.CheckedChanged += new System.EventHandler(this.ExistingRadio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddnewRadio);
            this.groupBox2.Controls.Add(this.ExistingRadio);
            this.groupBox2.Location = new System.Drawing.Point(509, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 63);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.codeBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mailBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.GenerateButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.OfficeCombo);
            this.panel1.Controls.Add(this.GenderLabel);
            this.panel1.Controls.Add(this.GenderCombo);
            this.panel1.Location = new System.Drawing.Point(74, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 263);
            this.panel1.TabIndex = 22;
            // 
            // EmpFormProgressBar
            // 
            this.EmpFormProgressBar.Location = new System.Drawing.Point(267, 102);
            this.EmpFormProgressBar.Name = "EmpFormProgressBar";
            this.EmpFormProgressBar.Size = new System.Drawing.Size(96, 28);
            this.EmpFormProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.EmpFormProgressBar.TabIndex = 31;
            this.EmpFormProgressBar.Value = 50;
            this.EmpFormProgressBar.Visible = false;
            this.EmpFormProgressBar.Click += new System.EventHandler(this.TableProgressBar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Office";
            this.label5.Click += new System.EventHandler(this.OfficeLabel_Click);
            // 
            // OfficeCombo
            // 
            this.OfficeCombo.BackColor = System.Drawing.Color.Gold;
            this.OfficeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OfficeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OfficeCombo.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeCombo.FormattingEnabled = true;
            this.OfficeCombo.Items.AddRange(new object[] {
            "Cairo",
            "Mansoura"});
            this.OfficeCombo.Location = new System.Drawing.Point(292, 31);
            this.OfficeCombo.Name = "OfficeCombo";
            this.OfficeCombo.Size = new System.Drawing.Size(132, 25);
            this.OfficeCombo.TabIndex = 33;
            this.OfficeCombo.SelectedIndexChanged += new System.EventHandler(this.ComboOffice_SelectedIndexChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.LightGreen;
            this.GenerateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GenerateButton.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(180, 207);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(82, 25);
            this.GenerateButton.TabIndex = 32;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = false;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "e-Mail";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(289, 70);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(53, 16);
            this.GenderLabel.TabIndex = 22;
            this.GenderLabel.Text = "Gender";
            this.GenderLabel.Click += new System.EventHandler(this.GenderLabel_Click);
            // 
            // mailBox
            // 
            this.mailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBox.Location = new System.Drawing.Point(12, 147);
            this.mailBox.MaxLength = 50;
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(204, 26);
            this.mailBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // GenderCombo
            // 
            this.GenderCombo.BackColor = System.Drawing.Color.Gold;
            this.GenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GenderCombo.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCombo.Location = new System.Drawing.Point(292, 89);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(132, 25);
            this.GenderCombo.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(11, 207);
            this.PasswordBox.MaxLength = 10;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(165, 26);
            this.PasswordBox.TabIndex = 19;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(12, 89);
            this.nameBox.MaxLength = 25;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(204, 26);
            this.nameBox.TabIndex = 19;
            // 
            // UserEdit
            // 
            this.UserEdit.BackColor = System.Drawing.Color.GreenYellow;
            this.UserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserEdit.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEdit.Location = new System.Drawing.Point(256, 405);
            this.UserEdit.Name = "UserEdit";
            this.UserEdit.Size = new System.Drawing.Size(107, 48);
            this.UserEdit.TabIndex = 26;
            this.UserEdit.Text = "Edit";
            this.UserEdit.UseVisualStyleBackColor = false;
            this.UserEdit.Click += new System.EventHandler(this.UserEdit_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.GhostWhite;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(57, 31);
            this.backbtn.TabIndex = 28;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebtn.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(150, 42);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(73, 25);
            this.Deletebtn.TabIndex = 29;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Showbtn
            // 
            this.Showbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Showbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Showbtn.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showbtn.Location = new System.Drawing.Point(38, 439);
            this.Showbtn.Name = "Showbtn";
            this.Showbtn.Size = new System.Drawing.Size(114, 57);
            this.Showbtn.TabIndex = 30;
            this.Showbtn.Text = "Viewer";
            this.Showbtn.UseVisualStyleBackColor = false;
            this.Showbtn.Click += new System.EventHandler(this.Showbtn_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(633, 508);
            this.Controls.Add(this.EmpFormProgressBar);
            this.Controls.Add(this.Showbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.UserEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Empcombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ComboBox Empcombo;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.RadioButton AddnewRadio;
        private System.Windows.Forms.RadioButton ExistingRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button UserEdit;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Showbtn;
        private System.Windows.Forms.ProgressBar EmpFormProgressBar;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GenderCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OfficeCombo;
    }
}