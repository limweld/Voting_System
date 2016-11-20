namespace Voting_System.Forms
{
    partial class ViceMayor
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox_Municipality = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 94);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            series1.XValueMember = "Candidate_id";
            series1.YValueMembers = "Votes";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(350, 238);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox_Municipality
            // 
            this.comboBox_Municipality.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBox_Municipality.FormattingEnabled = true;
            this.comboBox_Municipality.ItemHeight = 19;
            this.comboBox_Municipality.Location = new System.Drawing.Point(177, 63);
            this.comboBox_Municipality.Name = "comboBox_Municipality";
            this.comboBox_Municipality.Size = new System.Drawing.Size(196, 25);
            this.comboBox_Municipality.TabIndex = 66;
            this.comboBox_Municipality.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Municipality";
            // 
            // ViceMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 349);
            this.Controls.Add(this.comboBox_Municipality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Name = "ViceMayor";
            this.Text = "Vice Mayor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViceMayor_FormClosed);
            this.Load += new System.EventHandler(this.ViceMayor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroComboBox comboBox_Municipality;
        private MetroFramework.Controls.MetroLabel label6;

    }
}