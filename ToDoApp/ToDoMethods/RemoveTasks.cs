using System.Xml.Serialization;
using ToDo;

namespace RemoveTasks
{
public class RemoveTask
{
    public static void Remove(List<ToDoClass> tasks)
    {

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to remove.");
            return;
        }

        Console.WriteLine("\nTasks:");

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1 }. {tasks[i].Title}");
        }

        Console.WriteLine("\nEnter the number of tasks you want to remove:");

        string UserInput = Console.ReadLine();

        if (int.TryParse(UserInput, out int choice))
        {
            if (choice >= 1 && choice <= tasks.Count)
                {
                    tasks.RemoveAt(choice - 1);
                    Console.WriteLine("Task Removed! ");
                }
                else
                {
                    Console.WriteLine("Invalind input, try again");
                }  
        }
        else
            {
                Console.WriteLine("Please enter a valid number.. Try again ");
            }
            

    }
}
}