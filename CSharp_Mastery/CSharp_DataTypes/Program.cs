using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World! This is Mohammed Yonose, Welcome to my Empire :)");


int radious = 5; //variable -> value can change

const double pi = 3.1416; // constant -> value is intended to remain constant

double AreaOfCircle = pi * radious * radious;

Console.WriteLine(AreaOfCircle);



const double PI = 3.14169;

double radious1 = 10.0;
double area = CalculateArea(radious1);
Console.WriteLine(area);

double radious2 = 15.0;
double area2 = CalculateArea(radious2);
Console.WriteLine(area2);

double CalculateArea(double radious)
{
    return PI * radious * radious;
}

var x = 10;
var y = "hello";
var z = true;
var w = 5.0;

var a = CalculateArea(8.0);
Console.WriteLine(a);


//Types of variables in c#
//1. Value Types: A value type stores the actual value.

int age = 25;
long NID = 12345678901234;
byte marks = 95;

Console.WriteLine(age);
Console.WriteLine(NID);
Console.WriteLine(marks);

//Floating-Point Types: Used for decimal numbers.

float height = 5.9f;
double Pi = 3.14159;
decimal balance = 500.50m;

Console.WriteLine(height);
Console.WriteLine(Pi);
Console.WriteLine(balance);

//Character Type: Stores one Unicode character.
char grade = 'A';
char letter = 'W';

Console.WriteLine(grade);
Console.WriteLine(letter);

//Boolean Type: Stores only two values.

bool isPassed = true;
bool isAdmin = false;

Console.WriteLine(isPassed);
Console.WriteLine(isAdmin);

//2. Reference Types: Reference types store a reference (address) to the object.
string name = "My name Mohammed Yonose, Sometimes i pretend to be the Batman, But i am not from the Gotham City!";
Console.WriteLine(name);

//object: The base type of all C# types.

object number = 1999;
object text = "The Batman";
object price = 1947;

Console.WriteLine(number);
Console.WriteLine(text);
Console.WriteLine(price);

//Dynamic: The type is resolved at runtime.

dynamic value = 1971;
Console.WriteLine(value);

value = "WAR_Year";
Console.WriteLine(value);

//Arrays: Arrays are also reference types.

int[] important_years = { 1757, 1947, 1971, 1991, 2024 };

Console.WriteLine(important_years[0]);
Console.WriteLine(important_years[1]);
Console.WriteLine(important_years[2]);
Console.WriteLine(important_years[3]);
Console.WriteLine(important_years[4]);












