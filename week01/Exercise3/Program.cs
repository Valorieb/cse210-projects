using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNum;
        int guess = -1;

        Random random = new Random();
        magicNum = random.Next(101);

        while(guess != magicNum){
            Console.WriteLine("What is your guess? ");
            string userInput1 = Console.ReadLine();
            guess = int.Parse(userInput1);

            if(guess > magicNum){
                Console.WriteLine("Lower");
            }else if(guess < magicNum){
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}
