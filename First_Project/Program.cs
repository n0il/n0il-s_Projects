using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Xml;

WorkingWithQueues();
//Console.WriteLine(WorkingWithQueues);
static void WorkingWithQueues()
{
    Queue<string> coffee = new();
    coffee.Enqueue("Damir");
    coffee.Enqueue("Andrea");
    coffee.Enqueue("Ronald");
    coffee.Enqueue("Amin");
    coffee.Enqueue("Irina");
    Output("Initial queue from front to back is:", coffee);
    
    string served = coffee.Dequeue();
    
    Console.WriteLine($"Served: {served}");
    served = coffee.Dequeue();
    Console.WriteLine($"Served: {served}");
    Output("Current queue from front to back is:", coffee );


    Console.WriteLine($"{coffee.Peek()} is next in line.");
    Output("Current queue from front to back is:", coffee);

}
static void Output(string message, Queue<string> queue)
{
    Console.WriteLine(message);
    foreach(var item in queue)
    {
        Console.WriteLine(item);
    } 
        
    Console.WriteLine();
}
