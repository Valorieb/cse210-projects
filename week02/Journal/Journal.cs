using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal{
    public List<Entry> _entries= new List<Entry>();

    public void AddEntry(Entry myEntry){
        _entries.Add(myEntry);

    }
    
    public void DisplayAll(string? fileName = null)
{
    if (_entries.Count == 0 && string.IsNullOrEmpty(fileName))
    {
        Console.WriteLine("There are no entries yet.");
        return;
    }

    if (!string.IsNullOrEmpty(fileName))
    {
        string extension = Path.GetExtension(fileName).ToLower();
        if (extension == ".json")
        {
            DisplayJSON(fileName); // Pass fileName to read JSON
        }
        else if (extension == ".txt")
        {
            DisplayTXT();
        }
        else
        {
            Console.WriteLine("Unsupported file type.");
        }
    }
    else
    {
        DisplayTXT(); // Display entries in memory if no file is specified
    }
}


    public void DisplayTXT(){
        Console.WriteLine("\n________ALL ENTRIES________");
            foreach(var myEntry in _entries){
                Console.WriteLine("\n___________________________");
                Console.WriteLine($"\nDATE: {myEntry._date}\nPROMPT: {myEntry._promptText}\nENTRY: {myEntry._entryText}");
                Console.WriteLine("\n___________________________");
            }
    }

    public void DisplayJSON(string fileName)
{
    try
    {
        // Read JSON content from the file
        string jsonString = File.ReadAllText(fileName);

        // Deserialize the JSON into a list of entries
        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(jsonString, new JsonSerializerOptions { IncludeFields = true });

        if (loadedEntries != null && loadedEntries.Count > 0)
        {
            Console.WriteLine("\n________ALL ENTRIES FROM JSON________");
            foreach (var myEntry in loadedEntries)
            {
                Console.WriteLine("\n___________________________");
                Console.WriteLine($"\nDATE: {myEntry._date}\nPROMPT: {myEntry._promptText}\nENTRY: {myEntry._entryText}");
                Console.WriteLine("\n___________________________");
            }
        }
        else
        {
            Console.WriteLine("No entries found in the JSON file.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error reading JSON file: {ex.Message}");
    }
}


    public void Save(string fileName)
{
        string extension = Path.GetExtension(fileName).ToLower();

        if (extension == ".json")
        {
            SaveToJson(fileName);
        }
        else if (extension == ".txt")
        {
            SaveToText(fileName);
        }
        else
        {
            Console.WriteLine("Unsupported file type. Please use .txt or .json.");
        }
}

    public void SaveToText(string fileName){

            // Check if the file exists
        if (!File.Exists(fileName))
        {
            // Create the file if it doesn't exist
            using (FileStream fs = File.Create(fileName))
            {
                // Optionally write an initial message or leave it empty
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    writer.WriteLine("New Journal File Created\n");
                }
            }
            Console.WriteLine($"File '{fileName}' created successfully.");
        }

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");

                writer.WriteLine("----");
            }
        }
    }

    private void SaveToJson(string fileName)
{
        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true, IncludeFields = true });
        File.WriteAllText(fileName, jsonString);
        Console.WriteLine($"Entries saved as JSON to {fileName}");
}

    public void Load(ref string fileName){
         if (File.Exists(fileName)){
            _entries.Clear(); // Clear existing entries before loading new ones

            string extension = Path.GetExtension(fileName).ToLower();

            if(extension == ".json"){
                LoadFromJSON(fileName);
            }else if (extension == ".txt"){
                LoadFromTXT(fileName);
            }else
        {
            Console.WriteLine($"File '{fileName}' does not exist.");
        }
        }
    }
    public void LoadFromJSON(string fileName){

         string jsonString = File.ReadAllText(fileName);
            
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();
        Console.WriteLine($"Entries loaded from {fileName}");

    }

    public void LoadFromTXT(string fileName){

        string[] lines = File.ReadAllLines(fileName);

            foreach (var line in lines){
                // Split the line into parts (date, prompt, entry text)
                string[] parts = line.Split('|');
                if (parts.Length == 3){
                    Entry newEntry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(newEntry);
                }else{
                    Console.WriteLine("Skipping invalid entry format.");
                }
            }
            Console.WriteLine($"Entries loaded from {fileName}");
        }
        
        
}
