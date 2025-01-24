using System;

class Program
{
    // I Exceeded the requirements by creating a scripture library and having the program choose a scripture from the library at random.
    static void Main(string[] args)
    {
        Console.Clear();

        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Scripture thisScripture = scriptureLibrary.GetRandomScripture();
        Console.WriteLine(thisScripture.GetDisplayText());

        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:\n");

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input)) // Trigger when Enter is pressed without typing anything
            {
                Console.Clear();
                thisScripture.HideRandomWords(3);
                Console.WriteLine(thisScripture.GetDisplayText());
                if(thisScripture.IsCompletelyHidden()){
                    Console.WriteLine("\nCompletely Hidden");
                    break;
                }
            }
            else if (input.Trim().ToLower() == "quit") // Allow the user to quit the program
            {
                Console.WriteLine("Quitting...");
                break;
            }
            else
            {
                Console.WriteLine($"You typed: {input}");
            }
        }
    }
}