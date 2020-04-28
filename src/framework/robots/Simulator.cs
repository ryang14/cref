using System;
using BaseClasses;
using Drivers;

namespace Robots
{
    class Simulator : Robot
    {
        public Drive drive;
        public Simulator() {
            drive = new SimDrive();
            Console.WriteLine("Simulated robot");
        }
    }
}