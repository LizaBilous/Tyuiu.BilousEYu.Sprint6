namespace Tyuiu.BilousEYu.Sprint6.Task4.V21
{
    partial class FromMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_IPG = new GroupBox();
            textBox1 = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            textBoxResult_IPG = new TextBox();
            groupBoxInput_IPG = new GroupBox();
            textBoxEnd_IPG = new TextBox();
            textBoxStart_IPG = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            buttonDone_IPG = new Button();
            buttonSave_IPG = new Button();
            buttonReference_IPG = new Button();
            chartFunction_IPG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxCondition_IPG.SuspendLayout();
            groupBoxOutput_IPG.SuspendLayout();
            groupBoxInput_IPG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_IPG).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBox1);
            groupBoxCondition_IPG.Location = new Point(12, 31);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(968, 228);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(22, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(972, 204);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(textBoxResult_IPG);
            groupBoxOutput_IPG.Location = new Point(12, 216);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Size = new Size(576, 544);
            groupBoxOutput_IPG.TabIndex = 1;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывод:";
            // 
            // textBoxResult_IPG
            // 
            textBoxResult_IPG.Location = new Point(11, 37);
            textBoxResult_IPG.Multiline = true;
            textBoxResult_IPG.Name = "textBoxResult_IPG";
            textBoxResult_IPG.Size = new Size(404, 507);
            textBoxResult_IPG.TabIndex = 0;
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(textBoxEnd_IPG);
            groupBoxInput_IPG.Controls.Add(textBoxStart_IPG);
            groupBoxInput_IPG.Controls.Add(textBox3);
            groupBoxInput_IPG.Controls.Add(textBox2);
            groupBoxInput_IPG.Location = new Point(986, 48);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Size = new Size(360, 236);
            groupBoxInput_IPG.TabIndex = 2;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Вывод данных:";
            // 
            // textBoxEnd_IPG
            // 
            textBoxEnd_IPG.Location = new Point(183, 76);
            textBoxEnd_IPG.Name = "textBoxEnd_IPG";
            textBoxEnd_IPG.Size = new Size(134, 39);
            textBoxEnd_IPG.TabIndex = 3;
            // 
            // textBoxStart_IPG
            // 
            textBoxStart_IPG.Location = new Point(6, 76);
            textBoxStart_IPG.Name = "textBoxStart_IPG";
            textBoxStart_IPG.Size = new Size(133, 39);
            textBoxStart_IPG.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(183, 38);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(200, 32);
            textBox3.TabIndex = 1;
            textBox3.Text = "Конец шага";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 38);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(200, 32);
            textBox2.TabIndex = 0;
            textBox2.Text = "Старт шага";
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_IPG.Location = new Point(1372, 67);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(164, 217);
            buttonDone_IPG.TabIndex = 3;
            buttonDone_IPG.Text = "Выполнить";
            buttonDone_IPG.UseVisualStyleBackColor = false;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // buttonSave_IPG
            // 
            buttonSave_IPG.BackColor = Color.FromArgb(255, 128, 255);
            buttonSave_IPG.Location = new Point(1560, 67);
            buttonSave_IPG.Name = "buttonSave_IPG";
            buttonSave_IPG.Size = new Size(172, 217);
            buttonSave_IPG.TabIndex = 4;
            buttonSave_IPG.Text = "Сохранить";
            buttonSave_IPG.UseVisualStyleBackColor = false;
            buttonSave_IPG.Click += buttonSave_IPG_Click;
            // 
            // buttonReference_IPG
            // 
            buttonReference_IPG.BackColor = Color.FromArgb(255, 192, 128);
            buttonReference_IPG.Location = new Point(1771, 67);
            buttonReference_IPG.Name = "buttonReference_IPG";
            buttonReference_IPG.Size = new Size(151, 217);
            buttonReference_IPG.TabIndex = 5;
            buttonReference_IPG.Text = "Справка";
            buttonReference_IPG.UseVisualStyleBackColor = false;
            buttonReference_IPG.Click += buttonReference_IPG_Click;
            // 
            // chartFunction_IPG
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_IPG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_IPG.Legends.Add(legend1);
            chartFunction_IPG.Location = new Point(986, 290);
            chartFunction_IPG.Name = "chartFunction_IPG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_IPG.Series.Add(series1);
            chartFunction_IPG.Size = new Size(1007, 434);
            chartFunction_IPG.TabIndex = 6;
            chartFunction_IPG.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2005, 772);
            Controls.Add(chartFunction_IPG);
            Controls.Add(buttonReference_IPG);
            Controls.Add(buttonSave_IPG);
            Controls.Add(buttonDone_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4| Вариант 21| Билоус Е.Ю.";
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            groupBoxInput_IPG.ResumeLayout(false);
            groupBoxInput_IPG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_IPG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private GroupBox groupBoxOutput_IPG;
        private GroupBox groupBoxInput_IPG;
        private TextBox textBox1;
        private TextBox textBoxEnd_IPG;
        private TextBox textBoxStart_IPG;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button buttonDone_IPG;
        private Button buttonSave_IPG;
        private Button buttonReference_IPG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_IPG;
        private TextBox textBoxResult_IPG;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FromMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "FromMain";
            Text = "Form1";
            Load += this.FromMain_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
