namespace ITPROHomeWork
{
    internal class DopFirst
    {
        static int[,] t = new int[3, 4]{
                        {-8,-14,-19,-18},
                        {25,28,26,20},
                        {11,-18,20,25}
                        };
        static public void RunAll()
        {
            First();
            Second();
            Third();
            Forth();
            Fifth();
        }
        static public void First()
        {
            Console.WriteLine($"1-е Задание: {t[1, 3]} и {t[2, 0]}");
        }
        static public void Second()
        {
            Console.Write("2-е Задание: ");
            int rows = t.GetUpperBound(0) + 1;
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{t[i, 1]} ");
            }
            Console.WriteLine();
        }
        static public void Third()
        {
            Console.WriteLine($"3-е Задание:");
            int rows = t.GetUpperBound(0) + 1;
            int columns = t.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int b = 0; b < columns; b++)
                {
                    Console.Write($"{t[i, b]} ");
                }
                Console.WriteLine();
            }
        }
        static public void Forth()
        {
            int rows = t.GetUpperBound(1) + 1;
            int[] stationData = new int[4];
            for (int i = 0; i < rows; i++)
            {
                stationData[i] = t[2, i];
            }
            Console.WriteLine($"4-е Задание: {stationData.Average()}");
        }
        static public void Fifth()
        {
            Console.WriteLine("5-е Задание: ");
            int rows = t.GetUpperBound(0) + 1;
            int columns = t.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"станция {i + 1}:");
                for (int b = 0; b < columns; b++)
                {
                    if (t[i,b]>=24 && t[i,b]<=26) Console.Write($" день:{b+1}");
                }
                Console.WriteLine();
                
            }
        }
    }

}
