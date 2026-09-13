using Structures;
using System.Xml.Schema;

string s = "hello";
int x = 5;
int y = x;

y = 9;

Console.WriteLine(x);
Console.WriteLine(y);

Car car = new Car();
car.fuel = 100;
car.model = "Toyota";

Car car2 = car;
car2.fuel = 700;
car2.model = "Honda";

//Console.WriteLine(car.fuel);
//Console.WriteLine(car.model);
//Console.WriteLine(car2.fuel);
//Console.WriteLine(car2.model);


Test(car);

void Test(Car c)
{
    Console.WriteLine(c.fuel);
    Console.WriteLine(c.model);

    c.fuel = 500;
}


Console.WriteLine(car.fuel);

Fraction f1 = new Fraction(5, 7);
Fraction f2 = new Fraction(4, 9);
Fraction f4 = new Fraction(1, 2);

Fraction f3 = f1 + f2;
Console.WriteLine(f3);
