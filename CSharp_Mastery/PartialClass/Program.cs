using PartialClass;

Product laptop = new Product("Laptop: ", 1600);

Console.WriteLine(laptop.Name + laptop.Price);

laptop.Name = "Gaming Laptop: ";
laptop.Price = 2000;

Console.WriteLine(laptop.Name + laptop.Price);


