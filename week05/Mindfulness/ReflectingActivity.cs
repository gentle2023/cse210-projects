using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
          )
    {
    }

    public void Run()
    {
        ActivityLog.LogReflection();
        DisplayStartingMessage();

        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        Console.WriteLine();
        Console.WriteLine("--- Prompt ---");
        Console.WriteLine(_prompts[index]);
    }

    private void DisplayQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);

        Console.WriteLine();
        Console.Write(_questions[index] + " ");
    }
}
