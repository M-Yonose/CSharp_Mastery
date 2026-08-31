using InheritanceOOP;
Car car = new Car();
car.StartEngine();
car.IncreaseSpeed(20);
Console.WriteLine(car.Model);

Toyota toyota = new Toyota();
toyota.StartEngine();
toyota.IncreaseSpeed(30);
toyota.EmergencyBreak();
Console.WriteLine(toyota.Model);

ToyotaSpecialEdition toyotaSpecial = new ToyotaSpecialEdition();
toyotaSpecial.StartEngine();
toyotaSpecial.IncreaseSpeed(80);
toyotaSpecial.EmergencyBreak();
toyotaSpecial.AutoDrive();
Console.WriteLine(toyotaSpecial.Model);

Car car2 = new ToyotaSpecialEdition();
Console.WriteLine($"Type of car : {car.ToString()}");
Console.WriteLine($"Type of car : {car2.ToString()}");

//car2.AutoDrive();

ToyotaSpecialEdition sp = (ToyotaSpecialEdition)car2;
sp.AutoDrive();



Console.WriteLine("================METHOD OVERRIDING==================");

Sort sort = new Sort([4,5,3,8,1,7]);
sort.SortAscending();

BubbleSort bubblesort = new BubbleSort([4, 5, 3, 8, 1, 7]);
bubblesort.SortAscending();

QSort qsort = new QSort([4, 5, 3, 8, 1, 7]);
qsort.SortAscending();

Console.WriteLine("Enter that algorithm name you want to sort with: ");
string algorithmName = Console.ReadLine();
Sort sorting = new GetAlgorithm().GetSortingAlgorithm(algorithmName, [4, 5, 3, 8, 1, 7]);
sorting.SortAscending();

