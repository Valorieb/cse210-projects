using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int squaredNum = SquareNumber(favNum);
        DisplayResult(userName, squaredNum);

}
static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program! \n");
        }
        static string PromptUserName(){
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber(){
            Console.Write("What is your favorite number? ");
            string userInput = Console.ReadLine();
            int favNum = int.Parse(userInput);
            return favNum;
        }
        static int SquareNumber(int favNum){
            int squaredNum = favNum * favNum;
            return squaredNum;
        }
        static void DisplayResult(string userName, int squaredNum){
            Console.WriteLine($"{userName}, the square of your number is {squaredNum}. \n");
        }
}