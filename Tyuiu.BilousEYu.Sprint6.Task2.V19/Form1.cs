using Tyuiu.BilousEYu.Sprint6.Task2.V19.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task2.V19;

public partial class FromMain : Form
{
    public FromMain()
    {
        InitializeComponent();
    }

    DataService ds = new DataService();
    private void buttonDone_NVA_Click(object sender, EventArgs e)
    {
        try
        {
            int startStep = Convert.ToInt32(textBoxStart_NVA.Text);
            int stopStep = Convert.ToInt32(textBoxEnd_NVA.Text);

            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);

            this.chartFunction.Titles.Add("?????? ?????? ???????");

            this.chartFunction.ChartAreas[0].AxisX.Title = "??? ?";
            this.chartFunction.ChartAreas[0].AxisY.Title = "??? Y";

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridViewFunction_NVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                startStep++;
            }
        }
        catch
        {
            MessageBox.Show("??????? ???????? ??????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void buttonHelp_NVA_Click(object sender, EventArgs e)
    {
        MessageBox.Show("???? 3 ???????? ??????? ?????? ?????-24-1 ???????? ??????? ?????????????", "?????????", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

}
