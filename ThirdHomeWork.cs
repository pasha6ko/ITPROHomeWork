using System.Globalization;

namespace ITPROHomeWork
{
    internal class ThirdHomeWork
    {
        static public void RunAll()
        {
            First();
            Second();
            Third();
            Forth();
            Fifth();
            Sixth();
            HomeFirst();
            HomeSecond();
        }
        static public void RunHomeWork()
        {
            HomeFirst();
            HomeSecond();
        }
        static public void First()
        {
            int[] array = { 1, -5, 4, -5, 45, 3, -76, 32, -46, 34, 53 };
            int count = 0;
            foreach (int i in array)
            {
                if (i >= 0) count++;
            }
            Console.WriteLine($"\nКоличество положительных: {count}");
        }
        static public void Second()
        {
            Console.WriteLine("Введите строку");
            Console.WriteLine($"Количество слов в строке {Console.ReadLine().Trim().Split().Length}");

        }
        static public void Third()
        {
            Random rnd = new Random();
            int[] numbers = new int[rnd.Next(2, 7)];
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 200);
                Console.WriteLine(numbers[i]);
                if (max < numbers[i]) max = numbers[i];
                if (min > numbers[i]) min = numbers[i];
            }
            Console.WriteLine($"Максимальное число {max}");
            Console.WriteLine($"Минимальное число {min}");
            Console.WriteLine($"Разность {max - min}");
        }
        static public void Forth()
        {
            Random random = new();

            int[,] numbers = new int[3, 3];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(-5, 5);
                    Console.Write($"{numbers[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"{numbers[i, j]} + {numbers[j, i]} = {numbers[i, j] + numbers[j, i]}");
                    Console.WriteLine($"{numbers[i, j]} * {numbers[j, i]} = {numbers[i, j] * numbers[j, i]}");
                }
                Console.WriteLine();
            }
        }
        static public void Fifth()
        {
            string[] size = Console.ReadLine().Split("x");
            int[,] array = new int[Convert.ToInt32(size[0]), Convert.ToInt32(size[0])];
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{array[i, j]} ");
                    sum += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine(sum);

        }
        static public void Sixth()
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split(':');
                capitals.Add(input[0], input[1]);
            }
            foreach (string capital in capitals.Keys)
            {
                Console.WriteLine($"Страна: {capital} Столица: {capitals[capital]}");
            }
        }
        static public void HomeFirst()
        {
            Dictionary<int, Dictionary<string, int>> grade = new Dictionary<int, Dictionary<string, int>>();
            for (int i = 1; i <= 5; i++)
            {
                Dictionary<string, int> student = new Dictionary<string, int>()
                {
                    { "Информатика",-1},
                    { "Разработка игр",-1},
                    { "Основы алгоритмизации",-1}
                };
                Console.WriteLine($"Ученик №{i}");
                foreach (string subject in student.Keys)
                {
                    int mark;
                    do Console.Write($"Введите оценку за предмет \"{subject}\" : ");
                    while (!(int.TryParse(Console.ReadLine().Trim(), out mark) && mark > 0 && mark <= 5));

                    student[subject] = mark;
                }
                grade.Add(i, student);

            }
            ShowTable(grade);
            while (true)
            {
                while (true)
                {
                    Console.Write("Продолжить ? y/n ");
                    string userAnswer = Console.ReadLine().Trim();
                    if(userAnswer == "y")
                    {
                        break;
                    }
                    else if(userAnswer == "n")
                    {
                        return;
                    }
                }
                int inputStudent;
                do Console.WriteLine("Введите номер ученика: ");
                while (!(int.TryParse(Console.ReadLine().Trim(), out inputStudent) && grade.ContainsKey(inputStudent)));
                string inputSubject;
                while (true)
                {
                    Console.Write("Впишите название предмета: ");
                    inputSubject = Console.ReadLine().Trim();
                    if (grade[inputStudent].ContainsKey(inputSubject))
                    {
                        break;
                    }
                }
                int mark;
                do Console.Write($"Введите оценку за предмет \"{inputSubject}\" : ");
                while (!(int.TryParse(Console.ReadLine().Trim(), out mark) && mark > 0 && mark <= 5));
                grade[inputStudent][inputSubject] = mark;
                ShowTable(grade);
            }
        }
        static void ShowTable(Dictionary<int, Dictionary<string, int>> grade)
        {
            Console.WriteLine("Номер ученика|Информатика|Разработка игр|Основы алгоритмизации|");
            
            foreach (int id in grade.Keys)
            {
                Console.Write($"| {id} |");
                foreach (string subject in grade[1].Keys)
                {
                    Console.Write($"| {grade[id][subject]} |");
                }
                Console.WriteLine();
            }
        }
        static public void HomeSecond()
        {
            Random rand = new Random();
            int[] numbers = new int[15];
            Console.WriteLine("Блок 1");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-1, 10);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine("\nБлок 2");
            for (int i = numbers.Length - 1; i >= 0; i--)
                Console.Write($"{numbers[i]} ");
            Console.WriteLine("\nБлок 3");
            for (int i = 0; i < numbers.Length; i += 2)
                Console.Write($"{numbers[i]} ");
            Console.WriteLine("\nБлок 4");
            for (int i = 0; i < numbers.Length && numbers[i] != -1; i++)
                Console.Write($"{numbers[i]} ");
        }

    }
}
