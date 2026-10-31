using System;
using System.Windows.Forms;

namespace Calculator
{
    // ЛР1 ІЗВП: простий калькулятор на двох числах
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ReadNumbers(out double a, out double b)
        {
            b = 0;
            if (!double.TryParse(txtA.Text, out a) || !double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Введіть коректні числа", "Помилка");
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b)) lblResult.Text = (a + b).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b)) lblResult.Text = (a - b).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b)) lblResult.Text = (a * b).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!ReadNumbers(out double a, out double b)) return;
            if (b == 0)
            {
                MessageBox.Show("Ділення на нуль неможливе", "Помилка");
                return;
            }
            lblResult.Text = (a / b).ToString();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if (ReadNumbers(out double a, out double b)) lblResult.Text = Math.Pow(a, b).ToString();
        }
    }
}
