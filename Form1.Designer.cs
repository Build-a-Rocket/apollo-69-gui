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
            this.components = new System.ComponentModel.Container();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.inputBoxSplit = new System.Windows.Forms.SplitContainer();
            this.inputLabel = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.outputBoxSplit = new System.Windows.Forms.SplitContainer();
            this.outputLabel = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.realTimeChart1 = new Apollo69GUI.RealTimeChart();
            this.realTimeChart2 = new Apollo69GUI.RealTimeChart();
            this.messagePanel.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputBoxSplit)).BeginInit();
            this.inputBoxSplit.Panel1.SuspendLayout();
            this.inputBoxSplit.Panel2.SuspendLayout();
            this.inputBoxSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputBoxSplit)).BeginInit();
            this.outputBoxSplit.Panel1.SuspendLayout();
            this.outputBoxSplit.Panel2.SuspendLayout();
            this.outputBoxSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messagePanel.Controls.Add(this.saveFileButton);
            this.messagePanel.Controls.Add(this.loadFileButton);
            this.messagePanel.Controls.Add(this.fileNameBox);
            this.messagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.messagePanel.Location = new System.Drawing.Point(0, 0);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(800, 38);
            this.messagePanel.TabIndex = 0;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(219, 9);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(75, 23);
            this.saveFileButton.TabIndex = 2;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(128, 9);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(12, 10);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(100, 20);
            this.fileNameBox.TabIndex = 0;
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Controls.Add(this.inputBoxSplit, 0, 1);
            this.tableLayout.Controls.Add(this.outputBoxSplit, 1, 1);
            this.tableLayout.Controls.Add(this.realTimeChart1, 0, 0);
            this.tableLayout.Controls.Add(this.realTimeChart2, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 38);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(800, 412);
            this.tableLayout.TabIndex = 1;
            // 
            // inputBoxSplit
            // 
            this.inputBoxSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBoxSplit.Location = new System.Drawing.Point(3, 209);
            this.inputBoxSplit.Name = "inputBoxSplit";
            this.inputBoxSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // inputBoxSplit.Panel1
            // 
            this.inputBoxSplit.Panel1.Controls.Add(this.inputLabel);
            this.inputBoxSplit.Panel1MinSize = 10;
            // 
            // inputBoxSplit.Panel2
            // 
            this.inputBoxSplit.Panel2.Controls.Add(this.inputBox);
            this.inputBoxSplit.Size = new System.Drawing.Size(394, 200);
            this.inputBoxSplit.SplitterDistance = 25;
            this.inputBoxSplit.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.BackColor = System.Drawing.Color.Black;
            this.inputLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(0, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.ReadOnly = true;
            this.inputLabel.Size = new System.Drawing.Size(394, 13);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input Box";
            this.inputLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBox
            // 
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.Location = new System.Drawing.Point(0, 0);
            this.inputBox.Margin = new System.Windows.Forms.Padding(0);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(394, 171);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            // 
            // outputBoxSplit
            // 
            this.outputBoxSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBoxSplit.Location = new System.Drawing.Point(403, 209);
            this.outputBoxSplit.Name = "outputBoxSplit";
            this.outputBoxSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // outputBoxSplit.Panel1
            // 
            this.outputBoxSplit.Panel1.Controls.Add(this.outputLabel);
            this.outputBoxSplit.Panel1MinSize = 10;
            // 
            // outputBoxSplit.Panel2
            // 
            this.outputBoxSplit.Panel2.Controls.Add(this.outputBox);
            this.outputBoxSplit.Size = new System.Drawing.Size(394, 200);
            this.outputBoxSplit.SplitterDistance = 25;
            this.outputBoxSplit.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(161, 2);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.ReadOnly = true;
            this.outputLabel.Size = new System.Drawing.Size(100, 13);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Ouput Box";
            // 
            // outputBox
            // 
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputBox.Location = new System.Drawing.Point(0, 0);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(394, 171);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // realTimeChart1
            // 
            this.realTimeChart1.BackColor = System.Drawing.Color.Gainsboro;
            this.realTimeChart1.Location = new System.Drawing.Point(0, 0);
            this.realTimeChart1.Margin = new System.Windows.Forms.Padding(0);
            this.realTimeChart1.Name = "realTimeChart1";
            this.realTimeChart1.Size = new System.Drawing.Size(400, 206);
            this.realTimeChart1.TabIndex = 2;
            // 
            // realTimeChart2
            // 
            this.realTimeChart2.BackColor = System.Drawing.Color.Gainsboro;
            this.realTimeChart2.Location = new System.Drawing.Point(400, 0);
            this.realTimeChart2.Margin = new System.Windows.Forms.Padding(0);
            this.realTimeChart2.Name = "realTimeChart2";
            this.realTimeChart2.Size = new System.Drawing.Size(400, 206);
            this.realTimeChart2.TabIndex = 3;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.messagePanel);
            this.Name = "GUI";
            this.Text = "Form1";
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.inputBoxSplit.Panel1.ResumeLayout(false);
            this.inputBoxSplit.Panel1.PerformLayout();
            this.inputBoxSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputBoxSplit)).EndInit();
            this.inputBoxSplit.ResumeLayout(false);
            this.outputBoxSplit.Panel1.ResumeLayout(false);
            this.outputBoxSplit.Panel1.PerformLayout();
            this.outputBoxSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputBoxSplit)).EndInit();
            this.outputBoxSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.SplitContainer inputBoxSplit;
        private System.Windows.Forms.TextBox inputLabel;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.SplitContainer outputBoxSplit;
        private System.Windows.Forms.TextBox outputLabel;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Timer timer1;
        private RealTimeChart realTimeChart1;
        private RealTimeChart realTimeChart2;
    }
}

