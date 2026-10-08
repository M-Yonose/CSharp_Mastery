

using ImportantInterfaces;
using System.Collections;

List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

ArrayList arrayList = new ArrayList(names);


List<Person> peopleList = new List<Person>
{
    new Person { Name = "Alice", Age = 30 },
    new Person { Name = "Bob", Age = 25 },
    new Person { Name = "Charlie", Age = 35 }
};

foreach (var person in peopleList)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}


using FileReader fileReader = new FileReader("example.txt");
char c = fileReader.Read();


Product p1 = new Product();
p1.ID = 1;
p1.Name = "Product 1";
p1.Description = "Description of Product 1";
p1.Type = "Type A";
p1.Color = "Red";
p1.Price = 55.99;
p1.Weight = 100;
p1.Size = "Medium";

Product p2 = (Product)p1.Clone();
Product p3 = (Product)p1.Clone();