using System.IO;
using Tyuiu.ZubkovaMG.Sprint5.Task1.V22.Lib;

namespace Tyuiu.ZubkovaMG.Sprint5.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #5 | Выполнила: Зубкова М. Г. | ИСПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Зубкова Мария Геннадьевна | ИСПб-26-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Дана функция F(x) на диапазоне [-5; 5] с шагом 1.                         *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении вернуть 0.             *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask1.txt и вывести в таблицу.       *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("+----------+------------+");
            Console.WriteLine("|    X     |    F(x)    |");
            Console.WriteLine("+----------+------------+");

            string[] lines = File.ReadAllLines(res);
            int currentX = startValue;
            foreach (string line in lines)
            {
                Console.WriteLine($"| {currentX,8} | {line,10} |");
                currentX++;
            }
            Console.WriteLine("+----------+------------+");

            Console.WriteLine("");
            Console.WriteLine("Файл сохранен по пути: ");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}