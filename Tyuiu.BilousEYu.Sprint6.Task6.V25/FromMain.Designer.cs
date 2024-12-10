namespace Tyuiu.BilousEYu.Sprint6.Task6.V25
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_IPG = new GroupBox();
            textBoxCondition_IPG = new TextBox();
            groupBoxOutput_IPG = new GroupBox();
            textBoxOutput_IPG = new TextBox();
            groupBoxInput_IPG = new GroupBox();
            textBoxInput_IPG = new TextBox();
            buttonOpenFile_IPG = new Button();
            buttonDone_IPG = new Button();
            buttonHelp_IPG = new Button();
            openFileDialogTask_IPG = new OpenFileDialog();
            toolTipTask_IPG = new ToolTip(components);
            groupBoxCondition_IPG.SuspendLayout();
            groupBoxOutput_IPG.SuspendLayout();
            groupBoxInput_IPG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_IPG
            // 
            groupBoxCondition_IPG.Controls.Add(textBoxCondition_IPG);
            groupBoxCondition_IPG.Location = new Point(12, 188);
            groupBoxCondition_IPG.Name = "groupBoxCondition_IPG";
            groupBoxCondition_IPG.Size = new Size(1345, 200);
            groupBoxCondition_IPG.TabIndex = 0;
            groupBoxCondition_IPG.TabStop = false;
            groupBoxCondition_IPG.Text = "Условие: ";
            // 
            // textBoxCondition_IPG
            // 
            textBoxCondition_IPG.BorderStyle = BorderStyle.None;
            textBoxCondition_IPG.Location = new Point(23, 32);
            textBoxCondition_IPG.Multiline = true;
            textBoxCondition_IPG.Name = "textBoxCondition_IPG";
            textBoxCondition_IPG.ReadOnly = true;
            textBoxCondition_IPG.Size = new Size(1316, 126);
            textBoxCondition_IPG.TabIndex = 0;
            textBoxCondition_IPG.Text = resources.GetString("textBoxCondition_IPG.Text");
            // 
            // groupBoxOutput_IPG
            // 
            groupBoxOutput_IPG.Controls.Add(textBoxOutput_IPG);
            groupBoxOutput_IPG.Location = new Point(773, 394);
            groupBoxOutput_IPG.Name = "groupBoxOutput_IPG";
            groupBoxOutput_IPG.Size = new Size(584, 462);
            groupBoxOutput_IPG.TabIndex = 0;
            groupBoxOutput_IPG.TabStop = false;
            groupBoxOutput_IPG.Text = "Вывод: ";
            // 
            // textBoxOutput_IPG
            // 
            textBoxOutput_IPG.BorderStyle = BorderStyle.None;
            textBoxOutput_IPG.Location = new Point(6, 38);
            textBoxOutput_IPG.Multiline = true;
            textBoxOutput_IPG.Name = "textBoxOutput_IPG";
            textBoxOutput_IPG.Size = new Size(572, 414);
            textBoxOutput_IPG.TabIndex = 0;
            // 
            // groupBoxInput_IPG
            // 
            groupBoxInput_IPG.Controls.Add(textBoxInput_IPG);
            groupBoxInput_IPG.Location = new Point(12, 394);
            groupBoxInput_IPG.Name = "groupBoxInput_IPG";
            groupBoxInput_IPG.Size = new Size(755, 462);
            groupBoxInput_IPG.TabIndex = 0;
            groupBoxInput_IPG.TabStop = false;
            groupBoxInput_IPG.Text = "Ввод: ";
            // 
            // textBoxInput_IPG
            // 
            textBoxInput_IPG.BorderStyle = BorderStyle.None;
            textBoxInput_IPG.Location = new Point(11, 38);
            textBoxInput_IPG.Multiline = true;
            textBoxInput_IPG.Name = "textBoxInput_IPG";
            textBoxInput_IPG.Size = new Size(738, 414);
            textBoxInput_IPG.TabIndex = 0;
            // 
            // buttonOpenFile_IPG
            // 
            buttonOpenFile_IPG.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_IPG.BackgroundImage");
            buttonOpenFile_IPG.Location = new Point(35, 41);
            buttonOpenFile_IPG.Name = "buttonOpenFile_IPG";
            buttonOpenFile_IPG.Size = new Size(163, 107);
            buttonOpenFile_IPG.TabIndex = 1;
            buttonOpenFile_IPG.UseVisualStyleBackColor = true;
            buttonOpenFile_IPG.Click += buttonOpenFile_IPG_Click;
            // 
            // buttonDone_IPG
            // 
            buttonDone_IPG.BackgroundImage = (Image)resources.GetObject("buttonDone_IPG.BackgroundImage");
            buttonDone_IPG.Location = new Point(290, 41);
            buttonDone_IPG.Name = "buttonDone_IPG";
            buttonDone_IPG.Size = new Size(136, 107);
            buttonDone_IPG.TabIndex = 1;
            buttonDone_IPG.UseVisualStyleBackColor = true;
            buttonDone_IPG.Click += buttonDone_IPG_Click;
            // 
            // buttonHelp_IPG
            // 
            buttonHelp_IPG.BackgroundImage = (Image)resources.GetObject("buttonHelp_IPG.BackgroundImage");
            buttonHelp_IPG.Location = new Point(1079, 52);
            buttonHelp_IPG.Name = "buttonHelp_IPG";
            buttonHelp_IPG.Size = new Size(145, 107);
            buttonHelp_IPG.TabIndex = 1;
            buttonHelp_IPG.UseVisualStyleBackColor = true;
            buttonHelp_IPG.Click += buttonHelp_IPG_Click;
            // 
            // openFileDialogTask_IPG
            // 
            openFileDialogTask_IPG.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 858);
            Controls.Add(buttonHelp_IPG);
            Controls.Add(buttonDone_IPG);
            Controls.Add(buttonOpenFile_IPG);
            Controls.Add(groupBoxInput_IPG);
            Controls.Add(groupBoxOutput_IPG);
            Controls.Add(groupBoxCondition_IPG);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6| Вариант 25| Билоус Е.Ю.";
            groupBoxCondition_IPG.ResumeLayout(false);
            groupBoxCondition_IPG.PerformLayout();
            groupBoxOutput_IPG.ResumeLayout(false);
            groupBoxOutput_IPG.PerformLayout();
            groupBoxInput_IPG.ResumeLayout(false);
            groupBoxInput_IPG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_IPG;
        private GroupBox groupBoxOutput_IPG;
        private GroupBox groupBoxInput_IPG;
        private TextBox textBoxCondition_IPG;
        private Button buttonOpenFile_IPG;
        private Button buttonDone_IPG;
        private Button buttonHelp_IPG;
        private TextBox textBoxOutput_IPG;
        private TextBox textBoxInput_IPG;
        private OpenFileDialog openFileDialogTask_IPG;
        private ToolTip toolTipTask_IPG;
    }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
}


