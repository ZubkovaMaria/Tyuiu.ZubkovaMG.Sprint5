using System;
using System.IO;
using Tyuiu.ZubkovaMG.Sprint5.Task2.V5.Lib;

namespace Tyuiu.ZubkovaMG.Sprint5.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3] { { 9, 6, 6 },
                                          { 8, 7, 2 },
                                          { 1, 7, 8 } };

            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.GetUpperBound(1) + 1;

            Console.Title = "Спринт #5 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Зубкова Мария Геннадьевна | ИСПб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов. Заменить нечетные   *");
            Console.WriteLine("* элементы на 0. Результат сохранить в файл OutPutFileTask2.csv           *");
            Console.WriteLine("* и вывести на консоль.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл сохранен по пути: ");
            Console.WriteLine(res);

            Console.WriteLine("Данные из файла:");
            string fileContent = File.ReadAllText(res);
            Console.WriteLine(fileContent);

            Console.ReadKey();
        }
    }
}