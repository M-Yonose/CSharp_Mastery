
using System.Text;

string currentFolderName = Directory.GetCurrentDirectory();
DirectoryInfo currentFolder = new DirectoryInfo(currentFolderName);

Console.WriteLine(currentFolder.Parent.Parent.Parent.FullName);


string path = "..\\..\\..\\demo.txt";

if (!File.Exists(path))
    File.WriteAllText(path, "Hello from C#");
else
{
    string s = File.ReadAllText(path);
    Console.WriteLine(s);
    Console.WriteLine(File.GetLastAccessTime(path));
}

FileInfo file = new FileInfo(path);
string copyToPath = Console.ReadLine();
if (file.Exists && !File.Exists(copyToPath))
    file.CopyTo(copyToPath);


if (file.Exists)
{
    using FileStream stream = file.Open(FileMode.Open);
    string demoText = "This is an additional Text";
    byte[] textBytes = UTF8Encoding.UTF8.GetBytes(demoText);

    stream.Write(textBytes, 10, 5);
}

if (file.Exists)
{
    using FileStream stream = file.Open(FileMode.Open);
    byte[] buffer = new byte[file.Length];

    int count = stream.Read(buffer, 0, (int)file.Length);
    string readText = UTF32Encoding.UTF8.GetString(buffer);
    Console.WriteLine(readText);
}


string folderPath = "E:\\Trainings\\aspnet_b14\\src\\CSharpCourse\\FileOperations\\MyDocuments";

if (!Directory.Exists(folderPath))
    Directory.CreateDirectory(folderPath);

Directory.SetCurrentDirectory(folderPath);

if (!Directory.Exists("hello.txt"))
    File.WriteAllText("hello.txt", "This is text content");

DirectoryInfo folderInfo = new DirectoryInfo(folderPath);
var files = folderInfo.GetFiles();

Console.WriteLine("Current folder:" + folderInfo.FullName);
Console.WriteLine("Files in it:");
foreach (var f in files)
    Console.WriteLine(f.FullName);

