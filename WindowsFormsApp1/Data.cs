using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace WindowsFormsApp1
{
    public class Data
    {
        public string NameNote { get; set; }
        public string TextNote { get; set; }

        // Konstruktor pro inicializaci hodnot
        public Data(string nameNote, string textNote)
        {
            this.NameNote = nameNote;
            this.TextNote = textNote;
        }

        // Uložení dat do souboru JSON
        public static void SaveToJson(List<Data> dataList, string filePath)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(dataList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba při ukládání do souboru: {ex.Message}");
            }
        }

        // Načtení dat ze souboru JSON
        public static List<Data> LoadFromJson(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonString = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<Data>>(jsonString);
                }
                return new List<Data>(); // Pokud soubor neexistuje, vrátí prázdný seznam
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba při načítání ze souboru: {ex.Message}");
                return new List<Data>();
            }
        }
    }
}
