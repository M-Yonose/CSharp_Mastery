double number = 1234.5689;

Console.WriteLine($"Number: {number:F3}");
Console.WriteLine($"Number:" + number.ToString("0.00"));

int x = 5;
int y = 6;
Console.WriteLine("X={0}, Y={1}", x, y);
Console.WriteLine($"X={x}, Y={y}");

string m = $"X:{x}, Y:{y}";
Console.WriteLine(m);

string n = $"Number: " + number.ToString("0.000");
Console.WriteLine(n);

DateTime today = DateTime.Now;
Console.WriteLine(today);

Console.WriteLine(today.ToString("d/M/yy"));

