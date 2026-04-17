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
            Console.Clear();

            TerminalDisplay.DisplayMenu();

            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    AddTask.Task(tasks);
                    TerminalDisplay.ToContinue();
                    break;
                case "2":
                    ShowTasks.DisplayTasks(tasks);
                    TerminalDisplay.ToContinue();
                    break;
                case "3":
                    MarkAsDone.MarkTasks(tasks);
                    TerminalDisplay.ToContinue();
                    break;
                case "4":
                    RemoveTask.Remove(tasks);
                    TerminalDisplay.ToContinue();
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
