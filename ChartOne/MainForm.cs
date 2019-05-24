using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartOne
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         fillChart();
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
         this.textBox1.Text = "something";
      }

      private void fillChart()
      {
         //AddXY value in chart1 in series named as Salary  
         myChart.Series["Signal"].Points.AddXY("X1", "10000");
         myChart.Series["Signal"].Points.AddXY("X2", "8000");
         myChart.Series["Signal"].Points.AddXY("X3", "7000");
         myChart.Series["Signal"].Points.AddXY("X4", "10000");
         myChart.Series["Signal"].Points.AddXY("X5", "8500");
            //chart title  
            myChart.Titles.Add("Signal Chart");
      }
   }
}
