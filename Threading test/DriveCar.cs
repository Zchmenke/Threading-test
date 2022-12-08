using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading_test
{
    public class DriveCar
    {
        RedCar red = new RedCar("The Red car");
        BlueCar blue = new BlueCar("The Blue car");
        int RedInt = 0;
        int BlueInt = 0;
        public void RedDrivve()
        {
            CheckWin();
            Console.WriteLine($"{red} has driven {RedInt} laps");
            Thread.Sleep(1000);
            RedInt++;
            RedDrivve();
        }
        public void BlueDrive()
        {
            CheckWin();
            Console.WriteLine($"{blue} has driven {BlueInt} laps");
            Thread.Sleep(1300);
            BlueInt++;
            BlueDrive();
        }
        public void CheckWin()
        {
            if (RedInt == 5)
            {
                Console.WriteLine($"{red} won the race");
                System.Environment.Exit(0);
            }
            else if (BlueInt == 5)
            {
                Console.WriteLine($"{blue} won the race");
                System.Environment.Exit(0);
                return;
            }
        }
    }
}
