using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        bool running = true;

        Console.WriteLine("Commands:");
        Console.WriteLine("S - Start");
        Console.WriteLine("T - Stop");
        Console.WriteLine("R - Reset");
        Console.WriteLine("E - Exit");
        Console.WriteLine();

        while (running)
        {
            Console.Write("Enter command: ");
            string input = Console.ReadLine()?.ToUpper();

            switch (input)
            {
                case "S":
                    if (!stopwatch.IsRunning)
                    {
                        stopwatch.Start();
                        Console.WriteLine("Stopwatch started.");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is already running.");
                    }
                    break;

                case "T":
                    if (stopwatch.IsRunning)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Stopwatch stopped at {stopwatch.Elapsed}");
                    }
                    else
                    {
                        Console.WriteLine("Stopwatch is not running.");
                    }
                    break;

                case "R":
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch reset.");
                    break;

                case "E":
                    running = false;
                    Console.WriteLine("Exiting the stopwatch. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }

            if (stopwatch.IsRunning)
            {
                Console.WriteLine($"Elapsed time: {stopwatch.Elapsed}");
            }

            Console.WriteLine();
        }
    }
}
