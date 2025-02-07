using System;
using Mindfulness;

// I exceeded the requirements by adding a Gratitude Visualization Activity that asks you how many prompts you would like to meditate on and rings a chime each time a new prompt appears.
class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n-----MENU-----");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Visualization Activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nWhat would you like to do? ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus your breathing", 5);
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 5, ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Think of a time when you worked really hard toward a goal and achieved it.", "Think of a time when you had to be brave, even though you were scared.", "Think of a time when you forgave someone, even when it was hard.", "Think of a time when you made a mistake but learned something valuable from it.", "Think of a time when you received unexpected kindness from someone.", "Think of a time you admitted you were wrong."], ["Why was this experience meaningful to you?", "What would you say is the biggest takeaway from this experience?", "How might this experience shape your future decisions or actions?", "How has this experience changed your perspective on yourself or the world around you?", "If you were to share this experience with someone else, what advice would you give them?", "What skills or qualities did you use that helped make this experience successful?", "How does this experience connect to your personal values or goals?", "If you could go back and change anything about this experience, what would it be and why?", "What surprised you the most about this experience?", "Did anyone else play a role in this experience? How did they influence it?", "What challenges did you face during this experience, and how did you overcome them?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"]);
                reflectionActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 5, ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"]);
                listingActivity.Run();

            }
            else if (choice == "4")
            {
                GratitudeActivity gratitudeActivity = new GratitudeActivity("Gratitude Visualization","This activity will help you cultivate gratitude by guiding you through a visualization of the things that bring you joy and peace.",5,["Close your eyes and think of a place where you feel completely at peace.","Take a moment to reflect on the people who bring positivity into your life. Consider their qualities and how they have made a difference for you.","Think about the beauty of the natural world around you. What elements of nature, like the sky, trees, or mountains, fill you with gratitude?","Reflect on a challenge you’ve faced in your life and the strength it took to overcome it. How has that experience shaped who you are today?","Focus on the simple, everyday joys that bring a smile to your face, like a favorite song, a good cup of coffee, or a beautiful sunset.","Appreciate the strength and resilience of your body. Think about all the things it allows you to do, from walking to experiencing the world around you.","Pause and give thanks for the present moment. What is happening right now that brings you peace or joy?","Consider acts of kindness that have been shown to you, whether by strangers or loved ones. How did those moments make you feel?","Reflect on the opportunities in your life that have helped you grow. What doors have opened for you recently, or in the past?","Think about the comfort and safety of your home. What elements of your living space bring you peace and a sense of belonging?","Think about how much you’ve grown over time. What lessons have you learned that make you a stronger, more compassionate person?","Reflect on the people and resources that support you in times of need, whether friends, family, or professional guidance.","Consider your own creativity and how it allows you to express yourself, solve problems, or bring beauty into the world.","Think of a time when you shared a laugh with someone. What was it about that moment that made it special?","Think of something new you’ve learned recently, whether a skill, piece of wisdom, or insight. What impact has it had on you?","Picture a person you are grateful for and remember a time they made you smile.","Think of a challenge you overcame and how it made you stronger."]);
                gratitudeActivity.Run();

            }
            else if (choice == "5")
            {
                Console.WriteLine("\nGoodbye!\n");
                running = false;
            }
        }
    }
}