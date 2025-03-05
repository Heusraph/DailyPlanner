using System.Threading.Channels;

namespace DailyPlanner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome to Daily Planner ");
            Console.WriteLine("Please enter your name: ");

            String name = Console.ReadLine();

            Console.WriteLine("Hello " + name + " Welcome to Daily Planner, Please list down what will you do today.");
            Console.WriteLine("What will you do this morning? ");

            String morning = Console.ReadLine();

            Console.WriteLine("That's a wonderful thing to do this morning");
            Console.WriteLine("How about this noon time?: ");

            String noon = Console.ReadLine();

            Console.WriteLine("You are doing great and productive");
            Console.WriteLine("It's time for your bed time, what would you still do before bed? ");

            String bed = Console.ReadLine();

            Console.WriteLine("Goodnight " + name + " Sleepwell and hope to see you tomorrow.");



            Console.ReadKey();

            
        }
    }
}
