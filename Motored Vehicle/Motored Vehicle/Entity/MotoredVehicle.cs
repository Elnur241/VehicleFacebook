using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motored_Vehicle.Entity
{
   public  class MotoredVehicle
    {
        string model;
        string make;
        int productionYear;
        string color;
        double motorsize;
      public  int fuelTankSize;
       public int fuelAmount;
       public double fuelUsedPerKm;
        string transmission;
        string horsePower;
        string passengerCount;
        public MotoredVehicle()
        {

        }
        public MotoredVehicle(string model, string make, int productionYear)
        {
            this.model = model;
            this.make = make;
            this.productionYear = productionYear;
        }
        public string getInfo()
        {
            return $"{model},{make},{productionYear},{color}";
        }
        public virtual void getDetailInfo()
        {
         Console.WriteLine($"{getInfo()} {motorsize} , {fuelTankSize}" +
             $",{fuelUsedPerKm} ,{transmission} , {horsePower},{passengerCount} ");
        }
    }
}
