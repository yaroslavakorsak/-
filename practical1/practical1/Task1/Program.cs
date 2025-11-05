using System;

namespace Task1
{
    public class Program
    {
        // Метод перевірки парності числа
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Метод, який повертає повідомлення залежно від парності
        public static string GetMessage(int number)
        {
            return IsEven(number) ? "Двері відкриваються!" : "Двері зачинені...";
        }

        // Головний метод для запуску програми
        public static void Main(string[] args)
        {
            Console.Write("Введіть число: ");
            int n;

            // Перевірка на правильність вводу
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Некоректне число. Спробуйте ще раз: ");
            }

            // Вивід повідомлення
            Console.WriteLine(GetMessage(n));
        }
    }
}
