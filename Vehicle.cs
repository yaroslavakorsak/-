using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Vehicle
    {
       protected string brand {  get; set; }
       protected int year { get; set; }
       protected double mileage { get; set; }
       protected double maxSpeed { get; set; }
       public Vehicle(string brand, int year, double mileage, double maxSpeed)
        {
            this.brand = brand;
            this.year = year;
            this.mileage = mileage;
            this.maxSpeed = maxSpeed;
        }
        public virtual string GetInfo()
        {
            return $"{brand} ({year}), Mileage: {mileage} km";
        }
        public virtual double GetMaxSpeed()
        {
            return maxSpeed;
        }
        public virtual void Move(double distance)
        {
            mileage += distance;
            Console.WriteLine($"{brand} drove {distance} km.");
        }
    }
}
