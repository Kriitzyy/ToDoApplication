using ToDo;

namespace ShowTask
{
public class ShowTasks
{
    public static void DisplayTasks(List<ToDoClass> tasks)
    {
        
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to show.");
            return;
        }

        Console.WriteLine("\nCurrent Tasks:");

        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task.Title} {(task.IsCompleted ? "(Done)" : "")}");
        }
    }
}
}