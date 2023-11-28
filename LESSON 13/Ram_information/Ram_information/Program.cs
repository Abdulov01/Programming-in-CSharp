using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Management;


class Program
{  
    static void Main()
    {
       GetRamInfo();
    }

    public static void GetRamInfo()
    {
        var searcher = new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM win32_OperatingSystem"));
        var ramInfo = searcher.Get();

        foreach (var ram in ramInfo)
        {
            var totalMemory = ram["TotalVisibleMemorySize"];
            double memory = Convert.ToDouble(totalMemory) / 1024;
            Console.WriteLine($"Total RAM = {memory} MB");

            var freeRam = ram["FreePhysicalMemory"];
            double usingRam = (memory - Convert.ToDouble(freeRam)/1024);
            Console.WriteLine($"Current RAM usage = {usingRam} MB");

            double usingRamInPercentage = (usingRam * 100) / memory; 
            Console.WriteLine($"Current RAM usage in percentage = {Math.Round(usingRamInPercentage)}%");
        }
    }
}



