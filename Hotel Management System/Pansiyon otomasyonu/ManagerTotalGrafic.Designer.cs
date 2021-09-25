
namespace Pansiyon_otomasyonu
{
    partial class ManagerTotalGrafic
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerTotalGrafic));
            this.ChrtGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChrtEmpty = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnExit = new System.Windows.Forms.Button();
            this.pansiyonDataSet = new Pansiyon_otomasyonu.PansiyonDataSet();
            this.pansiyonDataSet2 = new Pansiyon_otomasyonu.PansiyonDataSet2();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // ChrtGender
            // 
            chartArea1.Name = "ChartArea1";
            this.ChrtGender.ChartAreas.Add(chartArea1);
            this.ChrtGender.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChrtGender.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.ChrtGender.Legends.Add(legend1);
            this.ChrtGender.Location = new System.Drawing.Point(0, 0);
            this.ChrtGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChrtGender.Name = "ChrtGender";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Male-Female";
            this.ChrtGender.Series.Add(series1);
            this.ChrtGender.Size = new System.Drawing.Size(533, 364);
            this.ChrtGender.TabIndex = 0;
            this.ChrtGender.Text = "chart1";
            title1.Name = "Title1";
            this.ChrtGender.Titles.Add(title1);
            // 
            // ChrtEmpty
            // 
            chartArea2.Name = "ChartArea1";
            this.ChrtEmpty.ChartAreas.Add(chartArea2);
            this.ChrtEmpty.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.ChrtEmpty.Legends.Add(legend2);
            this.ChrtEmpty.Location = new System.Drawing.Point(539, 0);
            this.ChrtEmpty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChrtEmpty.Name = "ChrtEmpty";
            this.ChrtEmpty.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Empty Room - Full Room";
            this.ChrtEmpty.Series.Add(series2);
            this.ChrtEmpty.Size = new System.Drawing.Size(506, 364);
            this.ChrtEmpty.TabIndex = 1;
            this.ChrtEmpty.Text = "chart2";
            title2.Name = "Title1";
            this.ChrtEmpty.Titles.Add(title2);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.BackgroundImage")));
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(1007, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(39, 30);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pansiyonDataSet
            // 
            this.pansiyonDataSet.DataSetName = "PansiyonDataSet";
            this.pansiyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pansiyonDataSet2
            // 
            this.pansiyonDataSet2.DataSetName = "PansiyonDataSet2";
            this.pansiyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManagerTotalGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(1045, 364);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.ChrtGender);
            this.Controls.Add(this.ChrtEmpty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerTotalGrafic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManagerTotalGrafic";
            this.Load += new System.EventHandler(this.ManagerTotalGrafic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChrtGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pansiyonDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtEmpty;
        private System.Windows.Forms.Button BtnExit;
        private PansiyonDataSet pansiyonDataSet;
        private PansiyonDataSet2 pansiyonDataSet2;
    }
}