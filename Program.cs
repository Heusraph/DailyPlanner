using System.Threading.Channels;

namespace DailyPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = UserInput.UserName();

            Console.WriteLine($"Hello {name}, let's plan your day!");

            string[] timesofDay = { "morning", "noon", "evening" };
            Dictionary<string, List<string>> taskbyTime = new Dictionary<string, List<string>>();

            foreach (var time in timesofDay)
            {
                taskbyTime[time] = UserInput.Task(time);
            }
            Planner.SayGoodbye(name);
            Console.ReadKey();

        }


    }
}