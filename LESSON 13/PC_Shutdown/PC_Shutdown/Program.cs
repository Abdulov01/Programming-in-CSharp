using System.Threading;
using System;
using System.Timers;
using System.Diagnostics;

class Program
{
    static System.Timers.Timer timer;

    static void Main()
    {
        Console.WriteLine("Enter the time for shutdown PC: (minutes)");
        TimerSet(int.Parse(Console.ReadLine()));
    }
    public static void TimerSet(int minute)
    {
        timer = new System.Timers.Timer();
        timer.Interval = minute * 60000;
        timer.Elapsed += Shutdown;
        timer.Start();
        Console.ReadKey();
    }
    public static void Shutdown(object sender, EventArgs e)
    {
        Process.Start("shutdown", "/s /t 0");
        timer.Stop();
    }
}