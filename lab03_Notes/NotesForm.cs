using System;
using System.IO;
using System.Windows.Forms;

namespace Notes
{
    // ЛР3 ІЗВП: список нотаток зі збереженням у текстовий файл
    public partial class NotesForm : Form
    {
        private const string FileName = "notes.txt";

        public NotesForm()
        {
            InitializeComponent();
            if (File.Exists(FileName))
                lstNotes.Items.AddRange(File.ReadAllLines(FileName));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNote.Text.Trim().Length == 0) return;
            lstNotes.Items.Add(txtNote.Text.Trim());
            txtNote.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex >= 0)
                lstNotes.Items.RemoveAt(lstNotes.SelectedIndex);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var w = new StreamWriter(FileName))
                foreach (var item in lstNotes.Items) w.WriteLine(item);
            MessageBox.Show($"Збережено нотаток: {lstNotes.Items.Count}");
        }
    }
}
