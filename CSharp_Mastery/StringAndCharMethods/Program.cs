Console.WriteLine("===  STRING METHODS EXAMPLES ===\n");

string text = "  Hello World from C#  ";
Console.WriteLine($"Original Text: \"{text}\"");

// --- 1. Checking and Searching Contents ---
// Contains: Checks if a substring exists
bool hasWorld = text.Contains("World");
Console.WriteLine($"Contains 'World': {hasWorld}");

// StartsWith / EndsWith: Checks patterns at the boundaries (using Trimmed text for accuracy)
string trimmedForCheck = text.Trim();
bool starts = trimmedForCheck.StartsWith("Hello");
bool ends = trimmedForCheck.EndsWith("Java");
Console.WriteLine($"Starts with 'Hello': {starts}");
Console.WriteLine($"Ends with 'Java': {ends}");

// IndexOf: Finds the starting index of a substring
int position = text.IndexOf("World");
Console.WriteLine($"Index of 'World': {position}");


// --- 2. Modifying and Extracting Text ---
// Trim: Removes leading and trailing whitespace
string cleanText = text.Trim();
Console.WriteLine($"Trimmed text: \"{cleanText}\"");

// Substring: Extracts a part of the string (startIndex, length)
string sub = cleanText.Substring(0, 5);
Console.WriteLine($"Substring (first 5 chars): \"{sub}\"");

// Replace: Swaps characters or words
string swapped = cleanText.Replace("C#", "C# Programming");
Console.WriteLine($"Replaced text: \"{swapped}\"");

// Case Transformation
string upper = cleanText.ToUpper();
string lower = cleanText.ToLower();
Console.WriteLine($"ToUpper: \"{upper}\"");
Console.WriteLine($"ToLower: \"{lower}\"");


// --- 3. Splitting and Joining ---
string csv = "apple,banana,orange";
Console.WriteLine($"\nOriginal CSV: \"{csv}\"");

// Split: Breaks a string into an array based on a delimiter
string[] fruits = csv.Split(',');
Console.WriteLine("Split array elements:");
foreach (string fruit in fruits)
{
    Console.WriteLine($"- {fruit}");
}

// Join: Merges an array back into a single string
string combined = string.Join(" | ", fruits);
Console.WriteLine($"Joined string: \"{combined}\"");



Console.WriteLine("\n\n===  CHAR METHODS EXAMPLES ===\n");

char letter = 'A';
char digit = '7';
char whitespace = ' ';
char punctuation = '!';

// Character Validation
Console.WriteLine($"Is '{letter}' a letter? {char.IsLetter(letter)}");
Console.WriteLine($"Is '{digit}' a digit? {char.IsDigit(digit)}");
Console.WriteLine($"Is '{digit}' a letter or digit? {char.IsLetterOrDigit(digit)}");
Console.WriteLine($"Is '{whitespace}' whitespace? {char.IsWhiteSpace(whitespace)}");
Console.WriteLine($"Is '{punctuation}' punctuation? {char.IsPunctuation(punctuation)}");

// Case Checking
Console.WriteLine($"Is '{letter}' uppercase? {char.IsUpper(letter)}");
Console.WriteLine($"Is '{letter}' lowercase? {char.IsLower(letter)}");

// Case Conversion
char lowerChar = 'b';
char upperChar = 'M';
Console.WriteLine($"Convert '{lowerChar}' to upper: {char.ToUpper(lowerChar)}");
Console.WriteLine($"Convert '{upperChar}' to lower: {char.ToLower(upperChar)}");



Console.WriteLine("\n\n=== INTEROPERABILITY (STRING <=> CHAR ARRAY) ===\n");

string word = "Code";
Console.WriteLine($"Original word: \"{word}\"");

// Convert string to char array
char[] charArray = word.ToCharArray();
Console.Write("Converted to char array: ");
Console.WriteLine(string.Join(", ", charArray));

// Convert char array back to string
string restoredWord = new string(charArray);
Console.WriteLine($"Restored back to string: \"{restoredWord}\"\n");


Console.WriteLine("================= Class Code Practice ==================\n");

string s = "Hello, World!";
char c = 'A';


string[] parts = s.Split(',');
string joined = String.Join(',', parts);

Console.WriteLine(joined);
Char.IsDigit('1'); // true

s = s.PadLeft(30);
Console.WriteLine(s.Trim());


string n = "12-34";
int m = int.Parse(n);

if (int.TryParse(n, out int z))
    Console.WriteLine(m);