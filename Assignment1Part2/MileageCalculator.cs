using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    class MileageCalculator
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            
            car.Start();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
