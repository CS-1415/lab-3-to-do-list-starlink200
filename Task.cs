class Task
{
    public int? ID {get; set;}
    public string? Title {get; set;}
    public string? Description {get; set;}
    public bool isCompleted {get; set;}


    public void DisplayTask()
    {
        if(isCompleted)
        {
            MarkAsCompleted();
        }
        else
        {
            Console.WriteLine($"[ ] {ID}  {Title}");
        }
    }

    public void DisplayDescription()
    {
        Console.WriteLine($"{Title} is {Description}");
    }

    public void MarkAsCompleted()
    {
        Console.WriteLine($"[x] {ID}  {Title}");
    }

}