using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Motored_Vehicle.Entity;

namespace Motored_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string model = "M5";
            string make = "BMW";
            int productionYear = 2012;
            Car car = new Car(model, make, productionYear);
            car.fuelAmount = 30;
            car.fuelUsedPerKm = 0.3;
            car.go(100);
            Console.ReadKey();
        }
    }
}
