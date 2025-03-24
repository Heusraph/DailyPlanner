using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner
{
    class Userinput
    {
        public static string UserName()
        {
            string name = "";
            while (string.IsNullOrWhiteSpace(name)) 
            {
                Console.WriteLine("Hi, Welcome to Daily Planner!");
                Console.WriteLine("Please Enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name)) 
                {
                    Console.WriteLine("Put something first before we proceed.");
                }
                else
                {
                    Console.WriteLine($"Welcome {name}");
                }
            } 

            return name;
        }

        public static string Task(string timeofDay)
        {
            string Task = "";
            while (string.IsNullOrWhiteSpace(Task))
            {
                Console.WriteLine($"What will you do this {timeofDay}?");
                Task = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Task)) 
                {
                    Console.WriteLine("You need to do a task, please enter a task.");
                }

                else
                {
                    if (timeofDay == "morning")
                        {
                        Console.WriteLine($"Amazing, you're being productive this {timeofDay}!");
                    }
                    else if (timeofDay == "noon")
                    {
                        Console.WriteLine($"That's what I'm talking about!");
                    }
                    else if (timeofDay == "evening")
                    {
                        Console.WriteLine($"Goodjob, you did great the whole day!");

                    }   

                  }
            } 
     
            return Task;
        }
    }
}
