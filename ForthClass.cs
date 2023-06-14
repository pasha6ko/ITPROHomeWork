using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITPROHomeWork
{
    internal class ForthClass
    {
        static double GetDistace(double x1, double y1, double x2, double y2)
        {
            double xDistance = Math.Abs(x1 - x2);
            double yDistance = Math.Abs(y1 - y2);

            double distance = Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2));

            return distance;
        }
        static void MinMax(List<int> numbers, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;
            foreach (int number in numbers)
            {
                if(min>number) min = number;
                if(max<number) max = number;
            }
        }
        public static void RunAll()
        {
            Second();
        }
        public static void First()
        {
            double x1 = 1;
            double x2 = 1;
            double y1 = 2;
            double y2 = 2;
            Console.WriteLine(GetDistace(x1, y1, x2, y2));
            //while (!(Double.TryParse(Console.ReadLine(); out x1))) Console.
        }
        public static void Second() 
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Впишите числа что бы добавить в список. Что бы прервать впишите 0");
            while(true) 
            {
                int.TryParse(Console.ReadLine(), out int inputNum);
                if (inputNum == 0) break;
                numbers.Add(inputNum);
            }
            MinMax(numbers, out int min, out int max);
            Console.WriteLine($"{min} - Минимальное число");
            Console.WriteLine($"{max} - Максимальное число");
        }
    }
}
