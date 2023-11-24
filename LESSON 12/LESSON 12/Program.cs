

using System.Collections;
using System.Diagnostics;

/*
   TASK - Organize contents of any directory and it's files in the following style \

    All image files should be in Images folder (png, jpg and etc.)
    All video files should be in Videos folder (.mp4 and etc.)
    All pdf and office files should be in Documents folder
    All other files should in Other Files folder
    Remove any empty directory
*/

class OrganizeFiles
{
    const string myPath = @"C:\Users\Abdulov\Downloads";
    static string video = (myPath + @"\Video");
    static string txt = (myPath + @"\txt");
    static string image = (myPath + @"\Photo");
    static string mp3 = (myPath + @"\Music");
    static string reading = (myPath + @"\Pdf");
    static string other = (myPath + @"\Other");

    static void Main(string[] args)
    {
        CreateFiles();
        MoveFiles();
        DeleteFiles();
    }
    public static void MoveFiles() 
    {
        var directory = new DirectoryInfo(myPath);
        var files = directory.GetFiles();

        foreach (var file in files)
        {
            switch (file.Extension)
            {
                case ".mp4":
                    File.Move(file.FullName, video+@"\" + file.Name );
                    break;

                case ".mp3":
                    File.Move(file.FullName, mp3 + @"\" + file.Name);
                    break;
                case ".pdf":
                    File.Move(file.FullName, reading + @"\" + file.Name);
                    break;
                case ".txt":
                    File.Move(file.FullName, txt + @"\" + file.Name);
                    break;
                case ".jpg":
                    File.Move(file.FullName, image + @"\" + file.Name);
                    break;
                case ".jfif":
                    File.Move(file.FullName, image + @"\" + file.Name);
                    break;
                default:
                    File.Move(file.FullName, other + @"\"+ file.Name);
                    break;
            }
        }
    }
    public static void CreateFiles()
    {
        
        var videoFile = Path.Combine(video);

        if (!Directory.Exists(videoFile))
        {
            Directory.CreateDirectory(videoFile);
        }

        var txtFiles = Path.Combine(txt);
        if (!Directory.Exists(txtFiles))
        {
            Directory.CreateDirectory(txtFiles);
        }

        var music = Path.Combine(mp3);
        if (!Directory.Exists(music))
        {
            Directory.CreateDirectory(music);
        }

        var photo = Path.Combine(image);
        if (!Directory.Exists(photo))
        {
            Directory.CreateDirectory(photo);
        }

        var pdf = Path.Combine(reading);
        if (!Directory.Exists(pdf))
        {
            Directory.CreateDirectory(pdf);
        }
        var Other = Path.Combine(other);
        if (!Directory.Exists(Other))
        {
            Directory.CreateDirectory(Other);
        }
    }


    static void DeleteFiles()
    {
        string[] files = Directory.GetDirectories(myPath);
        foreach (string file in files) 
        {
            Console.WriteLine(file);
            //FileInfo fileInfo = new FileInfo(file);
            var d = new DirectoryInfo(file);
            if (d.GetFiles().Length == 0)
            {
                d.Delete();
            }
        } 
    }
}
