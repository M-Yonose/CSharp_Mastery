
using LinqExample;

string[] names = [
    "Alice",
    "Bob",
    "Charlie",
    "David",
    "Eve"
];

IEnumerable<string> r = from n in names
                        where n.Length > 4
                        select n;

foreach (var name in r)
    Console.WriteLine(name);


// loop based version
foreach (var name in names)
{
    if (name.Length > 4)
        Console.WriteLine(name);
}


List<Person> people = new List<Person>
{
    new Person { Id = 1, Name = "Alice", Age = 30 },
    new Person { Id = 2, Name = "Bob", Age = 25 },
    new Person { Id = 3, Name = "Charlie", Age = 35 },
    new Person { Id = 4, Name = "David", Age = 28 },
    new Person { Id = 5, Name = "Eve", Age = 32 }
};

List<Customer> customers = new List<Customer>
{
    new Customer { Id = 1, LastLogin = DateTime.Now.AddDays(-1), IsActive = true },
    new Customer { Id = 2, LastLogin = DateTime.Now.AddDays(-10), IsActive = false },
    new Customer { Id = 3, LastLogin = DateTime.Now.AddDays(-5), IsActive = true },
    new Customer { Id = 4, LastLogin = DateTime.Now.AddDays(-20), IsActive = false },
    new Customer { Id = 5, LastLogin = DateTime.Now.AddDays(-2), IsActive = true }
};

IEnumerable<string> r2 = from p in people
                         where p.Age > 30
                         orderby p.Name ascending, p.Age descending
                         select p.Name;




IEnumerable<string> r3 = people.Where(p => p.Age > 30).Select(p => p.Name);



var reports = from c in customers
              join p in people on c.Id equals p.Id
              where c.IsActive && p.Age >= 30
              select new { p.Name, c.LastLogin };


int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var numberGroups = from n in numbers
                   group n by n % 5 into g
                   select (Remainder: g.Key, Numbers: g);

var numberGroups2 = numbers.GroupBy(n => n % 5)
                           .Select(g => (Remainder: g.Key, Numbers: g));

foreach (var m in numberGroups)
{
    Console.WriteLine($"Numbers with a remainder of {m.Remainder} when divided by 5:");
    foreach (var n in m.Numbers)
    {
        Console.WriteLine(n);
    }
}