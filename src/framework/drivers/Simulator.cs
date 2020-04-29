using System;

namespace Drivers
{
    class SimDrive : BaseClasses.Drive
    {
        override protected void _SetThrottle(int percent) => Console.WriteLine("Throttle");
        override protected void _SetSteering(int percent) => Console.WriteLine("Steering");


        public SimDrive()
        {
            Console.WriteLine("Simulated drive");
        }
    }
}