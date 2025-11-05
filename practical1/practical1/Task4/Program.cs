using System;

namespace Task4
{
    public class Program
    {
        // Перевірка, чи сторони утворюють трикутник
        public static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   (a + b > c) && (a + c > b) && (b + c > a);
        }

        // Обчислення периметра
        public static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        // Обчислення площі за формулою Герона
        public static double GetArea(double a, double b, double c)
        {
            double s = GetPerimeter(a, b, c) / 2; // півпериметр
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        // Визначення типу трикутника
        public static string GetTriangleType(double a, double b, double c)
        {
            // Рівносторонній
            if (a == b && b == c)
                return "рівносторонній";

            // Прямокутний (теорема Піфагора)
            if (Math.Abs(a * a + b * b - c * c) < 1e-6 ||
                Math.Abs(a * a + c * c - b * b) < 1e-6 ||
                Math.Abs(b * b + c * c - a * a) < 1e-6)
                return "прямокутний";

            // Рівнобедрений
            if (a == b || b == c || a == c)
                return "рівнобедрений";

            // Довільний
            return "довільний";
        }

        // Головний метод
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть три сторони трикутника:");

            double a, b, c;

            while (true)
            {
                Console.Write("Сторона a: ");
                if (!double.TryParse(Console.ReadLine(), out a)) continue;

                Console.Write("Сторона b: ");
                if (!double.TryParse(Console.ReadLine(), out b)) continue;

                Console.Write("Сторона c: ");
                if (!double.TryParse(Console.ReadLine(), out c)) continue;

                break;
            }

            if (!IsValidTriangle(a, b, c))
            {
                Console.WriteLine("Трикутник з такими сторонами не існує.");
            }
            else
            {
                Console.WriteLine($"Периметр: {GetPerimeter(a, b, c)}");
                Console.WriteLine($"Площа: {GetArea(a, b, c):F2}");
                Console.WriteLine($"Тип трикутника: {GetTriangleType(a, b, c)}");
            }
        }
    }
}