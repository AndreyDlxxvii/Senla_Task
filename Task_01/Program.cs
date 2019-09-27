using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая будет сообщать, является ли целое число, введенное пользователем, чётным или нечётным, простым или составным.  
            //Если пользователь введёт не целое число, то сообщать ему об ошибке 
            {
                Console.WriteLine("Введите число для проверки");

                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    int sqrt = Convert.ToInt32(Math.Sqrt(number));
                    int temp = 0;
                    if (number == 2)
                    {
                        temp = 1;
                    }
                    else
                    {
                        for (int i = 2; i <= sqrt; i++)
                        {
                            if (number % i == 0)
                            {
                                temp = 0;
                                break;
                            }
                            else
                            {
                                temp = 1;
                            }

                        }
                    }
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Число четное");
                    }
                    else Console.WriteLine("Число не четное");

                    if (temp == 1)
                    {
                        Console.WriteLine("Число простое");
                    }
                    else Console.WriteLine("Число составное");
                }
                catch
                {
                    Console.WriteLine("Ошибка, не соответствует параметрам задачи");
                }

                Console.ReadKey();

            }
        }
    }
}
