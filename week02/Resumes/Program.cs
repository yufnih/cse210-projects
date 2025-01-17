using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2001;
        job1._endYear = 2018;
        
        Job job2 = new Job();
        job2._jobTitle = "Graphic Designer";
        job2._company = "Apple";
        job2._startYear = 2011;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._person = "John McBitt";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}

// Class: Job
// _company : string
// _jobTitle : string
// _startYear : int
// _endYear : int
// Display() : void

// Class : Resume
// _name : string
// _jobs : List<job>
// Display() : void