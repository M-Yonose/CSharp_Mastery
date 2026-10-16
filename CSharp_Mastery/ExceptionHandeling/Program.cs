using ExceptionHandling;

bool isDone = false;

try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    int c = a / b;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred: Division by zero is not allowed.");
}
catch (FormatException ex)
{
    Console.WriteLine("An error occurred: Please enter valid integers.");
}
catch (TooLargeExpection ex)
{
    Console.WriteLine("An error occurred: The number is too large.");
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}
finally
{
    isDone = true;
}