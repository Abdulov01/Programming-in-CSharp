

using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;



 //TASK - Write a program in C# Sharp to create and read the last line of a file.


class Program
{
    const string myDirectory = @"C:\Users\Abdulov\Downloads\";
     static string fileName;

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the file name:");
         fileName = Console.ReadLine();

      var Directory = new DirectoryInfo(myDirectory);


        var fileContent = CreateText();
        CreateAndWriteFile(fileContent);
        LastLineOfText();
    }

    public static void LastLineOfText()
    {
        var file1 = Path.Combine(myDirectory + fileName + ".txt");
        string[] texts = File.ReadAllLines(file1);
        string lastLine = texts.Last();
        Console.WriteLine($"The last line of current file is: {lastLine}");
    }



    public static void CreateAndWriteFile(FileContent fileContent)
    {
        var file = Path.Combine(myDirectory + fileName + ".txt");
        var fileText = $"Name: {fileContent.name}\n" +
            $"Surname: {fileContent.surname}\n" +
            $"Age: {fileContent.age}\n" +
            $"University Name: {fileContent.universityName}";


        if (!File.Exists(myDirectory + fileName + ".txt"))
        {
            File.WriteAllText(file, fileText );
            Console.WriteLine("Your file created succesfully!");
        }s
    }

    public static FileContent CreateText()
    {
        FileContent fileContent = new FileContent();
        Console.WriteLine("Name:");
        fileContent.name = Console.ReadLine();

        Console.WriteLine("Surname:");
        fileContent.surname = Console.ReadLine();

        Console.WriteLine("Age:");
        fileContent.age = Console.ReadLine();

        Console.WriteLine("University Name:");
        fileContent.universityName = Console.ReadLine();

        return fileContent;
    }


    public class FileContent
    {
        public string name;
        public string surname;
        public string age;
        public string universityName;
    } 
}