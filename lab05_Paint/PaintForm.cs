using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    // ЛР5 ІЗВП: малювання мишею на формі
    public partial class PaintForm : Form
    {
        private Point last;
        private bool drawing;
        private readonly Pen pen = new Pen(Color.Black, 2);

        public PaintForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void PaintForm_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            last = e.Location;
        }

        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            using (var g = CreateGraphics())
                g.DrawLine(pen, last, e.Location);
            last = e.Location;
        }

        private void PaintForm_MouseUp(object sender, MouseEventArgs e) => drawing = false;
    }
}
