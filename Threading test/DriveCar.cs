using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading_test
{
     public class DriveCar
    {
        RedCar red = new RedCar("Red");
        BlueCar blue = new BlueCar("Blue");
       
        public void RedDrivve()
        {
            int redint = 0;
            Console.WriteLine($"{red} is accelerating to {redint}");
            Thread.Sleep(1000);
            redint++;
            RedDrivve();
        }
        public void BlueDrive()
        {
            int blueint = 0;
            Console.WriteLine($"{blue} accelerating to {blueint}");
            Thread.Sleep(1500);
            blueint++; 
            BlueDrive();
        }
    }
}
