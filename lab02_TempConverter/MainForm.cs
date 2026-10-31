using System;
using System.Windows.Forms;

namespace TempConverter
{
    // ЛР2 ІЗВП: перетворення температури між шкалами Цельсія та Фаренгейта
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnToF_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValue.Text, out double c))
                lblResult.Text = $"{c * 9 / 5 + 32:F1} °F";
        }

        private void btnToC_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValue.Text, out double f))
                lblResult.Text = $"{(f - 32) * 5 / 9:F1} °C";
        }

        private void btnToK_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValue.Text, out double c))
                lblResult.Text = $"{c + 273.15:F2} K";
        }
    }
}
