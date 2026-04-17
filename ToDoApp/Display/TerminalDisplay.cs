namespace Display
{
public class TerminalDisplay
{
    public static void DisplayMenu()
    {
        Console.WriteLine("----- To-Do List Application -----");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Show Tasks");
        Console.WriteLine("3. Mark Task as Done");
        Console.WriteLine("4. Remove Task");
        Console.WriteLine("5. Exit");

        Console.Write("\nSelect an option: ");
    
        }
        public static void ToContinue()
        {
            Console.WriteLine("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}