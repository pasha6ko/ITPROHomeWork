using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ITPROHomeWork
{
    internal class FirstHomeWork
    {
        static public void RunAll()
        {
            //First();
            //Second();
            Third();
            //Forth();
        }
        static public void First()
        {
            Console.Write("Введите температуру в градусах Цельсия: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(
                "Темература в:\n" +
                $"Цельсий = {celsius.ToString("0.0")}\n" +
                $"Кельвин = {kelvin.ToString("0.0")}\n" +
                $"Кельвин = {fahrenheit.ToString("0.0")}\n");
        }
        static public void Second()
        {
            Console.Write(
                "Операция сложение: + \n" +
                "Операция вычитания: - \n" +
                "Операция умножения: * \n" +
                "Операция деления: / \n" +
                "Операция вычисления остатка от деления: % \n" +
                "Выберите операцию: ");
            char sym = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите первый параметр");
            double a  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второй параметр");
            double b = Convert.ToDouble(Console.ReadLine());
            double answer = 0; 
            switch(sym)
            {
                case '+':
                    answer = a + b;
                    break;
                case '-':
                    answer = a - b;
                    break;
                case '*':
                    answer = a * b;
                    break;
                case '/':
                    answer = a / b;
                    break;
                case '%':
                    answer = a % b;
                    break;
                default:
                    Console.WriteLine("Введённая операция отсутвует");
                    return;
            }
            Console.WriteLine($"Ответ: {answer}");
        }
        static void Third()
        {
            Console.Write("Введите первое значение: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе значение: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сколько будет если {a} умножить на {b} ?");
            int answer = Convert.ToInt32(Console.ReadLine());
            if(answer==a*b)
            {
                Console.WriteLine("Вы дали правельный ответ");
            }
            else
            {
                Console.WriteLine($"Вы дали не правильный ответ. Правельный ответ: {a * b}");
            }
        }
        static public void Forth()
        {
            Console.Write("Введите ваш возраст: ");
            string age = Console.ReadLine();
            char[] ageSym = age.ToCharArray();
            string postfix = "";
            if (ageSym.Last()=='1')
            {
                postfix = "год";
            }
            else if (Convert.ToInt32(ageSym[^1].ToString()) > 1 && Convert.ToInt32(ageSym[^1].ToString()) <= 4 && Convert.ToInt32(ageSym[0].ToString()) != 1)
            {
                
                postfix = "года";
            }
            else
            {
                postfix = "лет";
            }
            Console.WriteLine($"Мне {age.ToString()} {postfix}");
        }
    }
    
}
