using System;
using System.Collections.Generic;

TaskStack taskStack = new TaskStack();

taskStack.AddTask("Задача 1");
taskStack.AddTask("Задача 2");
taskStack.AddTask("Задача 3");

taskStack.RemoveTask();
taskStack.RemoveTask();

taskStack.PrintRemainingTasks();



public class TaskStack
{
    private Stack<string> tasks;

    public TaskStack()
    {
        tasks = new Stack<string>();
    }


    public void AddTask(string task)
    {
        tasks.Push(task);
        Console.WriteLine($"Добавена задача {task}");
    }

    public void RemoveTask()
    {
        if ( tasks.Count > 0)
        {
            string removedTask = tasks.Pop();
            Console.WriteLine($"Премахната задача {removedTask}");
        }
        else
        {
            Console.WriteLine("Няма задачи за премахване!");
        }
    }

    public void PrintRemainingTasks()
    {
        Console.WriteLine("Оставащи задачи в стека:");
        foreach ( var task in tasks )
        {
            Console.WriteLine(task);
        }
    }
}