using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        
        Job job2 = new Job();
        job2._jobTitle = "Graphic Designer";
        job2._company = "Apple";

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);

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