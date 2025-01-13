using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job{
            _company = "Nintendo",
            _jobTitle = "Programmer",
            _startYear = 2015,
            _endYear = 2020,

        };
        
        Job job2 = new Job{
            _company = "Hershey",
            _jobTitle = "Chocolate taster",
            _startYear = 2020,
            _endYear = 2025,
        };

        Resume myResume = new Resume{
            _name = "Pika Chu"
        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
        
    }
}