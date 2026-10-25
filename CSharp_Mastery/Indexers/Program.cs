using Indexers;

int[] ages = [3, 3, 4, 2, 4, 9, 5, 6, 7, 8, 9, 10];

ages[2] = 9;

Console.WriteLine(ages[2]);

List<string> cities = new List<string> { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };
cities[2] = "Dhaka";
Console.WriteLine(cities[2]);


Dictionary<string, int> population = new Dictionary<string, int>
{
    { "New York", 8419600 },
    { "Los Angeles", 3980400 },
    { "Chicago", 2716000 },
    { "Houston", 2328000 },
    { "Phoenix", 1690000 }
};

population["Chicago"] = 3000000;
Console.WriteLine(population["Chicago"]);


Keyboard keyboard = new Keyboard();
keyboard["A"] = new Key { Name = "A", Value = 65 };
keyboard["B"] = new Key { Name = "B", Value = 66 };

/*
 *  Tree tree = new Tree();
 *  tree[5] = new Node { Value = 9 };
 * 
 */