using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая в последовательности от 0 до N, находит все числа-палиндромы(зеркальное значение равно оригинальному). 
            //Длина последовательности N вводится вручную и не должна превышать 100. 

            Console.WriteLine("Введите последовательность чисел разделяя пробелом");
            string temp = Console.ReadLine();
            string[] numbers = temp.Split(' ');

            foreach (string i in numbers)
            {
                char[] num = i.ToCharArray();
                Array.Reverse(num);
                string revnum = new string(num);
                if (revnum == i && Convert.ToInt32(revnum) > 10)
                {
                    Console.WriteLine("Палиндром " + i);
                }
                else { Console.WriteLine("Не палиндром: " + revnum); }
            }

            Console.ReadKey();
        }
    }
}
