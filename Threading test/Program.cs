using System;
using System.Threading;
using System.Timers;

namespace Threading_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }
        static void StartProgram()
        {        
            DriveCar drive = new DriveCar();         
            Thread drivethread = new Thread(new ThreadStart(drive.BlueDrive));
            drivethread.Start();
            drive.RedDrivve();

        }
    }
}
