
using System.Text;

string s = "Hello World"; // 12359

s += " From C#";  // 23521


string m = s;

m = "new";


StringBuilder sb = new StringBuilder();
sb.Append("Hello").Append(" ");
sb.Append("World");

string final = sb.ToString();

Console.WriteLine(final);

sb.Remove(5, 3);

Console.WriteLine(sb);

sb[3] = 'X';

Console.WriteLine(sb);

Console.WriteLine(s[3]);