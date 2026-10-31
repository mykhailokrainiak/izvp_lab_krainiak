using System;
using System.Windows.Forms;

namespace TimerApp
{
    // ЛР4 ІЗВП: секундомір на основі компонента Timer
    public partial class TimerForm : Form
    {
        private const int TickMs = 1000;
        private int seconds;

        public TimerForm()
        {
            InitializeComponent();
            timer1.Interval = TickMs;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e) => timer1.Start();

        private void btnStop_Click(object sender, EventArgs e) => timer1.Stop();

        private void btnReset_Click(object sender, EventArgs e)
        {
            seconds = 0;
            lblTime.Text = "00:00";
        }
    }
}
