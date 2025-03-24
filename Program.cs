using System.Threading.Channels;

namespace DailyPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Userinput.UserName();

            Console.WriteLine($"Hello {name}, let's plan your day!");

            string morningRoutine = Userinput.Task("morning");
            string noonRoutine = Userinput.Task("noon");
            string eveningRoutine = Userinput.Task("evening");

            Planner.SayGoodbye(name);

            Console.ReadKey();

        }

        static string UserName()
        {
            Console.WriteLine("Hi!, Welcome to Daily Planner!");
            Console.Write("Please Enter your name: ");
            return Console.ReadLine();
        }

        static string Task(string timeofDay)
        {
            Console.WriteLine($"What will you do this {timeofDay}?");
            string task = Console.ReadLine();
            Console.WriteLine($"That's a wonderfull thing to do this {timeofDay}!");
            return task;
        }
        static void SayGoodbye(string name)
        {
            Console.WriteLine($"Goodnight {name}, sleepwell and see you tomorrow!");


    }
}