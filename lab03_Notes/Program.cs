using System;
using System.Windows.Forms;

namespace Notes
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new NotesForm());
        }
    }
}
