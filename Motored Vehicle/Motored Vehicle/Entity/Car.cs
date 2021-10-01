using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored_Vehicle.Entity
{
    public class Car:MotoredVehicle
    {
   
        Boolean isOn;
        
        public Car(string model, string make, int productionYear) :base( model, make, productionYear)
        {

        }
        public Boolean turnOn() {
            isOn = true;
            return isOn;
        }
        public Boolean turnOff()
        {
            isOn = false;
            return isOn;
        }
        public void go(int km)
        {
            turnOn();
            if (isOn==true)
            {
                if (fuelAmount>=(fuelUsedPerKm*km)) {
                    Console.WriteLine(km+"km məsafə qət edildi");
                }
                else {
                    Console.WriteLine("Kifayet qədər yanacaq yoxdur");
                }


            }
            else
            {
                Console.WriteLine("Turn on your car");
            }
        }

        public override void getDetailInfo()
        {
            base.getDetailInfo();
            Console.WriteLine($"{this.fuelAmount}");
        }
    }
}
