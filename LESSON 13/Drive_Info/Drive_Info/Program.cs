using System;
using System.IO;

class Program
{
    static void Main()
    {
        DriveInformation.driveInformation();
        DriveInformation.driveSize();
    }
    public static class DriveInformation
    {
        static DriveInfo[] driveInfo = DriveInfo.GetDrives();
        public static void driveInformation()
        {
            Console.WriteLine($"You have {driveInfo.Length} drives: ");
            foreach (var drive in driveInfo)
            {
                Console.WriteLine(drive);
            }
        }
        public static void driveSize()
        {
            Console.WriteLine("");
            foreach (var drive in driveInfo)
            {
                Console.WriteLine($"Drive Name: {drive.Name} \n" +
                    $"Drive total size: {drive.TotalSize / (1024 * 1024)} MB\n" +
                    $"Drive available size: {drive.AvailableFreeSpace / (1024 * 1024)} MB\n" +
                    $"Drive used size: {(drive.TotalSize - drive.AvailableFreeSpace) / (1024 * 1024)} MB");
                Console.WriteLine("");

            }
        }
    }
}