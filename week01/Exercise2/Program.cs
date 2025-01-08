using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string letter;
        bool pass = false;

        if(percent >= 70){
            pass = true;
        }
    
        if(percent >= 90){
            letter = "A";
        } else if (percent >= 80){
            letter = "B";
        } else if (percent >=70){
            letter ="C";
        }else if (percent >=60){
            letter ="D";
        }else {
            letter ="F";
        }

        // I wanted to practice using functions, so I did it a little different.
        PrintGrade(letter, pass);

    }
    static void PrintGrade(string letter, bool pass){
       Console.WriteLine($"Your grade is {letter}.");
       if(pass){
        Console.WriteLine($"Congratulations! You passed!\n");
       }else{
        Console.WriteLine($"You didn't pass this time. Keep trying!\n");
       }
        }
}