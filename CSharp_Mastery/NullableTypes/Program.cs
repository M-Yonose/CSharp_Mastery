string? s = null;

int? x = null;

if (x.HasValue)
{
    int p = x.Value;
    Console.WriteLine(p);
}

int q = x ?? 0; // if x is null, q will be 0, otherwise q will be the value of x

x ??= 5; // if x is null, assign 5 to x, otherwise keep the value of x
Console.WriteLine(x);
Console.WriteLine(q);