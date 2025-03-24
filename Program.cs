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


    }
}