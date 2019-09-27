using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая будет вычислять и выводить на экран НОК(наименьшее общее кратное) и НОД(наибольший общий делитель) двух целых чисел, введенных пользователем.
            //Если пользователь некорректно введёт хотя бы одно из чисел, то сообщать об ошибке.
            Console.WriteLine("Введите два числа");
            try
            {
                Console.Write("Первое число:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Второе число:");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int temp = Math.Min(number1, number2);

                for (; temp > 0; temp--)
                {
                    if (number1 % temp == 0 && number2 % temp == 0)
                    {
                        Console.WriteLine("Наибольший общий делитель: " + temp);
                        int nod = (number1 * number2) / temp;
                        Console.WriteLine("Наибольшее общее кратное: " + nod);
                        break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Не верно введены данные!");
            }
            Console.ReadKey();
        }
    }
}
