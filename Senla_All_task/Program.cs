using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senla
{
    class BackPackFinal //таблица максимальной загрузки рюкзака при максимальной стоимости
    {
        public string name; //название товара
        public int numInvent; //номер товара
        public int price; //цена товара

        public BackPackFinal(string name, int numInvent, int price)
        {
            this.name = name;
            this.numInvent = numInvent;
            this.price = price;
        }
    }

    class Program
    {
        static int Fx(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            else
            {
                return backPackFinal[i].price;
            }
        }
        public class Inventori
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int cost { get; set; }
        }
        public static BackPackFinal[] backPackFinal;


        static void Main(string[] args)
        {
            int choice;
            bool temp = false;
            while (!temp)
            {
                Console.WriteLine("1 - Задача 1");
                Console.WriteLine("2 - Задача 2");
                Console.WriteLine("3 - Задача 3");
                Console.WriteLine("4 - Задача 4");
                Console.WriteLine("5 - Задача 5");
                Console.WriteLine("6 - Задача 6");
                Console.WriteLine("0 - Выход");

                string input = Console.ReadLine();
                if (Int32.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        case 3:
                            Task3();
                            break;
                        case 4:
                            Task4();
                            break;
                        case 5:
                            Task5();
                            break;
                        case 6:
                            Task6();
                            break;
                        case 0:
                            temp = true;
                            break;
                        default:
                            break;

                    }
                    // Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Не верный ввод");
                }

            }
        }
        private static void Task1()
        //Создать программу, которая будет сообщать, является ли целое число, введенное пользователем, чётным или нечётным, простым или составным.  
        //Если пользователь введёт не целое число, то сообщать ему об ошибке 
        {
            Console.Clear();
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
            Console.Clear();

        }

        private static void Task2()
        //Создать программу, которая будет вычислять и выводить на экран НОК(наименьшее общее кратное) и НОД(наибольший общий делитель) двух целых чисел, введенных пользователем.
        //Если пользователь некорректно введёт хотя бы одно из чисел, то сообщать об ошибке.

        {
            Console.Clear();
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
            Console.Clear();
        }

        private static void Task3()
        // Создать программу, которая будет:
        //•	подсчитывать количество слов в предложении
        //•	выводить их в отсортированном виде 
        //•	делать первую букву каждого слова заглавной.
        //Предложение вводится вручную. (Разделитель пробел (“ ”))

        {
            Console.Clear();
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
            Console.Clear();

        }

        private static void Task4()
        //Создать программу, которая подсчитывает сколько раз употребляется слово в тексте(без учета регистра). 
        //Текст и слово вводится вручную.
        {
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
            Console.Clear();
        }

        private static void Task5()
        //Создать программу, которая в последовательности от 0 до N, находит все числа-палиндромы(зеркальное значение равно оригинальному). 
        //Длина последовательности N вводится вручную и не должна превышать 100. 
        {
            
                Console.Clear();
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
            Console.Clear();
        }
        private static void Task6()
        // Имеется набор вещей, которые необходимо поместить в рюкзак.
        //Рюкзак обладает заданной грузоподъемностью.Вещи в свою очередь обладают двумя параметрами — весом и стоимостью.
        //Цель задачи заполнить рюкзак не превысив его грузоподъемность и максимизировать суммарную ценность груза.
        {
            Console.Clear();
            int backpack = 26;
            backPackFinal = new BackPackFinal[backpack + 1];
            List<Inventori> invent = new List<Inventori>
                {
               new Inventori {name = "ручка", weight = 7, cost = 11},
               new Inventori {name = "тетрадка", weight = 10, cost = 15},
               new Inventori {name = "книжка", weight = 12, cost = 24},
               new Inventori {name = "пенал", weight = 16, cost = 26}
                };
            invent = invent.OrderBy(x => x.cost).ToList();

            List<Inventori> temp = new List<Inventori>();
            backPackFinal[0] = new BackPackFinal("ничто", 0, 0);
            for (int i = 1; i < backpack + 1; i++)// перебираем по емкости рюкзака
            {
                int q = 0, numOfInvent = 0, e = 0;
                string nameTemp = null;



                for (int j = 0; j < invent.Capacity; j++) //перебираем предметы из которых можно создать выборку
                {
                    if ((i - invent[j].weight) >= 0) // проверка подходящего предмета
                    {
                        if (q < invent[j].cost)
                        {
                            int o = Fx(i - invent[j].weight);
                            q = invent[j].cost + o;
                            if (e < q) e = q;
                        }
                        else q = 0;
                        numOfInvent = j + 1;
                        nameTemp = invent[j].name;

                    }


                }
                backPackFinal[i] = new BackPackFinal(nameTemp, numOfInvent, e);// сводим в таблицу все значения максимальной стоимости набора и каким должен быть первый предмет
            }
            //вывод итогого результата
                int l = backpack;
            Console.WriteLine("Итоговые предметы следующие:");
            Console.WriteLine(backPackFinal[backpack].name + " стоимость " + invent[backPackFinal[backpack].numInvent - 1].cost + " вес " + invent[backPackFinal[backpack].numInvent - 1].weight);
            do
            {
                l = l - invent[backPackFinal[backpack].numInvent - 1].weight;
                if (l > 0) Console.WriteLine(backPackFinal[l].name + " стоимость " + invent[backPackFinal[l].numInvent - 1].cost + " вес " + invent[backPackFinal[l].numInvent - 1].weight);
            }
            while (l >= 1);
            Console.ReadKey();
            Console.Clear();
        }
    }

}


    
