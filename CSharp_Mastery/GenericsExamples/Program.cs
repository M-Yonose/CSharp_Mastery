
using GenericsExamples;

Point<int, int> point1 = new Point<int, int>(2, 3);
Point<decimal, decimal> point2 = new Point<decimal, decimal>(2.5m, 3.5m);
Point<double, int> point3 = new Point<double, int>(2.5, 3);
Point<long, short> point4 = new Point<long, short>(2L, 3);
Point<short, double> point5 = new Point<short, double>(2, 3);
//Point<int, int> point1 = new Point<int, int>(2, 3);
//Point<decimal, decimal> point2 = new Point<decimal, decimal>(2.5m, 3.5m);
//Point<double, int> point3 = new Point<double, int>(2.5, 3);
//Point<long, short> point4 = new Point<long, short>(2L, 3);
//Point<short, double> point5 = new Point<short, double>(2, 3);

var bubbleSort = new BubbleSort<double>([50.3, 32.1, 71.2, 32.3, 41.9, 88.7]);
bubbleSort.Sort();
foreach (var item in bubbleSort.Numbers)
    Console.WriteLine(item);

var result2 = BubbleSort2.Sort<double>([50.3, 32.1, 71.2, 32.3, 41.9, 88.7]);

foreach (var item in result2)
    Console.WriteLine(item);



ShoppingCart<Electronics<decimal>, decimal> cart = new ShoppingCart<Electronics<decimal>, decimal>(new Electronics<decimal>[]
{
    new Electronics<decimal>{ Price = 2000, Name = "Camera" },
    new Electronics<decimal>{ Price = 3000, Name = "Laptop" },
    new Electronics<decimal>{ Price = 4000, Name = "Desktop" }
});

var total = cart.GetTotal();
Console.WriteLine(total);