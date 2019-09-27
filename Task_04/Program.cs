using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая подсчитывает сколько раз употребляется слово в тексте(без учета регистра). 
            //Текст и слово вводится вручную.

            int j = 0;
            Console.Clear();
            Console.WriteLine("Введите предложение");
            string temp = Console.ReadLine();
            string[] text = temp.Split(' ');
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (string.Equals(word, text[i], StringComparison.OrdinalIgnoreCase))
                {
                    j++;
                }
            }
            Console.WriteLine("слово употребляется " + j + " раз");
            Console.ReadKey();
        }
    }
}
