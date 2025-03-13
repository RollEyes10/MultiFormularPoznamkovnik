using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Poznamka : Form
    {
        private MainForm mainForm;
        private Data currentNote;

        // Konstruktor pro přidání nové poznámky
        public Poznamka(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        // Konstruktor pro editaci existující poznámky
        public Poznamka(MainForm form, Data note)
        {
            InitializeComponent();
            mainForm = form;
            currentNote = note;
            textBoxName.Text = note.NameNote;
            richTextBoxNote.Text = note.TextNote;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string text = richTextBoxNote.Text;

            if (currentNote == null)
            {
                // Pokud je currentNote null, přidáme novou poznámku
                currentNote = new Data(name, text);
                mainForm.Notes.Add(currentNote);  // Použití veřejné vlastnosti Notes
            }
            else
            {
                // Pokud máme existující poznámku, aktualizujeme ji
                currentNote.NameNote = name;
                currentNote.TextNote = text;
            }

            // Uložíme seznam poznámek do souboru
            Data.SaveToJson(mainForm.Notes, MainForm.filePath);
            mainForm.RefreshListBox();
            this.Close();
        }
    }
}
