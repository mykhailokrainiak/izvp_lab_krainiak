using System;
using System.IO;
using System.Windows.Forms;

namespace FileViewer
{
    // ЛР6 ІЗВП: відкриття та збереження текстових файлів
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtContent.Text = File.ReadAllText(openFileDialog1.FileName);
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, txtContent.Text);
        }
    }
}
