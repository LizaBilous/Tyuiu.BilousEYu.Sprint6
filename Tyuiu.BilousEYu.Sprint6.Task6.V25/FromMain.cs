using Tyuiu.BilousEYu.Sprint6.Task6.V25.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task6.V25
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_IPG_Click(object sender, EventArgs e)
        {
            openFileDialogTask_IPG.ShowDialog();
            openFilePath = openFileDialogTask_IPG.FileName;
            textBoxInput_IPG.Text = File.ReadAllText(openFilePath);
            groupBoxInput_IPG.Text = groupBoxInput_IPG.Text + " " + openFileDialogTask_IPG.FileName;
            buttonOpenFile_IPG.Enabled = false;
            buttonDone_IPG.Enabled = true;
        }
        private void buttonDone_IPG_Click(object sender, EventArgs e)
        {
            buttonOpenFile_IPG.Enabled = true;
            buttonDone_IPG.Enabled = false;
            textBoxOutput_IPG.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonHelp_IPG_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void FormMain_LMV_Load(object sender, EventArgs e)
        {
        }
    }
}
