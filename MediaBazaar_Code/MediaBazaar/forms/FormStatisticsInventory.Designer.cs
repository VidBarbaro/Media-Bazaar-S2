
namespace MediaBazaar.forms
{
    partial class FormStatisticsInventory
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelFormsContent = new System.Windows.Forms.Panel();
            this.btnStatisticsCategory = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartQuantSold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategoryQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFormsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormsContent
            // 
            this.panelFormsContent.Controls.Add(this.btnStatisticsCategory);
            this.panelFormsContent.Controls.Add(this.cbCategories);
            this.panelFormsContent.Controls.Add(this.label1);
            this.panelFormsContent.Controls.Add(this.chartQuantSold);
            this.panelFormsContent.Controls.Add(this.chartTopQuantity);
            this.panelFormsContent.Controls.Add(this.chartCategoryQuantity);
            this.panelFormsContent.Location = new System.Drawing.Point(2, 2);
            this.panelFormsContent.Name = "panelFormsContent";
            this.panelFormsContent.Size = new System.Drawing.Size(1134, 604);
            this.panelFormsContent.TabIndex = 0;
            // 
            // btnStatisticsCategory
            // 
            this.btnStatisticsCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnStatisticsCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisticsCategory.ForeColor = System.Drawing.Color.White;
            this.btnStatisticsCategory.Location = new System.Drawing.Point(347, 139);
            this.btnStatisticsCategory.Name = "btnStatisticsCategory";
            this.btnStatisticsCategory.Size = new System.Drawing.Size(159, 31);
            this.btnStatisticsCategory.TabIndex = 22;
            this.btnStatisticsCategory.Text = "See info";
            this.btnStatisticsCategory.UseVisualStyleBackColor = false;
            this.btnStatisticsCategory.Click += new System.EventHandler(this.btnStatisticsCategory_Click_1);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "LAPTOPS",
            "SPEAKERS",
            "GAMES",
            "CONSOLES",
            "HEADPHONE",
            "CABLES",
            "CHARGERS",
            "ACCESSORIES"});
            this.cbCategories.Location = new System.Drawing.Point(45, 139);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(278, 24);
            this.cbCategories.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 72);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select a category to see\r\n its complete overview";
            // 
            // chartQuantSold
            // 
            this.chartQuantSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea1.Name = "ChartArea1";
            this.chartQuantSold.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuantSold.Legends.Add(legend1);
            this.chartQuantSold.Location = new System.Drawing.Point(23, 330);
            this.chartQuantSold.Name = "chartQuantSold";
            this.chartQuantSold.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Products sold";
            this.chartQuantSold.Series.Add(series1);
            this.chartQuantSold.Size = new System.Drawing.Size(531, 240);
            this.chartQuantSold.TabIndex = 19;
            // 
            // chartTopQuantity
            // 
            this.chartTopQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea2.Name = "ChartArea1";
            this.chartTopQuantity.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopQuantity.Legends.Add(legend2);
            this.chartTopQuantity.Location = new System.Drawing.Point(578, 330);
            this.chartTopQuantity.Name = "chartTopQuantity";
            this.chartTopQuantity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Quantity";
            this.chartTopQuantity.Series.Add(series2);
            this.chartTopQuantity.Size = new System.Drawing.Size(534, 240);
            this.chartTopQuantity.TabIndex = 18;
            this.chartTopQuantity.Text = "chartBestSeller";
            title1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Top 5 Products based on the quantity";
            this.chartTopQuantity.Titles.Add(title1);
            // 
            // chartCategoryQuantity
            // 
            this.chartCategoryQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea3.Name = "ChartArea1";
            this.chartCategoryQuantity.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCategoryQuantity.Legends.Add(legend3);
            this.chartCategoryQuantity.Location = new System.Drawing.Point(578, 35);
            this.chartCategoryQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCategoryQuantity.Name = "chartCategoryQuantity";
            this.chartCategoryQuantity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "CategoryQuantity";
            series3.YValuesPerPoint = 4;
            this.chartCategoryQuantity.Series.Add(series3);
            this.chartCategoryQuantity.Size = new System.Drawing.Size(534, 263);
            this.chartCategoryQuantity.TabIndex = 17;
            this.chartCategoryQuantity.Text = "chart1";
            title2.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Number of products from each category";
            this.chartCategoryQuantity.Titles.Add(title2);
            // 
            // FormStatisticsInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1139, 607);
            this.Controls.Add(this.panelFormsContent);
            this.Name = "FormStatisticsInventory";
            this.Text = "FormStatisticsInventory";
            this.panelFormsContent.ResumeLayout(false);
            this.panelFormsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormsContent;
        private System.Windows.Forms.Button btnStatisticsCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantSold;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopQuantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryQuantity;
    }
}