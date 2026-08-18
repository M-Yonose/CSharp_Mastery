//Conditional (Ternary) Operator
int age = 20;
string result = age >=18 ? "adult" : "minor";
Console.WriteLine(result);

//Null-Coalescing Operator
string? name = null;
string Username = name ?? "Guest";
Console.WriteLine(Username);

///A real life example
int english = 80;
int science = 70;
int physics = 87;

double avg = (english + science + physics) / 3.0;

bool passed = avg >= 50;

Console.WriteLine($"Avarage of three subjects: {avg}");
Console.WriteLine($"Passed: {passed}");

////////Practice from ASP.NET course class_4 codes:

int x = 5;

x++; // x = x + 1;
++x; // x = x + 1;

x--; // x = x - 1;
--x; // x = x - 1;


int a = 5;
int z = a++;
Console.WriteLine("a:" + a);
Console.WriteLine("z:" + z);


int b = 5;
int w = ++b;
Console.WriteLine("b:" + b);
Console.WriteLine("w:" + w);


int c = a + b;
int c2 = a - b;
int c3 = a * b;
int c4 = a / b;
int c5 = a % b;

int t = (a * b - c) / x++;


int heightOfRahim = 45;
int heightOfKarim = 50;

bool isRahimTaller = heightOfRahim > heightOfKarim;
bool isKarimTaller = heightOfRahim < heightOfKarim;
bool isEqualHeight = heightOfRahim == heightOfKarim;
bool isNotEqualHeight = heightOfRahim != heightOfKarim;
bool isRahimTallerOrEqual = heightOfRahim >= heightOfKarim;
bool isKarimTallerOrEqual = heightOfRahim <= heightOfKarim;

bool isRahimTallerAndTall = heightOfRahim > heightOfKarim && heightOfRahim > 40;
bool isRahimTallerOrEqualAndTall = heightOfRahim < heightOfKarim || heightOfRahim > 40;

/*
 *  true && true = true
 *  true && false = false
 *  false && false = false
 *  
 *  true || true = true
 *  true || false = true
 *  false || false = false
 * 
 **/




// 0-1 -> Computer, Binary
// 0-9 -> Human, Decimal
// 0-7 -> Octal
// 0-9, A-F -> Hexadecimal

int p = 933_048_309;

int[] q = [3, 4, 9, 4, 3, 7];

int r = 3 * 10 ^ 5 + 4 * 10 ^ 4 + 9 * 10 ^ 3 + 4 * 10 ^ 2 + 3 * 10 ^ 1 + 7 * 10 ^ 0;
int r2 = 0b_1101; // 1 * 2^3 + 1 * 2^2 + 0 * 2^1 + 1 * 2^0

Console.WriteLine("r2:" + r2);
Console.WriteLine("r2 in binary: " + Convert.ToString(r2, toBase: 2));

Console.WriteLine("p in binary: " + Convert.ToString(p, toBase: 2));


// 1010111001 -> 0010101110

// 1010111001 <- 1011100100

int m1 = 0b_1010111001;
m1 = m1 << 2; // 101011100100
Console.WriteLine("m1 in binary: " + Convert.ToString(m1, toBase: 2));

int m2 = 0b_1010111001;
m2 = m2 >> 2; // 0010101110
Console.WriteLine("m2 in binary: " + Convert.ToString(m2, toBase: 2));

int n1 = 0b_1010111001;
int n2 = 0b_0010101110;

int t1 = n1 & n2; // 0010101000
int t2 = n1 | n2; // 1010111111
Console.WriteLine("t1 in binary: " + Convert.ToString(t1, toBase: 2));
Console.WriteLine("t2 in binary: " + Convert.ToString(t2, toBase: 2));

int u = 31;

Console.WriteLine(Convert.ToString(u, 2));
Console.WriteLine(Convert.ToString(u, 8));
Console.WriteLine(Convert.ToString(u, 16));
