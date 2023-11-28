using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        CpuInfo();
    }
    public static void CpuInfo()
    {
        PerformanceCounter cpu;
         cpu = new PerformanceCounter("Processor", "% Processor Time", "_Total");
         cpu.NextValue();
        System.Threading.Thread.Sleep(1000);
        Console.WriteLine($"Current CPU usage = {Math.Round(cpu.NextValue())}%");
    }
}