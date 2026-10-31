using System;
using System.Drawing;
using System.Windows.Forms;

namespace Colors
{
    // ЛР8 ІЗВП: вибір кольору фону за допомогою трьох повзунків TrackBar
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            pnlPreview.BackColor = Color.FromArgb(tbRed.Value, tbGreen.Value, tbBlue.Value);
            lblHex.Text = $"#{tbRed.Value:X2}{tbGreen.Value:X2}{tbBlue.Value:X2}";
        }
    }
}
