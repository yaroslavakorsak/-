using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class Light : Device, IEnergyConsumer
    {
        public int PowerConsumption => 60;
        public string DeviceName => Name;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} засвітилася.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} вимкнена.");
        }

        public double GetEnergyUsage(int hours)
        {
            if (IsOn)
            {
                return PowerConsumption * hours / 1000.0;
            }
            else
            {
                return 0;
            }
        }
    }
}
