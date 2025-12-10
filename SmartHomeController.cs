using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> _devices = new List<ISwitchable>();
        private List<IEnergyConsumer> _energyDevices = new List<IEnergyConsumer>();
        public void AddDevice (ISwitchable device)
        {
            _devices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            _energyDevices.Add(device);
        }
        public void TurnAllOn()
        {
            foreach(var device in _devices)
            {
                device.TurnOn();
            }
        }
        public void TurnAllOff()
        {
            foreach (var device in _devices)
            {
                device.TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");

            double total = 0;

            foreach (var device in _energyDevices)
            {
                double usage = device.GetEnergyUsage(hours);
                Console.WriteLine($"{device.DeviceName}: {usage:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
                total += usage;
            }

            Console.WriteLine($"Загальне споживання: {total:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {total * 4:F2} грн\n");
        }
    }
}
