WaterBottle bottle1 = new WaterBottle(100, "red");
bottle1.fill(50);
bottle1.fill(20);
bottle1.fill(90);



WaterBottle bottle2 = new WaterBottle(120);
bottle2.fill(100);
bottle2.fill(25);

WaterBottle bottle3 = new WaterBottle();

Console.WriteLine(bottle3.Color);
Console.WriteLine(bottle3.Capacity);

Book book = new Book();

book.Title = "C# in Depth";
book.Author = "Jon Skeet";
book.Price = 850;
Console.WriteLine(book.Title);
Console.WriteLine(book.Author);
Console.WriteLine(book.Price);



