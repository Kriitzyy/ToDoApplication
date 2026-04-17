using System;
using ToDo;
using ToDoTask;
using Display;
using ShowTask;
using Done;
using RemoveTasks;

class Program
{ 
    static void Main(string[] args)
    {
        List<ToDoClass> tasks = new List<ToDoClass>();
        
        bool Running = true;

        while (Running)
        {
            TerminalDisplay.DisplayMenu();

            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                Console.Clear();
                    AddTask.Task(tasks);
                    break;
                case "2":
                 Console.Clear();
                    ShowTasks.DisplayTasks(tasks);
                    break;
                case "3":
                Console.Clear();
                    MarkAsDone.MarkTasks(tasks);
                    break;
                Console.Clear();
                case "4":
                    RemoveTask.Remove(tasks);
                    break;
                case "5":
                    Running = false;
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
