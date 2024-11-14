namespace FunctionGrapher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxFunctions;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;

        private void InitializeComponent()
        {
            this.comboBoxFunctions = new System.Windows.Forms.ComboBox();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();

            // comboBoxFunctions
            this.comboBoxFunctions.FormattingEnabled = true;
            this.comboBoxFunctions.Location = new System.Drawing.Point(20, 20);
            this.comboBoxFunctions.Name = "comboBoxFunctions";
            this.comboBoxFunctions.Size = new System.Drawing.Size(200, 21);

            // buttonPlot
            this.buttonPlot.Location = new System.Drawing.Point(230, 20);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(100, 23);
            this.buttonPlot.Text = "Построить график";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);

            // chartFunction
            this.chartFunction.Location = new System.Drawing.Point(20, 60);
            this.chartFunction.Name = "chartFunction";
            this.chartFunction.Size = new System.Drawing.Size(500, 300);
            this.chartFunction.TabIndex = 2;

            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.chartFunction.ChartAreas.Add(chartArea);
            var series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            this.chartFunction.Series.Add(series);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.comboBoxFunctions);
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.chartFunction);
            this.Name = "Form1";
            this.Text = "Графики функций";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
