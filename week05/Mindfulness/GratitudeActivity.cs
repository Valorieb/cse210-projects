using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Media;

namespace Mindfulness
{
    public class GratitudeActivity : Activity
    {
        private List<string> _prompts;
        private int _numOfPrompts = 1;

        public GratitudeActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
        {
            _prompts = prompts;
        }
        public void SetDuration(int duration)
        {
            Duration = duration;
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int length = _prompts.Count;
            int randomIndex = random.Next(0, length);
            string randomPrompt = _prompts[randomIndex];
            return randomPrompt;
        }

        public void PlayChime(){
            string soundFile ="chime.wav";
            SoundPlayer player = new SoundPlayer(soundFile);
            player.Play();
        }

        public void Run()
        {
            DisplayStartingMessage();
            int length = _prompts.Count;
            Console.WriteLine("How many prompts would you like to focus on this session?");
            Console.WriteLine($"Please pick a number from 1 to {length}.");

            string input = Console.ReadLine();
            _numOfPrompts = int.Parse(input);
            Console.WriteLine($"You will recieve {_numOfPrompts} prompts.");
            Console.WriteLine($"A bell will chime at the start of each prompt.");
            Console.WriteLine($"Press enter when you are ready to begin.");
            string ready = Console.ReadLine();

            if (ready == "")
            {
                Console.Write("You may begin in: ");
                ShowCountDown(3);

                int waitTime = (int)Math.Round((double)Duration / _numOfPrompts) ;
                
                    for (int i = 0; i < _numOfPrompts; i++)
                    {
                        PlayChime();
                        Console.Clear();
                        Thread.Sleep(200);
                        string prompt = GetRandomPrompt();
                        Console.WriteLine(prompt);
                        ShowCountDown(waitTime);
                        Thread.Sleep(100);
                        
                    }
            }
            DisplayEndingMessage();
        } //end of Run    
    } //end of Class
} //end of Namespace