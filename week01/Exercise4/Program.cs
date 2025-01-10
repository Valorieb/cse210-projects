using System;

class Program
{
    static void Main(string[] args)

    {
        int number = -1;
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished.\n");
 
        while(number != 0){
            Console.WriteLine("Enter a number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if(number != 0){
                numbers.Add(number);
            }
        }

        int sum = 0;
        int ave = 0;
        int max = 0;
        int length = numbers.Count;

       for (int i = 0; i < numbers.Count; i++){
            int currentNum = (numbers[i]);
            sum += currentNum;
            if(i > 0 && currentNum > numbers[i-1]){
                max = currentNum;
            }
        }

        ave = sum/length;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max}");
    }
}