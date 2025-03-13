using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public static string fileName = "data.json";
        public static string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

        // Změněno na veřejnou vlastnost, která umožňuje přístup z jiných tříd
        public List<Data> Notes { get; set; } = new List<Data>();

        public MainForm()
        {
            InitializeComponent();
            StartProgram();
        }

        public void StartProgram()
        {
            // Načteme data ze souboru, pokud existuje
            Notes = Data.LoadFromJson(filePath);
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            listBoxNotes.Items.Clear();
            foreach (var note in Notes)
            {
                listBoxNotes.Items.Add(note.NameNote);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Otevření formuláře pro přidání nové poznámky
            Poznamka noteForm = new Poznamka(this);
            noteForm.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex >= 0)
            {
                // Otevření formuláře pro úpravu vybrané poznámky
                var selectedNote = Notes[listBoxNotes.SelectedIndex];
                Poznamka noteForm = new Poznamka(this, selectedNote);
                noteForm.Show();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex >= 0)
            {
                // Mazání vybrané poznámky
                Notes.RemoveAt(listBoxNotes.SelectedIndex);
                Data.SaveToJson(Notes, filePath);
                RefreshListBox();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Uložení všech poznámek do souboru
            Data.SaveToJson(Notes, filePath);
        }
    }
}
