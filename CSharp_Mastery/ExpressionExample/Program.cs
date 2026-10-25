using System.Linq.Expressions;

Func<int, int, int> add = (x, y) => x + y;
int r = add(2, 3);
Console.WriteLine(r);

Expression<Func<int, int, int>> e = (x, y) => x + y;
Func<int, int, int> f = e.Compile();
int r2 = f(5, 7);
Console.WriteLine(r2);

Func<int, int, int> v = (x, y) =>
{
    int a = 8;
    int b = 7;
    return x + y + a + b;
};