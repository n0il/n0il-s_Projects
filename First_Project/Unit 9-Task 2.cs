using System.Collections.Generic;

WorkingWithPriorityQueues();

static void OutputPQ<TElement,TPriority>(string title, IEnumerable<(TElement Element, TPriority Priority)> collection)
{
    Console.WriteLine(title);
    foreach((TElement, TPriority) item in collection)
    {
        Console.WriteLine($"{item.Item1}:{item.Item2}");
    }
}
static void WorkingWithPriorityQueues()
{
    PriorityQueue<string, int> vaccine = new();
    //1 = High priority people in their 70s or in poor health
    //2 = Medium priority people like middle aged people
    //3 = Low priority people like teens and people in their twenties

    vaccine.Enqueue("Pamela", 1);
    vaccine.Enqueue("Rebecca", 3);
    vaccine.Enqueue("Juliet", 2);
    vaccine.Enqueue("Ian", 1);
    OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
    Console.WriteLine($"{vaccine.Dequeue()} has been vaccinated!");
    Console.WriteLine($"{vaccine.Dequeue()} has been vaccinated!");
    OutputPQ("Current queue for vaccination:", vaccine.UnorderedItems);
    Console.WriteLine($"{vaccine.Dequeue()} has been vaccinated!");
    vaccine.Enqueue("Mark", 2);
    Console.WriteLine($"{vaccine.Peek()} will be next to be vaccinated!");
    OutputPQ("Current queue for vaccination is:", vaccine.UnorderedItems);
}