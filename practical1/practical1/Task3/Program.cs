using System;

namespace Task3
{
    public class Program
    {
        // Метод для класифікації віку
        public static string ClassifyAge(int age)
        {
            if (age < 0 || age > 120)
                return "Нереальний вік";
            else if (age < 12)
                return "Ви дитина";
            else if (age >= 12 && age <= 17)
                return "Підліток";
            else if (age >= 18 && age <= 59)
                return "Дорослий";
            else // 60+
                return "Пенсіонер";
        }

        // Головний метод
        public static void Main(string[] args)
        {
            Console.Write("Введіть ваш вік: ");
            int age;

            // Перевірка на коректність вводу
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Некоректне число. Спробуйте ще раз: ");
            }

            // Вивід категорії
            Console.WriteLine(ClassifyAge(age));
        }
    }
}