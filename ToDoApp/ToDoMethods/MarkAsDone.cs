using ToDo;

namespace Done
{
public class MarkAsDone
{
    public static void MarkTasks(List<ToDoClass> tasks)
    {
        
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to mark as done.");
            return;
        }

        Console.WriteLine("\nEnter the number of the task to mark as done:");
        
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].Title} {(tasks[i].IsCompleted ? "(Done)" : "")}");
        }

        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].IsCompleted = true;
            Console.WriteLine("\nTask marked as done successfully!");
        }
        else
        {
            Console.WriteLine("\nInvalid task number. Please try again.");
        }

    }
}
}