using System;

public class TaskManager
{
    [TaskInfo(101, "Sai")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed");
    }
}
