using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace Tester
{
    public partial class Form1 : Form
    {
        int testsN;
        bool positive = true;
        double eps;
        double left, right;
        char leftN, rightN;
        double h;
        int method = 1;
        string[] coeff;
        bool result = true;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            saveFileDialog1.Filter = "Файл (*.txt) | *.txt";

        }
        public double Integral()//вычисления интеграла от полинома
        {
            double s = 0;
            for (int i = 0; i < coeff.Count(); i++)
                s += double.Parse(coeff[i]) * ((Math.Pow(right, i + 1) / (i + 1)) - (Math.Pow(left, i + 1) / (i + 1)));
            return s;
        }


        private void button2_Click_1(object sender, EventArgs e)//сохранение отчета в файл
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            File.WriteAllLines(saveFileDialog1.FileName, txtbRes.Lines);
            File.AppendAllLines(saveFileDialog1.FileName, txtbResN.Lines);
        }

        private void button1_Click(object sender, EventArgs e)//генерация тест-кейсов
        {
            txtbRes.Clear();
            txtbResN.Clear();

            testsN = (int)numTestsN.Value;//кол-во тестов


            eps = (double)numEps.Value;//погрешность
            h = (double)txtbStep.Value;


            if (txtbCoeff.Text == "")
            {
                MessageBox.Show("Введите коэффициенты полинома", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            coeff = txtbCoeff.Text.Split(' ');//коэффициенты полинома
            for (int i = 0; i < coeff.Length; i++)
            {
                double coeffn = 0;
                if (!double.TryParse(coeff[i], out coeffn))//проверка, является ли коэффициентом числом
                {
                    MessageBox.Show("Не все коэффициенты являются числами", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Random r = new Random();
            if (left > right)
            {
                MessageBox.Show("Левая граница диапазона интегрирования должна быть меньше правой границы", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int max = 1000;
            int min = -1000;
            for (int i = 0; i < testsN; i++)
            {
                if (positive)//позитивные тесты
                {
                    do
                    {
                        left = r.Next(min, max) * r.NextDouble();//левая граница интегрирования
                        right = r.Next(min, max) * r.NextDouble();//правая граница интегрирования
                    } while (left > right);

                }
                else//негативные тесты
                {
                    leftN = (char)r.Next(0x0410, 0x44F);
                    rightN = (char)r.Next(0x0410, 0x44F);

                }

                var process = new Process();

                process.StartInfo.FileName = @"C:\Integral3x\Release\Integral3x.exe";
                if (positive)
                {
                    process.StartInfo.Arguments = left.ToString() + " "
                    + right.ToString() + " "
                    + h.ToString() + " "

                    + method.ToString() + " "
                    + txtbCoeff.Text;
                }
                else
                {
                    process.StartInfo.Arguments = leftN.ToString() + " "
                    + rightN.ToString() + " "
                    + h.ToString() + " "

                    + method.ToString() + " "
                    + txtbCoeff.Text;
                }
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string YF = string.Empty;
                YF = process.StandardOutput.ReadLine();//результат полученный из тестируемой праграммы
                process.StandardInput.Write(Keys.Enter);
                process.WaitForExit();

                string YE = string.Empty;//ожидаемый результат
                if (positive)
                    YE = Integral().ToString();
                else
                    YE = "Левая граница диапазона не является числом!";
                StringBuilder output = new StringBuilder();
                char testsType = positive ? 'P' : 'N';
                output.AppendLine("TEST " + (i + 1) + " " + testsType);
                if (positive)
                {
                    output.AppendLine("X = "
                                  + left.ToString() + " "
                                  + right.ToString() + " "
                                  + h.ToString() + " "
                                  + method.ToString() + " "
                                  + txtbCoeff.Text);

                }
                else
                {
                    output.AppendLine("X = "
                                  + leftN.ToString() + " "
                                  + rightN.ToString() + " "
                                  + h.ToString() + " "
                                  + method.ToString() + " "
                                  + txtbCoeff.Text);
                }
                output.AppendLine("EPS = " + eps.ToString());
                output.AppendLine("YE: " + YE);
                output.AppendLine("YF: " + YF);

                if (positive)
                {
                    try
                    {
                        double YF_ = double.Parse(YF.Substring(4).Replace('.', ','));

                        double inaccuracy = Math.Abs(double.Parse(YE.Replace('.', ',')) - YF_);

                        if (inaccuracy < eps)
                        {
                            output.AppendLine("|SYE-SYF| = " + inaccuracy.ToString() + " < " + eps.ToString());
                            output.AppendLine("Тест пройден");
                            result = true;
                        }
                        else
                        {
                            output.AppendLine("|SYE-SYF| = " + inaccuracy.ToString() + " > " + eps.ToString());
                            output.AppendLine("Тест не пройден");
                            result = false;
                        }


                    }
                    catch { output.AppendLine("Тест не пройден"); result = false; }
                }
                else if (YE == YF)
                {
                    output.AppendLine("Тест пройден");
                    result = true;
                }
                else if (YF != YE)
                {
                    result = false;
                    output.AppendLine("Тест не пройден");
                }
                if (result)
                {
                    txtbRes.Text += output.ToString() + Environment.NewLine;
                }
                else
                {
                    txtbResN.Text += output.ToString() + Environment.NewLine;
                }

            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                return;
            }
            if (rb.Checked)
            {
                if (rb.Text == "Позитивные")
                {
                    positive = true;
                }
                else
                {
                    positive = false;
                }
            }
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            txtbRes.Clear();
            txtbResN.Clear();

            testsN = (int)numTestsN.Value;//кол-во тестов


            eps = (double)numEps.Value;//погрешность
            h = (double)txtbStep.Value;


            if (txtbCoeff.Text == "")
            {
                MessageBox.Show("Введите коэффициенты полинома", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            coeff = txtbCoeff.Text.Split(' ');//коэффициенты полинома
            for (int i = 0; i < coeff.Length; i++)
            {
                double coeffn = 0;
                if (!double.TryParse(coeff[i], out coeffn))//проверка, является ли коэффициентом числом
                {
                    MessageBox.Show("Не все коэффициенты являются числами", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Random r = new Random();
            if (left > right)
            {
                MessageBox.Show("Левая граница диапазона интегрирования должна быть меньше правой границы", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int max = 1000;
            int min = -1000;
            for (int i = 0; i < testsN; i++)
            {
                if (positive)//позитивные тесты
                {
                    do
                    {
                        left = r.Next(min, max) * r.NextDouble();//левая граница интегрирования
                        right = r.Next(min, max) * r.NextDouble();//правая граница интегрирования
                    } while (left > right);

                }
                else//негативные тесты
                {
                    leftN = (char)r.Next(0x0410, 0x44F);
                    rightN = (char)r.Next(0x0410, 0x44F);

                }

                string YE = string.Empty;//ожидаемый результат
                if (positive)
                    YE = Integral().ToString();
                else
                    YE = "Левая граница диапазона не является числом!";
                StringBuilder output = new StringBuilder();
                char testsType = positive ? 'P' : 'N';
                output.AppendLine("TEST " + (i + 1) + " " + testsType);
                if (positive)
                {
                    output.AppendLine("X = "
                                  + left.ToString() + " "
                                  + right.ToString() + " "
                                  + h.ToString() + " "
                                  + method.ToString() + " "
                                  + txtbCoeff.Text);

                }
                else
                {
                    output.AppendLine("X = "
                                  + leftN.ToString() + " "
                                  + rightN.ToString() + " "
                                  + h.ToString() + " "
                                  + method.ToString() + " "
                                  + txtbCoeff.Text);
                }
                output.AppendLine("EPS = " + eps.ToString());
                output.AppendLine("YE: " + YE);

                txtbGener.Text += output.ToString() + Environment.NewLine;
            }

        }

        private void btnCulc_Click(object sender, EventArgs e)
        {
            txtbRes.Clear();
            txtbResN.Clear();
            String[] ar = txtbGener.Lines;
           
            for (int i = 0; i < ar.Length; i += 5)
            {
               
                String X = ar[i+1].Remove(0,3);
                var process = new Process();

                process.StartInfo.FileName = @"C:\Integral3x\Release\Integral3x.exe";
                if (positive)
                {
                    process.StartInfo.Arguments = left.ToString() + " "
                    + right.ToString() + " "
                    + h.ToString() + " "

                    + method.ToString() + " "
                    + txtbCoeff.Text;
                }
                else
                {
                    process.StartInfo.Arguments = leftN.ToString() + " "
                    + rightN.ToString() + " "
                    + h.ToString() + " "

                    + method.ToString() + " "
                    + txtbCoeff.Text;
                }
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string YF = string.Empty;
                YF = process.StandardOutput.ReadLine();//результат полученный из тестируемой праграммы
                process.StandardInput.Write(Keys.Enter);
                process.WaitForExit();

                string YE = string.Empty;//ожидаемый результат
                if (positive)
                    YE = Integral().ToString();
                else
                    YE = "Левая граница диапазона не является числом!";
                StringBuilder output = new StringBuilder();
                char testsType = positive ? 'P' : 'N';
                output.AppendLine("TEST " + (i + 1) + " " + testsType);
                if (positive)
                {
                    output.AppendLine("X = "
                                  + left.ToString() + " "
                                  + right.ToString() + " "
                                  + h.ToString() + " "
                                  + method.ToString() + " "
                                  + txtbCoeff.Text);

                }
                else
                {
                    output.AppendLine("X = "
                                  + leftN.ToString() + " "
                                  + rightN.ToString() + " "
                                  + h.ToString() + " "
                                  + method.ToString() + " "
                                  + txtbCoeff.Text);
                }
                output.AppendLine("EPS = " + eps.ToString());
                output.AppendLine("YE: " + YE);
                output.AppendLine("YF: " + YF);

                if (positive)
                {
                    try
                    {
                        double YF_ = double.Parse(YF.Substring(4).Replace('.', ','));

                        double inaccuracy = Math.Abs(double.Parse(YE.Replace('.', ',')) - YF_);

                        if (inaccuracy < eps)
                        {
                            output.AppendLine("|SYE-SYF| = " + inaccuracy.ToString() + " < " + eps.ToString());
                            output.AppendLine("Тест пройден");
                            result = true;
                        }
                        else
                        {
                            output.AppendLine("|SYE-SYF| = " + inaccuracy.ToString() + " > " + eps.ToString());
                            output.AppendLine("Тест не пройден");
                            result = false;
                        }


                    }
                    catch { output.AppendLine("Тест не пройден"); result = false; }
                }
                else if (YE == YF)
                {
                    output.AppendLine("Тест пройден");
                    result = true;
                }
                else if (YF != YE)
                {
                    result = false;
                    output.AppendLine("Тест не пройден");
                }
                if (result)
                {
                    txtbRes.Text += output.ToString() + Environment.NewLine;
                }
                else
                {
                    txtbResN.Text += output.ToString() + Environment.NewLine;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            method = comboBox1.SelectedIndex + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
