namespace ChartOne
{
   partial class MainForm
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
         this.button1 = new System.Windows.Forms.Button();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
         ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(13, 14);
         this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(112, 35);
         this.button1.TabIndex = 0;
         this.button1.Text = "button1";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(133, 14);
         this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.Size = new System.Drawing.Size(148, 26);
         this.textBox1.TabIndex = 1;
         this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // myChart
         // 
         chartArea1.Name = "ChartArea1";
         this.myChart.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.myChart.Legends.Add(legend1);
         this.myChart.Location = new System.Drawing.Point(13, 100);
         this.myChart.Name = "myChart";
         series1.ChartArea = "ChartArea1";
         series1.Legend = "Legend1";
         series1.Name = "Signal";
         this.myChart.Series.Add(series1);
         this.myChart.Size = new System.Drawing.Size(688, 300);
         this.myChart.TabIndex = 2;
         this.myChart.Text = "MyChart";
         // 
         // MainForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.ClientSize = new System.Drawing.Size(784, 417);
         this.Controls.Add(this.myChart);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.button1);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MainForm";
         this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
         this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
         this.Text = "ChartOne";
         this.Load += new System.EventHandler(this.MainForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
    }
}

