using Tyuiu.BilousEYu.Sprint6.Task4.V21.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task4.V21
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }
        private void buttonReference_IPG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 4 âûïîëíèë ñòóäåíò ãðóïïû ÈÑÒÍÁ-24-1 Èâàíîâ Ïðîõîð Ãåííàäüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_IPG_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V21.txt";
                File.WriteAllText(path, textBoxResult_IPG.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Ôàéë {path} ñîõðàí¸í óñïåøíî!\n Îòêðûòü åãî?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(path);
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "Notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_IPG.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_IPG.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_IPG.ChartAreas[0].AxisX.Title = "Îñü X";
                this.chartFunction_IPG.ChartAreas[0].AxisY.Title = "Îñü Y";

                textBoxResult_IPG.Text = "";

                chartFunction_IPG.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chartFunction_IPG.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_IPG.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartStep_IPG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
