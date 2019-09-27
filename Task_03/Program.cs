using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        // Создать программу, которая будет:
        //•	подсчитывать количество слов в предложении
        //•	выводить их в отсортированном виде 
        //•	делать первую букву каждого слова заглавной.
        //Предложение вводится вручную. (Разделитель пробел (“ ”))

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string words = Console.ReadLine();
            words = words.Trim(' ');
            string[] temp = words.Split(' ');
            int numOfWord = temp.Length;
            Console.WriteLine("Количество слов в предложении " + numOfWord);
            Console.WriteLine("Слова на заглавную букву ");
            foreach (var i in temp)
            {
                var j = i.Substring(0, 1).ToUpper() + i.Remove(0, 1);

                Console.WriteLine(j);
            }
            var sortWords = from i in temp
                            orderby i
                            select i;
            Console.WriteLine("Отсортированные слова");
            foreach (var q in sortWords)
            {

                Console.WriteLine(q);
            }
            Console.ReadKey();
        }
    }
}
