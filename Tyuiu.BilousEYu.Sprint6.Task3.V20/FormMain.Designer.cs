namespace Tyuiu.BilousEYu.Sprint6.Task3.V20
{
    partial class FormMain
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxOutput = new GroupBox();
            dataGridViewResultMatrix = new DataGridView();
            textBoxNameResult = new TextBox();
            buttonGetResult = new Button();
            buttonHelp = new Button();
            groupBoxInput = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            groupBoxTask.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix).BeginInit();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(14, 16);
            groupBoxTask.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask.Size = new Size(618, 568);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(7, 29);
            textBoxTask.Margin = new Padding(3, 4, 3, 4);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(604, 529);
            textBoxTask.TabIndex = 0;
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewResultMatrix);
            groupBoxOutput.Controls.Add(textBoxNameResult);
            groupBoxOutput.Location = new Point(1243, 16);
            groupBoxOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput.Size = new Size(560, 568);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewResultMatrix
            // 
            dataGridViewResultMatrix.AllowUserToAddRows = false;
            dataGridViewResultMatrix.AllowUserToDeleteRows = false;
            dataGridViewResultMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultMatrix.ColumnHeadersVisible = false;
            dataGridViewResultMatrix.Location = new Point(7, 59);
            dataGridViewResultMatrix.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResultMatrix.Name = "dataGridViewResultMatrix";
            dataGridViewResultMatrix.ReadOnly = true;
            dataGridViewResultMatrix.RowHeadersVisible = false;
            dataGridViewResultMatrix.RowHeadersWidth = 51;
            dataGridViewResultMatrix.Size = new Size(546, 493);
            dataGridViewResultMatrix.TabIndex = 1;
            // 
            // textBoxNameResult
            // 
            textBoxNameResult.BorderStyle = BorderStyle.None;
            textBoxNameResult.Location = new Point(7, 29);
            textBoxNameResult.Margin = new Padding(3, 4, 3, 4);
            textBoxNameResult.Name = "textBoxNameResult";
            textBoxNameResult.ReadOnly = true;
            textBoxNameResult.Size = new Size(114, 20);
            textBoxNameResult.TabIndex = 0;
            textBoxNameResult.Text = "Результат:";
            // 
            // buttonGetResult
            // 
            buttonGetResult.BackColor = Color.FromArgb(192, 192, 255);
            buttonGetResult.Location = new Point(1640, 609);
            buttonGetResult.Margin = new Padding(3, 4, 3, 4);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(157, 47);
            buttonGetResult.TabIndex = 2;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.SkyBlue;
            buttonHelp.Location = new Point(1551, 609);
            buttonHelp.Margin = new Padding(3, 4, 3, 4);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(82, 47);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewMatrix);
            groupBoxInput.Location = new Point(639, 16);
            groupBoxInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput.Size = new Size(598, 568);
            groupBoxInput.TabIndex = 4;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.AllowUserToDeleteRows = false;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(7, 59);
            dataGridViewMatrix.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(584, 493);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1817, 687);
            Controls.Add(groupBoxInput);
            Controls.Add(buttonHelp);
            Controls.Add(buttonGetResult);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Билоус Е.Ю. | ИСТНб-24-1";
            Load += FormMain_load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix).EndInit();
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewResultMatrix;
        private TextBox textBoxNameResult;
        private Button buttonGetResult;
        private Button buttonHelp;
        private GroupBox groupBoxInput;
        private DataGridView dataGridViewMatrix;
    }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
