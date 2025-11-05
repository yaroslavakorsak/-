using System;

namespace Task5
{
    public class Program
    {
        // Метод для обчислення середнього балу однієї групи
        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }

        // Метод для знаходження мінімальної оцінки однієї групи
        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;
            }
            return min;
        }

        // Метод для знаходження максимальної оцінки однієї групи
        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max)
                    max = mark;
            }
            return max;
        }

        // Метод для виводу статистики для кожної групи
        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] group = groups[i];
                Console.WriteLine($"Група {i + 1}: Середній = {GetAverage(group):F2}, Мінімальний = {GetMin(group)}, Максимальний = {GetMax(group)}");
            }
        }

        // Головний метод
        public static void Main(string[] args)
        {
            // Приклад: створюємо випадкові оцінки для 3 груп
            Random rand = new Random();
            int[][] groups = new int[3][];
            for (int i = 0; i < groups.Length; i++)
            {
                int groupSize = rand.Next(10, 31); // від 10 до 30 студентів
                groups[i] = new int[groupSize];
                for (int j = 0; j < groupSize; j++)
                {
                    groups[i][j] = rand.Next(50, 101); // оцінки від 50 до 100
                }
            }

            // Вивід статистики
            PrintGroupStatistics(groups);
        }
    }
}