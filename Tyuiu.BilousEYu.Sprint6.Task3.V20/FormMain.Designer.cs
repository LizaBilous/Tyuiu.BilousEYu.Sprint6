namespace Tyuiu.BilousEYu.Sprint6.Task3.V20
{
    partial class Form1
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
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(541, 426);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(529, 398);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewResultMatrix);
            groupBoxOutput.Controls.Add(textBoxNameResult);
            groupBoxOutput.Location = new Point(1088, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(490, 426);
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
            dataGridViewResultMatrix.Location = new Point(6, 44);
            dataGridViewResultMatrix.Name = "dataGridViewResultMatrix";
            dataGridViewResultMatrix.ReadOnly = true;
            dataGridViewResultMatrix.RowHeadersVisible = false;
            dataGridViewResultMatrix.Size = new Size(478, 370);
            dataGridViewResultMatrix.TabIndex = 1;
            // 
            // textBoxNameResult
            // 
            textBoxNameResult.BorderStyle = BorderStyle.None;
            textBoxNameResult.Location = new Point(6, 22);
            textBoxNameResult.Name = "textBoxNameResult";
            textBoxNameResult.ReadOnly = true;
            textBoxNameResult.Size = new Size(100, 16);
            textBoxNameResult.TabIndex = 0;
            textBoxNameResult.Text = "Результат:";
            // 
            // buttonGetResult
            // 
            buttonGetResult.BackColor = Color.FromArgb(192, 192, 255);
            buttonGetResult.Location = new Point(1435, 457);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(137, 35);
            buttonGetResult.TabIndex = 2;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.SkyBlue;
            buttonHelp.Location = new Point(1357, 457);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(72, 35);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewMatrix);
            groupBoxInput.Location = new Point(559, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(523, 426);
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
            dataGridViewMatrix.Location = new Point(6, 44);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(511, 370);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1590, 515);
            Controls.Add(groupBoxInput);
            Controls.Add(buttonHelp);
            Controls.Add(buttonGetResult);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
