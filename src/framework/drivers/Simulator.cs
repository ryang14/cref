using System;

namespace Drivers
{
    class SimDrive : BaseClasses.Drive
    {
        override protected void _SetThrottle(int percent) => Console.WriteLine("Throttle");


        public SimDrive()
        {
            Console.WriteLine("Simulated drive");
        }
    }
}