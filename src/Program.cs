using System;
using System.Threading;
using System.Threading.Tasks;

namespace robot
{
    class Program
    {

        static void Main(string[] args)
        {
            var robot = new Robots.Simulator();

            robot.drive.throttle = 10;
            robot.drive.steering = 10;

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
