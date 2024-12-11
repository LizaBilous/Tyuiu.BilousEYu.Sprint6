namespace Tyuiu.BilousEYu.Sprint6.Task7.V7
{
    partial class FormAbout
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(243, 40);
            label1.TabIndex = 1;
            label1.Text = "Разработчик Билоус Е.Ю.\r\nгруппа ИСТНб-24-1\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(387, 20);
            label2.TabIndex = 2;
            label2.Text = "Программа разработана в рамках изучения языка C#";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(357, 40);
            label3.TabIndex = 3;
            label3.Text = "Тюменский индустриальный университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(401, 20);
            label4.TabIndex = 4;
            label4.Text = "Внутреннее имя: Tyuiu.BilousEYu.Sprint6.Task7.V7";
            // 
            // buttonOK
            // 
            buttonOK.ImeMode = ImeMode.NoControl;
            buttonOK.Location = new Point(387, 178);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 5;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 218);
            Controls.Add(buttonOK);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(514, 265);
            MinimumSize = new Size(514, 265);
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonOK;
    }
}