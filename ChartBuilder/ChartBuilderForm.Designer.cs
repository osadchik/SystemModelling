namespace ChartBuilder
{
    partial class ChartBuilderForm
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
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FirstMethodButton = new System.Windows.Forms.Button();
            this.SecondMethodButton = new System.Windows.Forms.Button();
            this.ThirdMethodButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DispersionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(34, 21);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(616, 391);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "MainChart";
            // 
            // FirstMethodButton
            // 
            this.FirstMethodButton.Location = new System.Drawing.Point(672, 31);
            this.FirstMethodButton.Name = "FirstMethodButton";
            this.FirstMethodButton.Size = new System.Drawing.Size(116, 40);
            this.FirstMethodButton.TabIndex = 1;
            this.FirstMethodButton.Text = "Run First Method";
            this.FirstMethodButton.UseVisualStyleBackColor = true;
            this.FirstMethodButton.Click += new System.EventHandler(this.FirstMethodButton_Click);
            // 
            // SecondMethodButton
            // 
            this.SecondMethodButton.Location = new System.Drawing.Point(672, 77);
            this.SecondMethodButton.Name = "SecondMethodButton";
            this.SecondMethodButton.Size = new System.Drawing.Size(116, 38);
            this.SecondMethodButton.TabIndex = 2;
            this.SecondMethodButton.Text = "Run Second Method";
            this.SecondMethodButton.UseVisualStyleBackColor = true;
            this.SecondMethodButton.Click += new System.EventHandler(this.SecondMethodButton_Click);
            // 
            // ThirdMethodButton
            // 
            this.ThirdMethodButton.Location = new System.Drawing.Point(672, 121);
            this.ThirdMethodButton.Name = "ThirdMethodButton";
            this.ThirdMethodButton.Size = new System.Drawing.Size(116, 40);
            this.ThirdMethodButton.TabIndex = 3;
            this.ThirdMethodButton.Text = "Run Third Method";
            this.ThirdMethodButton.UseVisualStyleBackColor = true;
            this.ThirdMethodButton.Click += new System.EventHandler(this.ThirdMethodButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Average:";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(672, 193);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(0, 13);
            this.AverageLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dispersion:";
            // 
            // DispersionLabel
            // 
            this.DispersionLabel.AutoSize = true;
            this.DispersionLabel.Location = new System.Drawing.Point(672, 249);
            this.DispersionLabel.Name = "DispersionLabel";
            this.DispersionLabel.Size = new System.Drawing.Size(0, 13);
            this.DispersionLabel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xi^2:";
            // 
            // ChiLabel
            // 
            this.ChiLabel.AutoSize = true;
            this.ChiLabel.Location = new System.Drawing.Point(672, 290);
            this.ChiLabel.Name = "ChiLabel";
            this.ChiLabel.Size = new System.Drawing.Size(0, 13);
            this.ChiLabel.TabIndex = 9;
            // 
            // ChartBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChiLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DispersionLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThirdMethodButton);
            this.Controls.Add(this.SecondMethodButton);
            this.Controls.Add(this.FirstMethodButton);
            this.Controls.Add(this.MainChart);
            this.Name = "ChartBuilderForm";
            this.Text = "ChartBuilderForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button FirstMethodButton;
        private System.Windows.Forms.Button SecondMethodButton;
        private System.Windows.Forms.Button ThirdMethodButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DispersionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ChiLabel;
    }
}

