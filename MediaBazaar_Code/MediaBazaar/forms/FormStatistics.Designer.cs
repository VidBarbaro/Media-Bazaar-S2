namespace MediaBazaar.forms
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelFormsContent = new System.Windows.Forms.Panel();
            this.chartEmployeesDepartment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbIdEmployee = new System.Windows.Forms.TextBox();
            this.btnStatisticsEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHoursWorked = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFormsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeesDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoursWorked)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormsContent
            // 
            this.panelFormsContent.Controls.Add(this.chartEmployeesDepartment);
            this.panelFormsContent.Controls.Add(this.tbIdEmployee);
            this.panelFormsContent.Controls.Add(this.btnStatisticsEmp);
            this.panelFormsContent.Controls.Add(this.label1);
            this.panelFormsContent.Controls.Add(this.chartGender);
            this.panelFormsContent.Controls.Add(this.chartHoursWorked);
            this.panelFormsContent.Location = new System.Drawing.Point(12, 13);
            this.panelFormsContent.Name = "panelFormsContent";
            this.panelFormsContent.Size = new System.Drawing.Size(1619, 629);
            this.panelFormsContent.TabIndex = 0;
            // 
            // chartEmployeesDepartment
            // 
            chartArea4.Name = "ChartArea1";
            this.chartEmployeesDepartment.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartEmployeesDepartment.Legends.Add(legend4);
            this.chartEmployeesDepartment.Location = new System.Drawing.Point(801, 332);
            this.chartEmployeesDepartment.Name = "chartEmployeesDepartment";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series4.Legend = "Legend1";
            series4.Name = "Number of employees per department";
            series4.YValuesPerPoint = 2;
            this.chartEmployeesDepartment.Series.Add(series4);
            this.chartEmployeesDepartment.Size = new System.Drawing.Size(618, 247);
            this.chartEmployeesDepartment.TabIndex = 33;
            this.chartEmployeesDepartment.Text = "chart1";
            // 
            // tbIdEmployee
            // 
            this.tbIdEmployee.Location = new System.Drawing.Point(57, 163);
            this.tbIdEmployee.Name = "tbIdEmployee";
            this.tbIdEmployee.Size = new System.Drawing.Size(287, 22);
            this.tbIdEmployee.TabIndex = 32;
            // 
            // btnStatisticsEmp
            // 
            this.btnStatisticsEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnStatisticsEmp.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisticsEmp.ForeColor = System.Drawing.Color.White;
            this.btnStatisticsEmp.Location = new System.Drawing.Point(365, 158);
            this.btnStatisticsEmp.Name = "btnStatisticsEmp";
            this.btnStatisticsEmp.Size = new System.Drawing.Size(159, 31);
            this.btnStatisticsEmp.TabIndex = 31;
            this.btnStatisticsEmp.Text = "See info";
            this.btnStatisticsEmp.UseVisualStyleBackColor = false;
            this.btnStatisticsEmp.Click += new System.EventHandler(this.btnStatisticsEmp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 72);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter the employee\'s ID to see \r\na complete overview ";
            // 
            // chartGender
            // 
            chartArea5.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGender.Legends.Add(legend5);
            this.chartGender.Location = new System.Drawing.Point(801, 28);
            this.chartGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartGender.Name = "chartGender";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Gender";
            this.chartGender.Series.Add(series5);
            this.chartGender.Size = new System.Drawing.Size(618, 252);
            this.chartGender.TabIndex = 29;
            this.chartGender.Text = "chart3";
            // 
            // chartHoursWorked
            // 
            chartArea6.Name = "ChartArea1";
            this.chartHoursWorked.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartHoursWorked.Legends.Add(legend6);
            this.chartHoursWorked.Location = new System.Drawing.Point(23, 332);
            this.chartHoursWorked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartHoursWorked.Name = "chartHoursWorked";
            this.chartHoursWorked.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.Legend = "Legend1";
            series6.Name = "Hours Worked";
            series6.XValueMember = "Employee";
            series6.YValueMembers = "Hours Worked";
            this.chartHoursWorked.Series.Add(series6);
            this.chartHoursWorked.Size = new System.Drawing.Size(541, 247);
            this.chartHoursWorked.TabIndex = 28;
            this.chartHoursWorked.Text = "chartHoursWorked";
            title2.Font = new System.Drawing.Font("Cambria", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            title2.Name = "Title1";
            title2.Text = "Top 4 employees based on hours worked";
            this.chartHoursWorked.Titles.Add(title2);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.panelFormsContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.panelFormsContent.ResumeLayout(false);
            this.panelFormsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeesDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoursWorked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormsContent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeesDepartment;
        private System.Windows.Forms.TextBox tbIdEmployee;
        private System.Windows.Forms.Button btnStatisticsEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoursWorked;
    }
}