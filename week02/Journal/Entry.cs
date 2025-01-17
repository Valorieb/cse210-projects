public class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayEntry(){
        Console.WriteLine($"\nDATE: {_date}\nPROMPT: {_promptText}\nENTRY: {_entryText}\n");

    }
}