using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace DigitalSignature
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenFile.Click += OpenFile_Click;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            txtbxQ.Clear();
            txtbxP.Clear();
            txtbxH.Clear();
            txtbxG.Clear();
            txtbxX.Clear();
            txtbxY.Clear();
            txtbxK.Clear();
            txtbxSign.Clear();
            txtbxHash.Clear();
        }

        private int GetIntFromTextBox(TextBox textBox, string paramName, Func<int, bool> validator, string errorMessage)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show($"Введите {paramName}", "Ошибка");
                throw new ArgumentException($"{paramName} не введён");
            }
            int value = int.Parse(textBox.Text);
            if (!validator(value))
            {
                MessageBox.Show(errorMessage, "Ошибка");
                textBox.Clear();
                throw new ArgumentException($"{paramName} невалиден");
            }
            return value;
        }

        private int CalculateG(int h, int p, int q)
        {
            int g = DSA.FastPow(h, (p - 1) / q, p);
            if (g < 2)
            {
                MessageBox.Show("G должен быть больше 1", "Ошибка");
                throw new ArgumentException("G невалиден");
            }
            return g;
        }

        private int CalculateY(int g, int x, int p)
        {
            return DSA.FastPow(g, x, p);
        }

        private void MakeSignature(int p, int q, int g, int x, int k)
        {
            string message = txtbxMessage.Text;
            int hash = DSA.Hash(message, p, q);
            txtbxHash.Text = hash.ToString();
            var (r, s) = DSA.Sign(p, q, g, x, k, hash);
            if (r == 0 || s == 0)
            {
                MessageBox.Show("В результате вычислений R или S = 0. Введите другое K.");
                txtbxK.Clear();
                throw new ArgumentException("R или S = 0");
            }
            txtbxSign.Text = $"{r} {s}";
        }

        private void CheckSignature(int p, int q, int g, int y)
        {
            var signedMessage = txtbxMessage.Text.Split(' ');
            string message = string.Join(" ", signedMessage.Take(signedMessage.Length - 2));

            int r = int.Parse(signedMessage[signedMessage.Length - 2]);
            int s = int.Parse(signedMessage[signedMessage.Length - 1]);
            txtbxSign.Text = r.ToString() + ' ' + s.ToString();

            int hash = DSA.Hash(message, p, q);
            txtbxHash.Text = hash.ToString();

            int v = DSA.Verify(p, q, g, y, r, s, hash);
            string resultMessage = (v == r) ? "Подпись верна" : "Подпись неверна";
            MessageBox.Show(resultMessage + $"\nv={v}, r={r}", "Результат");
        }

        private void ButtonCalcParameters_Click(object sender, EventArgs e)
        {
            try
            {
                int q = GetIntFromTextBox(
                    txtbxQ, "Q",
                    v => v > 1 && DSA.IsPrime(v),
                    "Введите простое Q > 1"
                );

                int p = GetIntFromTextBox(
                    txtbxP, "P",
                    v => v > 1 && DSA.IsPrime(v),
                    "Введите простое P > 1"
                );

                if ((p - 1) % q != 0)
                {
                    MessageBox.Show("Число Q должно быть делителем числа P-1", "Ошибка");
                    txtbxQ.Clear();
                    txtbxP.Clear();
                    return;
                }

                int h = GetIntFromTextBox(
                    txtbxH, "H",
                    v => v >= 2 && v <= p - 2,
                    "Введите H в интервале (1; P-1)"
                );

                int g = CalculateG(h, p, q);
                txtbxG.Text = g.ToString();

                int x = GetIntFromTextBox(
                    txtbxX, "X",
                    v => v >= 1 && v <= q - 1,
                    "Введите X в интервале (0; Q)"
                );
                int y = CalculateY(g, x, p);
                txtbxY.Text = y.ToString();

                int k = GetIntFromTextBox(
                    txtbxK, "K",
                    v => v >= 1 && v <= q - 1,
                    "Введите K в интервале (0; Q)"
                );

                if (RadioButtonMakeSign.Checked)
                {
                    MakeSignature(p, q, g, x, k);
                }
                else if (RadioButtonCheck.Checked)
                {
                    CheckSignature(p, q, g, y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода или вычислений: " + ex.Message);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                txtbxMessage.Text = File.ReadAllText(openFileDialog.FileName);
                txtbxHash.Clear();
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (txtbxMessage.Text.Length == 0)
            {
                MessageBox.Show("Поле пустое", "Внимание");
            } else if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                File.WriteAllText(saveFileDialog.FileName, txtbxMessage.Text + ' ' + txtbxSign.Text);
            }
        }

        private void txtbxMessage_TextChanged(object sender, EventArgs e)
        {
            txtbxHash.Clear();
        }
    }
 }
