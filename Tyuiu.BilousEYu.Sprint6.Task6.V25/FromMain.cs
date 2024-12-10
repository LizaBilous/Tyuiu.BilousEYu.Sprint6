using System.Windows.Forms;
using Tyuiu.BilousEYu.Sprint6.Task6.V25.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task6.V25
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        string openFilePath;

        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "**";
            groupBoxOutPutData.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialog1.FileName;
            buttonDone.Enabled = true;
        }
}
