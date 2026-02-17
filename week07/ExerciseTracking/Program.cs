using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        Running run = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling bike = new Cycling(new DateTime(2022, 11, 3), 45, 12.0);
        Swimming swim = new Swimming(new DateTime(2022, 11, 3), 20, 20);

        List<Activity> activities = new List<Activity>() { run, bike, swim };


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}