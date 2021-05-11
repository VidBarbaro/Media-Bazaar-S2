namespace MediaBazaar.forms
{
    partial class FormAddEmployee
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
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.tbHourlyWage = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHolidayDays = new System.Windows.Forms.Label();
            this.tbHolidayDays = new System.Windows.Forms.TextBox();
            this.lblSickDays = new System.Windows.Forms.Label();
            this.tbSickDays = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(64)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(31, 456);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(364, 31);
            this.btnAddEmployee.TabIndex = 42;
            this.btnAddEmployee.Text = "Add New Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(175, 129);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(220, 24);
            this.cbGender.TabIndex = 41;
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(175, 236);
            this.tbHoursWorked.MaxLength = 7;
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(220, 22);
            this.tbHoursWorked.TabIndex = 40;
            // 
            // tbHourlyWage
            // 
            this.tbHourlyWage.Location = new System.Drawing.Point(175, 210);
            this.tbHourlyWage.MaxLength = 7;
            this.tbHourlyWage.Name = "tbHourlyWage";
            this.tbHourlyWage.Size = new System.Drawing.Size(220, 22);
            this.tbHourlyWage.TabIndex = 39;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(175, 183);
            this.tbAddress.MaxLength = 29;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(220, 22);
            this.tbAddress.TabIndex = 38;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(175, 157);
            this.tbPhoneNumber.MaxLength = 10;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(220, 22);
            this.tbPhoneNumber.TabIndex = 37;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(175, 101);
            this.tbEmail.MaxLength = 199;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(220, 22);
            this.tbEmail.TabIndex = 36;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(175, 49);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(220, 22);
            this.tbPassword.TabIndex = 34;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(175, 22);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 22);
            this.tbName.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Hours Worked:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Hourly Wage:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Address:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(25, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // lblHolidayDays
            // 
            this.lblHolidayDays.AutoSize = true;
            this.lblHolidayDays.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHolidayDays.ForeColor = System.Drawing.Color.White;
            this.lblHolidayDays.Location = new System.Drawing.Point(24, 263);
            this.lblHolidayDays.Name = "lblHolidayDays";
            this.lblHolidayDays.Size = new System.Drawing.Size(114, 20);
            this.lblHolidayDays.TabIndex = 43;
            this.lblHolidayDays.Text = "Holiday Days:";
            // 
            // tbHolidayDays
            // 
            this.tbHolidayDays.Location = new System.Drawing.Point(175, 264);
            this.tbHolidayDays.MaxLength = 3;
            this.tbHolidayDays.Name = "tbHolidayDays";
            this.tbHolidayDays.Size = new System.Drawing.Size(220, 22);
            this.tbHolidayDays.TabIndex = 44;
            // 
            // lblSickDays
            // 
            this.lblSickDays.AutoSize = true;
            this.lblSickDays.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSickDays.ForeColor = System.Drawing.Color.White;
            this.lblSickDays.Location = new System.Drawing.Point(25, 291);
            this.lblSickDays.Name = "lblSickDays";
            this.lblSickDays.Size = new System.Drawing.Size(87, 20);
            this.lblSickDays.TabIndex = 45;
            this.lblSickDays.Text = "Sick Days:";
            // 
            // tbSickDays
            // 
            this.tbSickDays.Location = new System.Drawing.Point(175, 292);
            this.tbSickDays.MaxLength = 3;
            this.tbSickDays.Name = "tbSickDays";
            this.tbSickDays.Size = new System.Drawing.Size(220, 22);
            this.tbSickDays.TabIndex = 46;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBirthday.ForeColor = System.Drawing.Color.White;
            this.lblBirthday.Location = new System.Drawing.Point(40, 394);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(81, 20);
            this.lblBirthday.TabIndex = 47;
            this.lblBirthday.Text = "Birthday:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(188, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(251, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Month";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(347, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Year";
            // 
            // tbDay
            // 
            this.tbDay.Location = new System.Drawing.Point(175, 394);
            this.tbDay.MaxLength = 2;
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(46, 22);
            this.tbDay.TabIndex = 51;
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(254, 394);
            this.tbMonth.MaxLength = 2;
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(43, 22);
            this.tbMonth.TabIndex = 52;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(326, 394);
            this.tbYear.MaxLength = 4;
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(69, 22);
            this.tbYear.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(308, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Department:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(175, 321);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(220, 24);
            this.cbDepartment.TabIndex = 57;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(418, 512);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.tbSickDays);
            this.Controls.Add(this.lblSickDays);
            this.Controls.Add(this.tbHolidayDays);
            this.Controls.Add(this.lblHolidayDays);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbHoursWorked);
            this.Controls.Add(this.tbHourlyWage);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddEmployee";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.TextBox tbHourlyWage;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHolidayDays;
        private System.Windows.Forms.TextBox tbHolidayDays;
        private System.Windows.Forms.Label lblSickDays;
        private System.Windows.Forms.TextBox tbSickDays;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDepartment;
    }
}