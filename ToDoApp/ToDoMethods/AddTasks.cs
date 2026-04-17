using ToDo;

namespace ToDoTask
{
public class AddTask
{
    public static void Task(List<ToDoClass> tasks)
    {

        Console.WriteLine("\nEnter the title of the task:");
        string Title = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(Title))
        {
            Console.WriteLine("Task title cannot be empty. Please try again.");
            return;
        }

            tasks.Add(new ToDoClass
            {
                Title = Title,
                IsCompleted = false
            });

            Console.WriteLine("\nTask added successfully!");
    }
    }

}