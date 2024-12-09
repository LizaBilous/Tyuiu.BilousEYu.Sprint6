using Tyuiu.BilousEYu.Sprint6.Task3.V20.Lib;
namespace Tyuiu.BilousEYu.Sprint6.Task3.V20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix ={{ -14, 17, 19, 3, 2},{ -4,  -14, -19, -9, -1},{ 1, 0, 13, 14, 8},{ 13, 7, 8, -3, -15},{ 2, -20, 12, -14, 4 }};

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 3 âûïîëíèë ñòóäåíò ãðóïïû ÏÊÒá-24-1 Ìûøàêèí Äàíèë", "Ñïðàâêà", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            int[,] ResultMatrix = ds.Calculate(matrix);

            int rows = ResultMatrix.GetUpperBound(0) + 1;
            int columns = ResultMatrix.Length / rows;

            dataGridViewResultMatrix.ColumnCount = columns;
            dataGridViewResultMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResultMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResultMatrix.Rows[i].Cells[j].Value = Convert.ToString(ResultMatrix[i, j]);
                }
            }
}
