namespace SmartHomeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var controller = new SmartHomeController();

            var lamp = new Light { Name = "Лампа у вітальні" };
            var ac = new AirConditioner { Name = "Кондиціонер у спальні" };
            var coffee = new CoffeeMachine { Name = "Кавомашина на кухні" };
            var sensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(lamp);
            controller.AddDevice(ac);
            controller.AddDevice(coffee);
            controller.AddDevice(sensor);

            controller.AddEnergyDevice(lamp);
            controller.AddEnergyDevice(ac);
            controller.AddEnergyDevice(coffee);

            controller.TurnAllOn();

            lamp.PrintStatus();
            ac.PrintStatus();
            coffee.PrintStatus();
            sensor.PrintStatus();

            controller.ShowEnergyReport(5);

            controller.TurnAllOff();
        }
    }
}
