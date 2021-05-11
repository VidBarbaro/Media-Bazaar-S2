
namespace MediaBazaar.forms
{
    partial class FormStatisticsDep
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAttendence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendence)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(32, 182);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 33);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "<Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPersonel.ForeColor = System.Drawing.Color.White;
            this.lblPersonel.Location = new System.Drawing.Point(312, 120);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(62, 23);
            this.lblPersonel.TabIndex = 20;
            this.lblPersonel.Text = "label7";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmp.ForeColor = System.Drawing.Color.White;
            this.lblEmp.Location = new System.Drawing.Point(162, 81);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(62, 23);
            this.lblEmp.TabIndex = 19;
            this.lblEmp.Text = "label6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of required personel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // chartGender
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGender.Legends.Add(legend1);
            this.chartGender.Location = new System.Drawing.Point(874, 271);
            this.chartGender.Name = "chartGender";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.chartGender.Series.Add(series1);
            this.chartGender.Size = new System.Drawing.Size(355, 260);
            this.chartGender.TabIndex = 24;
            this.chartGender.Text = "chart1";
            // 
            // chartAttendence
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAttendence.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAttendence.Legends.Add(legend2);
            this.chartAttendence.Location = new System.Drawing.Point(32, 281);
            this.chartAttendence.Name = "chartAttendence";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Present";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Free";
            this.chartAttendence.Series.Add(series2);
            this.chartAttendence.Series.Add(series3);
            this.chartAttendence.Size = new System.Drawing.Size(783, 250);
            this.chartAttendence.TabIndex = 25;
            this.chartAttendence.Text = "chart1";
            // 
            // FormStatisticsDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1250, 543);
            this.Controls.Add(this.chartAttendence);
            this.Controls.Add(this.chartGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPersonel);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStatisticsDep";
            this.Text = "Statistics Per Department";
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendence;
    }
}