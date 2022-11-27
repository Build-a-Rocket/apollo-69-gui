namespace Apollo69GUI
{
    partial class GUI
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
            this.ControlGraphSplit = new System.Windows.Forms.SplitContainer();
            this.GraphSplit = new System.Windows.Forms.SplitContainer();
            this.realTimeChart1 = new Apollo69GUI.RealTimeChart();
            this.realTimeChart2 = new Apollo69GUI.RealTimeChart();
            this.ControlFeedSplit = new System.Windows.Forms.SplitContainer();
            this.DataPointsBox = new System.Windows.Forms.RichTextBox();
            this.ConsoleLabel = new System.Windows.Forms.TextBox();
            this.FilePanel = new System.Windows.Forms.Panel();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.OpenFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ControlGraphSplit)).BeginInit();
            this.ControlGraphSplit.Panel1.SuspendLayout();
            this.ControlGraphSplit.Panel2.SuspendLayout();
            this.ControlGraphSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphSplit)).BeginInit();
            this.GraphSplit.Panel1.SuspendLayout();
            this.GraphSplit.Panel2.SuspendLayout();
            this.GraphSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlFeedSplit)).BeginInit();
            this.ControlFeedSplit.Panel2.SuspendLayout();
            this.ControlFeedSplit.SuspendLayout();
            this.FilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlGraphSplit
            // 
            this.ControlGraphSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlGraphSplit.Location = new System.Drawing.Point(0, 0);
            this.ControlGraphSplit.Margin = new System.Windows.Forms.Padding(2);
            this.ControlGraphSplit.Name = "ControlGraphSplit";
            // 
            // ControlGraphSplit.Panel1
            // 
            this.ControlGraphSplit.Panel1.Controls.Add(this.GraphSplit);
            // 
            // ControlGraphSplit.Panel2
            // 
            this.ControlGraphSplit.Panel2.Controls.Add(this.ControlFeedSplit);
            this.ControlGraphSplit.Size = new System.Drawing.Size(752, 450);
            this.ControlGraphSplit.SplitterDistance = 485;
            this.ControlGraphSplit.SplitterWidth = 2;
            this.ControlGraphSplit.TabIndex = 0;
            // 
            // GraphSplit
            // 
            this.GraphSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphSplit.Location = new System.Drawing.Point(0, 0);
            this.GraphSplit.Margin = new System.Windows.Forms.Padding(2);
            this.GraphSplit.Name = "GraphSplit";
            this.GraphSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // GraphSplit.Panel1
            // 
            this.GraphSplit.Panel1.Controls.Add(this.realTimeChart1);
            // 
            // GraphSplit.Panel2
            // 
            this.GraphSplit.Panel2.Controls.Add(this.realTimeChart2);
            this.GraphSplit.Size = new System.Drawing.Size(485, 450);
            this.GraphSplit.SplitterDistance = 220;
            this.GraphSplit.SplitterWidth = 2;
            this.GraphSplit.TabIndex = 0;
            // 
            // realTimeChart1
            // 
            this.realTimeChart1.AutoSize = true;
            this.realTimeChart1.BackColor = System.Drawing.Color.Gainsboro;
            this.realTimeChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realTimeChart1.Location = new System.Drawing.Point(0, 0);
            this.realTimeChart1.Margin = new System.Windows.Forms.Padding(0);
            this.realTimeChart1.Name = "realTimeChart1";
            this.realTimeChart1.Size = new System.Drawing.Size(485, 220);
            this.realTimeChart1.TabIndex = 0;
            // 
            // realTimeChart2
            // 
            this.realTimeChart2.BackColor = System.Drawing.Color.Gainsboro;
            this.realTimeChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realTimeChart2.Location = new System.Drawing.Point(0, 0);
            this.realTimeChart2.Margin = new System.Windows.Forms.Padding(0);
            this.realTimeChart2.Name = "realTimeChart2";
            this.realTimeChart2.Size = new System.Drawing.Size(485, 228);
            this.realTimeChart2.TabIndex = 0;
            // 
            // ControlFeedSplit
            // 
            this.ControlFeedSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlFeedSplit.Location = new System.Drawing.Point(0, 0);
            this.ControlFeedSplit.Margin = new System.Windows.Forms.Padding(2);
            this.ControlFeedSplit.Name = "ControlFeedSplit";
            this.ControlFeedSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ControlFeedSplit.Panel2
            // 
            this.ControlFeedSplit.Panel2.Controls.Add(this.DataPointsBox);
            this.ControlFeedSplit.Panel2.Controls.Add(this.ConsoleLabel);
            this.ControlFeedSplit.Panel2.Controls.Add(this.FilePanel);
            this.ControlFeedSplit.Size = new System.Drawing.Size(265, 450);
            this.ControlFeedSplit.SplitterDistance = 243;
            this.ControlFeedSplit.SplitterWidth = 2;
            this.ControlFeedSplit.TabIndex = 0;
            // 
            // DataPointsBox
            // 
            this.DataPointsBox.BackColor = System.Drawing.Color.Black;
            this.DataPointsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPointsBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPointsBox.ForeColor = System.Drawing.Color.White;
            this.DataPointsBox.HideSelection = false;
            this.DataPointsBox.Location = new System.Drawing.Point(0, 59);
            this.DataPointsBox.Margin = new System.Windows.Forms.Padding(2);
            this.DataPointsBox.Name = "DataPointsBox";
            this.DataPointsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.DataPointsBox.Size = new System.Drawing.Size(265, 146);
            this.DataPointsBox.TabIndex = 1;
            this.DataPointsBox.Text = "";
            this.DataPointsBox.TextChanged += new System.EventHandler(this.DataPointsBox_TextChanged);
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.BackColor = System.Drawing.Color.Black;
            this.ConsoleLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsoleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLabel.ForeColor = System.Drawing.Color.White;
            this.ConsoleLabel.Location = new System.Drawing.Point(0, 32);
            this.ConsoleLabel.Multiline = true;
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.ReadOnly = true;
            this.ConsoleLabel.Size = new System.Drawing.Size(265, 27);
            this.ConsoleLabel.TabIndex = 1;
            this.ConsoleLabel.Text = "Console";
            // 
            // FilePanel
            // 
            this.FilePanel.Controls.Add(this.FileNameBox);
            this.FilePanel.Controls.Add(this.OpenFileButton);
            this.FilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilePanel.Location = new System.Drawing.Point(0, 0);
            this.FilePanel.Margin = new System.Windows.Forms.Padding(2);
            this.FilePanel.Name = "FilePanel";
            this.FilePanel.Size = new System.Drawing.Size(265, 32);
            this.FilePanel.TabIndex = 0;
            // 
            // FileNameBox
            // 
            this.FileNameBox.BackColor = System.Drawing.Color.Black;
            this.FileNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNameBox.ForeColor = System.Drawing.Color.White;
            this.FileNameBox.Location = new System.Drawing.Point(0, 0);
            this.FileNameBox.Multiline = true;
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(189, 32);
            this.FileNameBox.TabIndex = 0;
            this.FileNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.BackColor = System.Drawing.Color.White;
            this.OpenFileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OpenFileButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileButton.ForeColor = System.Drawing.Color.Black;
            this.OpenFileButton.Location = new System.Drawing.Point(189, 0);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(76, 32);
            this.OpenFileButton.TabIndex = 1;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = false;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.ControlGraphSplit);
            this.MinimumSize = new System.Drawing.Size(768, 489);
            this.Name = "GUI";
            this.Text = "Form1";
            this.ControlGraphSplit.Panel1.ResumeLayout(false);
            this.ControlGraphSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ControlGraphSplit)).EndInit();
            this.ControlGraphSplit.ResumeLayout(false);
            this.GraphSplit.Panel1.ResumeLayout(false);
            this.GraphSplit.Panel1.PerformLayout();
            this.GraphSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GraphSplit)).EndInit();
            this.GraphSplit.ResumeLayout(false);
            this.ControlFeedSplit.Panel2.ResumeLayout(false);
            this.ControlFeedSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlFeedSplit)).EndInit();
            this.ControlFeedSplit.ResumeLayout(false);
            this.FilePanel.ResumeLayout(false);
            this.FilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer ControlGraphSplit;
        private System.Windows.Forms.SplitContainer GraphSplit;
        private System.Windows.Forms.SplitContainer ControlFeedSplit;
        private System.Windows.Forms.RichTextBox DataPointsBox;
        private System.Windows.Forms.Panel FilePanel;
        private System.Windows.Forms.Button OpenFileButton;
        private RealTimeChart realTimeChart1;
        private RealTimeChart realTimeChart2;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.TextBox ConsoleLabel;
    }
}

