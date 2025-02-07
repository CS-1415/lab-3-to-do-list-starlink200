/******************
* Name: Caleb Roskelley
* Lab 3 ToDo List
* Professor Lewellan
* Due Date: January 29, 2025
******************/
internal class Program
{
    private static void Main(string[] args)
    {
        List<Task> TaskList = new List<Task>();
        Console.WriteLine("Hello, this program will allow you to input things you need to do, and you can check them off as you go!");
        Console.WriteLine("Press \"+\" if you would like to add to the list, \"i\" if you'd like information on that task and \"x\" to mark is as completed");
        bool keepGoing = true;
        while(keepGoing)
        {
            Console.WriteLine("What would you like to do?");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "+":
                    Task userToDo = new Task();
                    userToDo.ID = TaskList.Count() + 1;
                    userToDo.Description = addDescription();
                    userToDo.Title = setTitle();
                    TaskList.Add(userToDo);
                    break;
                case "i":
                    // userToDo.ID = whichTask() - 1;
                    // userToDo.Title = TaskList[userToDo.ID];
                    // userToDo.Description = TaskDescription[userToDo.ID];
                    // userToDo.DisplayDescription();
                    int whichOne = whichTask(TaskList.Count) - 1;
                    TaskList[whichOne].DisplayTask();
                    TaskList[whichOne].DisplayDescription();
                    Console.WriteLine();
                    break;
                case "x":
                    TaskList[whichTask(TaskList.Count()) - 1].isCompleted = true;
                    break;
                    
            }
            Console.WriteLine("    ID   Task");
            Console.WriteLine("-----------------");
            foreach(Task item in TaskList)
            {
                item.DisplayTask();
            }
        }
    }
    public static string setTitle()
    {
        Console.WriteLine("Please provide the title of your task");
        return Console.ReadLine();
    }

    public static string addDescription()
    {
        Console.WriteLine("Please provide a description for this task");
        return Console.ReadLine();
    }

    public static int whichTask(int count)
    {
        bool isValid = false;
        int num;
        do
        {
            Console.WriteLine("Which task");
            isValid = int.TryParse(Console.ReadLine(), out num);
            if(num < 1 || num > count)
            {
                isValid = false;
            }
        }
        while(!isValid);
        return num;
    }
}