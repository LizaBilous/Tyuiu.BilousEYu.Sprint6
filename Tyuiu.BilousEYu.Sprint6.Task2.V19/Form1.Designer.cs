namespace Tyuiu.BilousEYu.Sprint6.Task2.V19;

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
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
        groupBoxTask_KES = new GroupBox();
        pictureBoxFormula_KES = new PictureBox();
        textBoxTask_KES = new TextBox();
        groupBoxEnter_KES = new GroupBox();
        labelVarEnd_KES = new Label();
        labelVarStart_KES = new Label();
        textBoxVarEnd_KES = new TextBox();
        textBoxVarStart_KES = new TextBox();
        buttonHelp_KES = new Button();
        buttonResult_KES = new Button();
        groupBoxResult_KES = new GroupBox();
        chartResult_KES = new System.Windows.Forms.DataVisualization.Charting.Chart();
        labelResult_KES = new Label();
        dataGridViewResult_KES = new DataGridView();
        X = new DataGridViewTextBoxColumn();
        F = new DataGridViewTextBoxColumn();
        groupBoxTask_KES.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).BeginInit();
        groupBoxEnter_KES.SuspendLayout();
        groupBoxResult_KES.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chartResult_KES).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KES).BeginInit();
        SuspendLayout();
        // 
        // groupBoxTask_KES
        // 
        groupBoxTask_KES.Controls.Add(pictureBoxFormula_KES);
        groupBoxTask_KES.Controls.Add(textBoxTask_KES);
        groupBoxTask_KES.Location = new Point(12, 12);
        groupBoxTask_KES.Name = "groupBoxTask_KES";
        groupBoxTask_KES.Size = new Size(556, 243);
        groupBoxTask_KES.TabIndex = 1;
        groupBoxTask_KES.TabStop = false;
        groupBoxTask_KES.Text = "Условие";
        // 
        // pictureBoxFormula_KES
        // 
        pictureBoxFormula_KES.Image = Properties.Resources.FormulaTask2V19;
        pictureBoxFormula_KES.Location = new Point(248, 31);
        pictureBoxFormula_KES.Name = "pictureBoxFormula_KES";
        pictureBoxFormula_KES.Size = new Size(298, 37);
        pictureBoxFormula_KES.TabIndex = 1;
        pictureBoxFormula_KES.TabStop = false;
        // 
        // textBoxTask_KES
        // 
        textBoxTask_KES.Location = new Point(16, 31);
        textBoxTask_KES.Multiline = true;
        textBoxTask_KES.Name = "textBoxTask_KES";
        textBoxTask_KES.ReadOnly = true;
        textBoxTask_KES.Size = new Size(224, 138);
        textBoxTask_KES.TabIndex = 0;
        textBoxTask_KES.TabStop = false;
        textBoxTask_KES.Text = "Протабулировать функцию f(x) на заданном промежутке [-5,5].\r\nРезультат вывести в DataGridView и построить график.";
        // 
        // groupBoxEnter_KES
        // 
        groupBoxEnter_KES.Controls.Add(labelVarEnd_KES);
        groupBoxEnter_KES.Controls.Add(labelVarStart_KES);
        groupBoxEnter_KES.Controls.Add(textBoxVarEnd_KES);
        groupBoxEnter_KES.Controls.Add(textBoxVarStart_KES);
        groupBoxEnter_KES.Location = new Point(12, 261);
        groupBoxEnter_KES.Name = "groupBoxEnter_KES";
        groupBoxEnter_KES.Size = new Size(273, 100);
        groupBoxEnter_KES.TabIndex = 2;
        groupBoxEnter_KES.TabStop = false;
        groupBoxEnter_KES.Text = "Ввод данных";
        // 
        // labelVarEnd_KES
        // 
        labelVarEnd_KES.AutoSize = true;
        labelVarEnd_KES.Location = new Point(140, 30);
        labelVarEnd_KES.Name = "labelVarEnd_KES";
        labelVarEnd_KES.Size = new Size(75, 15);
        labelVarEnd_KES.TabIndex = 3;
        labelVarEnd_KES.Text = "Конец шага:";
        // 
        // labelVarStart_KES
        // 
        labelVarStart_KES.AutoSize = true;
        labelVarStart_KES.Location = new Point(16, 30);
        labelVarStart_KES.Name = "labelVarStart_KES";
        labelVarStart_KES.Size = new Size(72, 15);
        labelVarStart_KES.TabIndex = 2;
        labelVarStart_KES.Text = "Старт шага:";
        // 
        // textBoxVarEnd_KES
        // 
        textBoxVarEnd_KES.Location = new Point(140, 61);
        textBoxVarEnd_KES.Name = "textBoxVarEnd_KES";
        textBoxVarEnd_KES.Size = new Size(100, 23);
        textBoxVarEnd_KES.TabIndex = 1;
        textBoxVarEnd_KES.Text = "5";
        // 
        // textBoxVarStart_KES
        // 
        textBoxVarStart_KES.Location = new Point(16, 61);
        textBoxVarStart_KES.Name = "textBoxVarStart_KES";
        textBoxVarStart_KES.Size = new Size(100, 23);
        textBoxVarStart_KES.TabIndex = 0;
        textBoxVarStart_KES.Text = "-5";
        // 
        // buttonHelp_KES
        // 
        buttonHelp_KES.BackColor = Color.CornflowerBlue;
        buttonHelp_KES.ForeColor = SystemColors.ControlText;
        buttonHelp_KES.Location = new Point(306, 306);
        buttonHelp_KES.Name = "buttonHelp_KES";
        buttonHelp_KES.Size = new Size(102, 53);
        buttonHelp_KES.TabIndex = 6;
        buttonHelp_KES.Text = "Справка";
        buttonHelp_KES.UseVisualStyleBackColor = false;
        buttonHelp_KES.Click += buttonHelp_Click;
        // 
        // buttonResult_KES
        // 
        buttonResult_KES.BackColor = Color.Green;
        buttonResult_KES.Location = new Point(423, 306);
        buttonResult_KES.Name = "buttonResult_KES";
        buttonResult_KES.Size = new Size(135, 53);
        buttonResult_KES.TabIndex = 5;
        buttonResult_KES.Text = "Выполнить";
        buttonResult_KES.UseVisualStyleBackColor = false;
        buttonResult_KES.Click += buttonResult_Click;
        buttonResult_KES.MouseDown += buttonResult_MouseDown;
        buttonResult_KES.MouseEnter += buttonResult_MouseEnter;
        buttonResult_KES.MouseLeave += buttonResult_MouseLeave;
        // 
        // groupBoxResult_KES
        // 
        groupBoxResult_KES.Controls.Add(chartResult_KES);
        groupBoxResult_KES.Controls.Add(labelResult_KES);
        groupBoxResult_KES.Controls.Add(dataGridViewResult_KES);
        groupBoxResult_KES.Location = new Point(583, 12);
        groupBoxResult_KES.Name = "groupBoxResult_KES";
        groupBoxResult_KES.Size = new Size(642, 347);
        groupBoxResult_KES.TabIndex = 7;
        groupBoxResult_KES.TabStop = false;
        groupBoxResult_KES.Text = "Вывод данных";
        // 
        // chartResult_KES
        // 
        chartArea1.Name = "ChartAreaResult_KES";
        chartResult_KES.ChartAreas.Add(chartArea1);
        legend1.Name = "Legend1";
        chartResult_KES.Legends.Add(legend1);
        chartResult_KES.Location = new Point(193, 41);
        chartResult_KES.Name = "chartResult_KES";
        series1.ChartArea = "ChartAreaResult_KES";
        series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        series1.IsVisibleInLegend = false;
        series1.Legend = "Legend1";
        series1.Name = "Series1";
        chartResult_KES.Series.Add(series1);
        chartResult_KES.Size = new Size(443, 292);
        chartResult_KES.TabIndex = 2;
        chartResult_KES.Text = "Таблица";
        // 
        // labelResult_KES
        // 
        labelResult_KES.AutoSize = true;
        labelResult_KES.Location = new Point(6, 19);
        labelResult_KES.Name = "labelResult_KES";
        labelResult_KES.Size = new Size(63, 15);
        labelResult_KES.TabIndex = 1;
        labelResult_KES.Text = "Результат:";
        // 
        // dataGridViewResult_KES
        // 
        dataGridViewResult_KES.AllowUserToResizeColumns = false;
        dataGridViewResult_KES.AllowUserToResizeRows = false;
        dataGridViewResult_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewResult_KES.Columns.AddRange(new DataGridViewColumn[] { X, F });
        dataGridViewResult_KES.Location = new Point(6, 41);
        dataGridViewResult_KES.Name = "dataGridViewResult_KES";
        dataGridViewResult_KES.RowHeadersVisible = false;
        dataGridViewResult_KES.Size = new Size(155, 292);
        dataGridViewResult_KES.TabIndex = 0;
        // 
        // X
        // 
        X.HeaderText = "X";
        X.Name = "X";
        X.Width = 50;
        // 
        // F
        // 
        F.FillWeight = 50F;
        F.HeaderText = "F(X)";
        F.Name = "F";
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1250, 379);
        Controls.Add(groupBoxResult_KES);
        Controls.Add(buttonHelp_KES);
        Controls.Add(buttonResult_KES);
        Controls.Add(groupBoxEnter_KES);
        Controls.Add(groupBoxTask_KES);
        MaximizeBox = false;
        Name = "FormMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Спринт 6 | Таск 2 | Вариант 19 | Королев Е.С.";
        groupBoxTask_KES.ResumeLayout(false);
        groupBoxTask_KES.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).EndInit();
        groupBoxEnter_KES.ResumeLayout(false);
        groupBoxEnter_KES.PerformLayout();
        groupBoxResult_KES.ResumeLayout(false);
        groupBoxResult_KES.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)chartResult_KES).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KES).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxTask_KES;
    private PictureBox pictureBoxFormula_KES;
    private TextBox textBoxTask_KES;
    private GroupBox groupBoxEnter_KES;
    private Label labelVarEnd_KES;
    private Label labelVarStart_KES;
    private TextBox textBoxVarEnd_KES;
    private TextBox textBoxVarStart_KES;
    private Button buttonHelp_KES;
    private Button buttonResult_KES;
    private GroupBox groupBoxResult_KES;
    private DataGridView dataGridViewResult_KES;
    private DataGridViewTextBoxColumn X;
    private DataGridViewTextBoxColumn F;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KES;
    private Label labelResult_KES;

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
        Load += FromMain_Load;
        ResumeLayout(false);
    }

    #endregion
}
