//For loop
for(int i = 0; i <5; i++)
{
    Console.WriteLine(i);
}

//Example of a for loop: print Even numbers
for(int i = 2; i <- 10; i += 2)
{
    Console.WriteLine(i);
}

//While loop
int w = 1;

while(w <= 5)
{
    Console.WriteLine(w);
    w++;
}
//Do While loop
int X = 10;

do
{
    Console.WriteLine(X);
    X--;
}
while(X > 10);

//For Each loop
int[] numbers = { 11, 22, 33, 44, 55 };
foreach( int values in numbers)
{
    Console.WriteLine(values);
}

//Nested Loops

for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write($"({i}, {j}) ");
    }

    Console.WriteLine();
}