namespace Tyuiu.BilousEYu.Sprint6.Task7.V7
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
            groupBox1 = new GroupBox();
            dataGridViewIn = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewOut = new DataGridView();
            buttonOpen = new Button();
            buttonDone = new Button();
            buttonCpravka = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            buttonSave = new Button();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            toolTipOpen = new ToolTip(components);
            toolTipDone = new ToolTip(components);
            toolTipSave = new ToolTip(components);
            toolTipInfo = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dataGridViewIn);
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 23);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(617, 382);
            dataGridViewIn.TabIndex = 0;
            dataGridViewIn.CellContentClick += dataGridViewIn_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dataGridViewOut);
            groupBox2.Location = new Point(638, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 408);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 23);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(454, 382);
            dataGridViewOut.TabIndex = 1;
            // 
            // buttonOpen
            // 
            buttonOpen.Image = (Image)resources.GetObject("buttonOpen.Image");
            buttonOpen.Location = new Point(12, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(105, 82);
            buttonOpen.TabIndex = 2;
            toolTipOpen.SetToolTip(buttonOpen, "Открыть файл в формате csv");
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(123, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 82);
            buttonDone.TabIndex = 3;
            toolTipDone.SetToolTip(buttonDone, "Обработать файл в формате csv");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonCpravka
            // 
            buttonCpravka.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCpravka.Image = (Image)resources.GetObject("buttonCpravka.Image");
            buttonCpravka.Location = new Point(981, 12);
            buttonCpravka.Name = "buttonCpravka";
            buttonCpravka.Size = new Size(111, 82);
            buttonCpravka.TabIndex = 6;
            toolTipInfo.SetToolTip(buttonCpravka, "Информация о программе");
            buttonCpravka.UseVisualStyleBackColor = true;
            buttonCpravka.Click += buttonHelp_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(12, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1080, 97);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Условие";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(1074, 71);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(233, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(96, 82);
            buttonSave.TabIndex = 8;
            toolTipSave.SetToolTip(buttonSave, "Сохранить файл в формате csv");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSaveFile_Click;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTipOpen
            // 
            toolTipOpen.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpen.ToolTipTitle = "Открыть файл";
            // 
            // toolTipDone
            // 
            toolTipDone.ToolTipIcon = ToolTipIcon.Info;
            toolTipDone.ToolTipTitle = "Выполнить";
            // 
            // toolTipSave
            // 
            toolTipSave.ToolTipIcon = ToolTipIcon.Info;
            toolTipSave.ToolTipTitle = "Сохранить";
            // 
            // toolTipInfo
            // 
            toolTipInfo.ToolTipIcon = ToolTipIcon.Info;
            toolTipInfo.ToolTipTitle = "Справка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 623);
            Controls.Add(buttonSave);
            Controls.Add(groupBox3);
            Controls.Add(buttonCpravka);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1122, 670);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 7 | Билоус Е.Ю.";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewIn;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOut;
        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonCpravka;
        private GroupBox groupBox3;
        private Label label1;
        private Button buttonSave;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private ToolTip toolTipOpen;
        private ToolTip toolTipDone;
        private ToolTip toolTipSave;
        private ToolTip toolTipInfo;

    }
}
