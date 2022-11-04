﻿using System;
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

        Random r;

        public GUI()
        {
            InitializeComponent();

            realTimeChart1.SetTitle("Random Data 1");
            realTimeChart1.AddChart("Points", "Number", "Random", SeriesChartType.FastLine);

            realTimeChart2.SetTitle("Random Data 2");
            realTimeChart2.AddChart("Points", "Number", "Random", SeriesChartType.FastLine);

            r = new Random();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(fileNameBox.Text);

            foreach (string line in lines)
            {
                outputBox.AppendText(line + "\r\n");
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileNameBox.Text, inputBox.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            realTimeChart1.AddPoint(0, r.NextDouble(), "Random");
            realTimeChart2.AddPoint(0, r.NextDouble(), "Random");
        }
    }
}
