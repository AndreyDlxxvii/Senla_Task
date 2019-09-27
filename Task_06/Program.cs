using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
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
            // Имеется набор вещей, которые необходимо поместить в рюкзак.
            //Рюкзак обладает заданной грузоподъемностью.Вещи в свою очередь обладают двумя параметрами — весом и стоимостью.
            //Цель задачи заполнить рюкзак не превысив его грузоподъемность и максимизировать суммарную ценность груза.

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
        }
    }
}
