using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class MotionSensor : Device
    {
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} активовано.");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} деактивовано.");
        }
 
    }
}
