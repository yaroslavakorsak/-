using System;

namespace Task2
{
    public class Program
    {
        // Метод для генерації масиву випадкових чисел
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1); // max +1, потому что верхняя граница не включается
            }

            return array;
        }

        // Метод для підрахунку суми
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        // Метод для підрахунку середнього
        public static double GetAverage(int[] numbers)
        {
            return (double)GetSum(numbers) / numbers.Length;
        }

        // Метод для знаходження мінімуму
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        // Метод для знаходження максимуму
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        // Головний метод
        public static void Main(string[] args)
        {
            int[] array = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Масив чисел:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Сума: {GetSum(array)}");
            Console.WriteLine($"Середнє: {GetAverage(array):F2}");
            Console.WriteLine($"Мінімум: {GetMin(array)}");
            Console.WriteLine($"Максимум: {GetMax(array)}");
        }
    }
}