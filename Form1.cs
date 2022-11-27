using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Apollo69GUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();

            realTimeChart1.SetTitle("Random Data 1");
            realTimeChart1.AddChart("Points", "Number", "Random", SeriesChartType.FastLine);

            realTimeChart2.SetTitle("Random Data 2");
            realTimeChart2.AddChart("Points", "Number", "Random", SeriesChartType.FastLine);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string path = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                FileNameBox.Text = path;
            }
            
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');
                
                realTimeChart1.AddPoint(data[0], data[1], "Random");
                realTimeChart2.AddPoint(data[2], data[3], "Random");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DataPointsBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
