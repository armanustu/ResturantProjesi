namespace Resturant
{
    partial class MasaRaporları
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasaRaporları));
            this.button6 = new System.Windows.Forms.Button();
            this.LstMasalar = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.masalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resturantDataSet = new Resturant.ResturantDataSet();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.masalarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masalarTableAdapter = new Resturant.ResturantDataSetTableAdapters.MasalarTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(12, 443);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 59);
            this.button6.TabIndex = 44;
            this.button6.Text = "Masa Raporunu Getir";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // LstMasalar
            // 
            this.LstMasalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.LstMasalar.GridLines = true;
            this.LstMasalar.HideSelection = false;
            this.LstMasalar.Location = new System.Drawing.Point(12, 40);
            this.LstMasalar.Name = "LstMasalar";
            this.LstMasalar.Size = new System.Drawing.Size(394, 401);
            this.LstMasalar.TabIndex = 43;
            this.LstMasalar.UseCompatibleStateImageBehavior = false;
            this.LstMasalar.View = System.Windows.Forms.View.Details;
            this.LstMasalar.SelectedIndexChanged += new System.EventHandler(this.LstMasalar_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MasaID";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MasaAdi";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tutar";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Saat";
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dakika";
            // 
            // masalarBindingSource
            // 
            this.masalarBindingSource.DataMember = "Masalar";
            this.masalarBindingSource.DataSource = this.resturantDataSet;
            // 
            // resturantDataSet
            // 
            this.resturantDataSet.DataSetName = "ResturantDataSet";
            this.resturantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart2
            // 
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masalarBindingSource, "Tutar", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.chart2.DataSource = this.masalarBindingSource1;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(996, 40);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Black;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.XValueMember = "MasaAdi";
            series1.YValueMembers = "Tutar";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(349, 444);
            this.chart2.TabIndex = 46;
            this.chart2.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Masalara Ait Tutar Dağılımı";
            this.chart2.Titles.Add(title1);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // masalarBindingSource1
            // 
            this.masalarBindingSource1.DataMember = "Masalar";
            this.masalarBindingSource1.DataSource = this.resturantDataSet;
            // 
            // masalarTableAdapter
            // 
            this.masalarTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.masalarBindingSource;
            this.comboBox1.DisplayMember = "MasaAdi";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.ValueMember = "MasaAdi";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(327, 20);
            this.dateTimePicker1.TabIndex = 48;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "MasaAdi";
            chartArea2.AxisY.Title = "Tutar";
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masalarBindingSource, "Tutar", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "C2"));
            this.chart1.DataSource = this.masalarBindingSource;
            legend2.BackColor = System.Drawing.Color.Yellow;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(412, 40);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Navy;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ShadowColor = System.Drawing.Color.White;
            series2.XValueMember = "MasaAdi";
            series2.YValueMembers = "Tutar";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(578, 344);
            this.chart1.TabIndex = 51;
            this.chart1.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Masalara Ait Tuatar Dağılımı";
            this.chart1.Titles.Add(title2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Masaları satış indexleri  :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(143, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 59);
            this.button1.TabIndex = 53;
            this.button1.Text = "Tüm Listeler Getir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MasaRaporları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1336, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.LstMasalar);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masalarBindingSource, "Tutar", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.Name = "MasaRaporları";
            this.Text = "Masa Raporları";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masalarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private ResturantDataSet resturantDataSet;
        private System.Windows.Forms.BindingSource masalarBindingSource;
        private ResturantDataSetTableAdapters.MasalarTableAdapter masalarTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource masalarBindingSource1;
        public System.Windows.Forms.ListView LstMasalar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
    }
}