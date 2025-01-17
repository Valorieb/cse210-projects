public class Menu{
    public int menuChoice;
    string fileName = "";
    private Journal myJournal = new Journal();

    public void DisplayMenu(){
        
        Console.WriteLine($"\n_________MENU_________\n");
        Console.WriteLine($"Please select one of the following choices:");
        Console.WriteLine($"  1. Write new entry");
        Console.WriteLine("  2. Display all entries");
        Console.WriteLine("  3. Load entry");
        Console.WriteLine("  4. Save entry");
        Console.WriteLine("  5. Quit\n");
                           
    }
    public int MenuOption(){

        Console.WriteLine("What would you like to do?");
        Console.Write("> ");
        string userInput1 = Console.ReadLine();
        menuChoice = int.Parse(userInput1);
        return menuChoice;
    }


    public bool runChoice(){
        if(menuChoice == 1){
            DateTime thisDay = DateTime.Today;
            string dayString = thisDay.ToString("MMMM dd, yyyy");
            
            PromptGenerator promptGen = new PromptGenerator();
            string myPrompt = promptGen.GetRandomPrompt();

            Console.WriteLine($"\nPROMPT: {myPrompt}");
            
            Console.Write("> ");
            string thisEntry = Console.ReadLine();
            
            Entry myEntry = new Entry{
                _date = dayString,
                _promptText = myPrompt,
                _entryText = thisEntry
            };
            
            myJournal.AddEntry(myEntry);

        }if(menuChoice == 2){
            if (string.IsNullOrEmpty(fileName)){
                Console.WriteLine("\nNO FILE IS CURRENTLY LOADED. Here are your unsaved entries:");
                myJournal.DisplayTXT();
            }

            // Check if the file exists before passing it to DisplayAll()
            if (File.Exists(fileName))
            {
                myJournal.DisplayAll(fileName);
            }

        }if(menuChoice == 3){
            Console.WriteLine("Please name the file you would like to load (ex: myJournal.txt, Journal.json)");
            Console.Write("> ");
            fileName = Console.ReadLine();
            myJournal.Load(ref fileName);
        }if(menuChoice == 4){

            Console.WriteLine("Please name the file you would like to save (ex: myJournal.txt, Journal.json)");
            Console.Write("> ");
            string fileName = Console.ReadLine();
            myJournal.Save(fileName);

        }if(menuChoice == 5){
            Console.WriteLine("Goodbye!\n");
            return false;
        }else if(menuChoice < 0 || menuChoice > 5) {
        Console.WriteLine("Invalid option. Please try again.");
    }
        return true;
    }

}