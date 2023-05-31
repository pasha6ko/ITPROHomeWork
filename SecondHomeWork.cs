using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ITPROHomeWork
{
    internal class SecondHomeWork
    {
        static public void RunAll()
        {
            First();
            Second();
            Third();
            Forth();
            Fifth();
            Sixth();
            Seventh();
        }
        static public void First()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num.ToString().Length; i++)
            {
                if (((num % Math.Pow(10, i)) - (num % Math.Pow(10, i - 1))) / Math.Pow(10, i - 1) % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество чётных {count}");
        }
        static public void Second()
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            Console.WriteLine($"Факториал числа {n} - {answer}");
        }

        static public void Third()
        {
            Console.WriteLine("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            double month = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < month; i++)
            {
                deposit *= 1.07;
            }
            Console.WriteLine($"Сумма составит: {Math.Round(deposit, 2)}");
        }
        static public void Forth()
        {
            for (int i = 1; i < 101; i++) Console.Write(i % 2 != 0 ? $"{i} " : null);
            Console.WriteLine("Введите число");
            int value = Convert.ToInt32(Console.ReadLine());
            int answer = 0;
            int limit = 0;
            switch (value)
            {
                case 1:
                    limit = 100;
                    break;
                case 2:
                    limit = 20;
                    break;
                case 3:
                    limit = 10;
                    break;
                default:
                    Console.WriteLine(100);
                    return;
            }
            for (int i = 0; i <= limit; i += 5)
            {
                Console.Write($"{i}+");
                answer += i;
            }
            Console.WriteLine();
            Console.WriteLine(answer);
        }
        static void Fifth()
        {
            Console.WriteLine("все нечетные числа из диапазона от 1 до 100");
            for (int i = 1; i <= 100; i += 2) Console.WriteLine(i);
        }
        static void Sixth()
        {
            Console.WriteLine("первые 10 чисел Фибоначчи.");
            int a = 0;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < 8; i++)
            {
                int sum = a + b;
                Console.WriteLine(sum);
                a = b;
                b = sum;
            }
        }
        static void Seventh()
        {
            Console.WriteLine("Определить в какой день суммарный пробег за все дни превысит 100 км.");
            float lengthPerDay = 10f;
            float lenght = 0f;
            int day = 0;
            while (lenght <= 100.0)
            {
                lenght += lengthPerDay;
                lengthPerDay *= 1.1f;
                day++;
            }
            Console.WriteLine($"Нужно дней что бы пробежать 100 км: {day}");
        }
    }
}
