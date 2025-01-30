/******************
* Name: Caleb Roskelley
* Lab 3 ToDo List
* Professor Lewellan
* Due Date: January 29, 2025
******************/
internal class Program
{
    static ToDoList userToDo = new ToDoList();
    static List<string> TaskList = new List<string>();
    static List<string> TaskDescription = new List<string>();
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, this program will allow you to input things you need to do, and you can check them off as you go!");
        Console.WriteLine("Press \"+\" if you would like to add to the list, \"i\" if you'd like information on that task and \"x\" to mark is as completed");
        Console.WriteLine("What would you like to do?");
        string userChoice = Console.ReadLine();
        switch (userChoice)
        {
            case "+":
                addToTaskList();
                addDescription();
                break;
            case "i":
                userToDo.ID = whichTask() - 1;
                userToDo.Title = TaskList[(int) userToDo.ID];
                userToDo.Description = TaskDescription[(int) userToDo.ID];
                userToDo.DisplayDescription();
                break;
            case "x":
                whichTask();
                break;
                
        }
        userToDo.DisplayTask();
    }
    public static void addToTaskList()
    {
        Console.WriteLine("Please provide the title of your task");
        userToDo.Title = Console.ReadLine();
        TaskList.Add(userToDo.Title);
    }

    public static void addDescription()
    {
        Console.WriteLine("Please provide a description for this task");
        TaskDescription.Add(Console.ReadLine());
    }

    public static int whichTask()
    {
        bool isValid = false;
        int num;
        do
        {
            Console.WriteLine("Which task");
            isValid = int.TryParse(Console.ReadLine(), out num);
            if(num < 1 || num > TaskList.Count())
            {
                isValid = false;
            }
        }
        while(!isValid);
        return num;
    }
}