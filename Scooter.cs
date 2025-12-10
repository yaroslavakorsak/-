using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Scooter : Vehicle
    {
      private int batteryCapacity {  get; set; }
      private double batteryLevel { get; set; }
      public Scooter(string brand, int year, double mileage, int batteryCapacity) : base(brand,year, mileage, 45.0)
        {
            this.batteryCapacity = batteryCapacity;
            this.batteryLevel = 100;
        }
        public override string GetInfo()
        {
            return $"Scooter: {brand} ({year}), Battery: {batteryLevel}% of {batteryCapacity}Ah";
        }
        public override void Move(double distance)
        {
            base.Move(distance);
            batteryLevel -= distance * 0.5;
            if(distance < 0)
            {
                batteryLevel = 0;
            }
        }
        public void Charge()
        {
            batteryLevel = 100;
            Console.WriteLine($"{brand} has been fully charged.");
        }
    }
}
