using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestT
{
    public partial class AnalyzeForm : Form
    {
        public AnalyzeForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("Будь ласка виберіть коректний файл.");
                return;
            }

            try
            {
                var numbers = File.ReadAllLines(txtFilePath.Text).SelectMany(line => line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)).Select(int.Parse).ToArray();

                if (numbers.Length == 0)
                {
                    MessageBox.Show("Файл порожній або містить некоректні значення.");
                    return;
                }

                int max = numbers.Max();
                int min = numbers.Min();
                double mean = numbers.Average();

                Array.Sort(numbers);
                double median = numbers.Length % 2 == 0 ? (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2.0 : numbers[numbers.Length / 2];

                var increasingSeq = FindLongestSequence(numbers, (a, b) => a < b);
                var decreasingSeq = FindLongestSequence(numbers, (a, b) => a > b);

                txtResults.Text = $"Максимум: {max}\r\nМінімум: {min}\r\nСереднє арифметичне: {mean}\r\nМедіана: {median}\r\nНайдовша зростаюча послідовність: {string.Join(", ", increasingSeq)}\r\nНайдовша спадаюча послідовність: {string.Join(", ", decreasingSeq)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}");
            }
        }

        private static int[] FindLongestSequence(int[] arr, Func<int, int, bool> compareFunc)
        {
            var longestSeq = new int[0];
            var currentSeq = new int[arr.Length];
            int currentLength = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0 || compareFunc(arr[i - 1], arr[i]))
                {
                    currentSeq[currentLength++] = arr[i];
                }
                else
                {
                    if (currentLength > longestSeq.Length)
                    {
                        longestSeq = currentSeq.Take(currentLength).ToArray();
                    }
                    currentSeq[0] = arr[i];
                    currentLength = 1;
                }
            }

            if (currentLength > longestSeq.Length)
            {
                longestSeq = currentSeq.Take(currentLength).ToArray();
            }

            return longestSeq;
        }
    }
}
