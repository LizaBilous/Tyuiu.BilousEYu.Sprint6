using System.Windows.Forms;
using Tyuiu.BilousEYu.Sprint6.Task7.V7.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task7.V7
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Çíà÷åíèÿ, ðàçäåëåíûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Çíà÷åíèÿ, ðàçäåëåíûå çàïÿòûìè(*.csv)|*.csv|Âñå ôàéëû(*.*)|*.*";
        }

        DataService ds = new DataService();
        static string openFilePath;


        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            string path = openFilePath;

            string[] lines = File.ReadAllLines(path);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            int[,] matrix = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            dataGridViewIn.ColumnCount = colCount;
            dataGridViewIn.RowCount = rowCount;
            dataGridViewOut.ColumnCount = colCount;
            dataGridViewOut.RowCount = rowCount;

            for (int i = 0; i < colCount; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }

            matrix = ds.GetMatrix(path);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] matrix = ds.GetMatrix(openFilePath);
            string[] lines = File.ReadAllLines(openFilePath);

            int rowCount = lines.Length;
            int colCount = lines[0].Split(';').Length;

            for (int r = 0; r < rowCount; r++)
            {
                for (int c = 0; c < colCount; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = matrix[r, c];
                }
            }
            buttonSave.Enabled = true;
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutDataFileTask7V7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridViewIn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
