using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DailyPlanner
{
    class UserInput
    {
        public static string UserName()
        {
            string name;
            while (true) 
            {
                Console.WriteLine("Hi, Welcome to Daily Planner!");
                Console.WriteLine("Please Enter your name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name)) 
                {
                    Console.WriteLine("I need something to call you Ma'am/Sir.");
                }
                else
                {
                    Console.WriteLine($"Welcome {name}");
                    break;
                }
                
            } 

            return name;
        }

        public static List<string> Task(string timeofDay)
        {
            List<string> UserTask = new List<string>();
            string Task;

            Console.WriteLine(TaskPrompt(timeofDay));
            Console.WriteLine("Enter a tasks one by one. Type 'done' when you're finished.");

            while (true)
            {
                Task = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Task))
                {
                    Console.WriteLine("You need to do a task, please enter a task.");
                }
                else if (Task.ToLower() == "done")
                {
                    if (UserTask.Count == 0)
                    {
                        Console.WriteLine("You need at least one task. Please enter a task.");

                    }
                    else
                    {
                        break;  
                    }
                }
                else
                {
                    UserTask.Add(Task);
                }
               

            }

            Console.WriteLine($"Looks like you've got {UserTask.Count} task planned for this {timeofDay}!");
            return UserTask;

        }
               private static string TaskPrompt(string timeofDay)
            {
            string[] times = { "morning", "noon", "evening" };
            string[] replies =
            {
                "What are your task this morning?", "Got any plan this noon?", "Any routine before bedtime?"
            };
                for (int i = 0; i < times.Length; i++)
            {
                if (timeofDay == times[i])
                {
                    return replies[i];
                }
            }
                return $"What will you do this {timeofDay}?";
            }        
    }
}
