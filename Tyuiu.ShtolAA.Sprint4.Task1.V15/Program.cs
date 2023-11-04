using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolAA.Sprint4.Task1.V15.Lib;


namespace Tyuiu.ShtolAA.Sprint4.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Штоль А.А. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Штоль Александра Алексеевна | ИИПБ-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 9 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива.С клавиатуры: 6,7,6,7,5,7,6,7,9,4,6,5,8,5      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];


            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите значение"+ i + "элемента массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Получившийся массив:");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Произведение чётных элементов массива = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
