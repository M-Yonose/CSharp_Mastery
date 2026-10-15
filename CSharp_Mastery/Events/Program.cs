using Events;
var items = new int[10000];
for(int i = 0; i < items.Length; i++)
{
    items[i] = new Random().Next(0, 100000);
}

BubbleSort<int> bubbleSortInt = new BubbleSort<int>(items);
bubbleSortInt.OnSortComplete += (sortedItems) =>
{
    Console.WriteLine("Sorting Completed. Sorted Items: ");
    foreach (var item in sortedItems)
    {
        Console.WriteLine(item);
    }

};

Console.WriteLine("Starting Sort...");
Thread t = new Thread(() => bubbleSortInt.Sort((a, b) => a > b));

t.Start();

Console.ReadLine();

