DateTime d1 = new DateTime(2023, 10, 15);

DateTime d2 = DateTime.Now;
DateTime d3 = DateTime.UtcNow;

Console.WriteLine(d1.AddDays(-49).Month);

Console.WriteLine(DateTime.IsLeapYear(d2.Year));

Console.WriteLine("---------------------");
Console.WriteLine(d2.ToShortDateString());
Console.WriteLine(d2.ToShortTimeString());
Console.WriteLine(d2.ToLongDateString());
Console.WriteLine(d2.ToLongTimeString());