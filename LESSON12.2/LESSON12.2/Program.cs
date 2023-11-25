

//TASK - Write a program to calculate all files and directories count in a given directory.
//               (including files and folder in any subdirectory)
class Program
{
    static void Main(string[] args)
    {
          string myDirectory = @"C:\Users\Abdulov\Downloads";
        string[] paths = Directory.GetFiles(myDirectory ,"*", SearchOption.AllDirectories);

        int sizeOfFiles = paths.Length;
        Console.WriteLine($"The size of files for the given directory is: {sizeOfFiles}");
        Console.WriteLine();
        Console.WriteLine("All of them:");

        foreach (string path in paths)
        {
            Console.WriteLine(path);
        }
    }
}