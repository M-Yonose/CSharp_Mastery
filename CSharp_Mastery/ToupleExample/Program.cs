
var m = Calculate(10, 2);
Console.WriteLine(m.Item1);
Console.WriteLine(m.Item2);

(int, int) Calculate(int a, int b)
{
    int division = a / b;
    int multiplication = a * b;
    return (division, multiplication);
}


void Test((string, double, bool) something, int count)
{
    string x = something.Item1;
    double y = something.Item2;
    bool z = something.Item3;

    something.Item1 = "hello";
}

(string a, int b)[] f = new (string, int)[]
{
    ("One", 1),
    ("Two", 2),
    ("Three", 3)
};