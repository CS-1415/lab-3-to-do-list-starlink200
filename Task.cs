public class Task
{
    public int ID {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public bool isCompleted {get; set;}

    public Task(int id, string title, string description)
    {
        ID = id;
        Title = title;
        Description = description;
    }
    public Task(int id, string title, string description, bool _isCompleted)
    {
        ID = id;
        Title = title;
        Description = description;
        isCompleted = _isCompleted;
    }

    public Task()
    {
    }

    public void DisplayTask()
    {
        if(isCompleted)
        {
            MarkAsCompleted();
        }
        else
        {
            Console.WriteLine($"[ ] {ID}    {Title}");
        }
    }

    public void DisplayDescription()
    {
        Console.WriteLine($"    -{Description}");
    }

    public void MarkAsCompleted()
    {
        Console.WriteLine($"[x] {ID}    {Title}");
    }

}