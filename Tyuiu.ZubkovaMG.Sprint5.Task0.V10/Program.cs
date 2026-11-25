using System.IO;
using Tyuiu.ZubkovaMG.Sprint5.Task0.V10.Lib;

namespace Tyuiu.ZubkovaMG.Sprint5.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Зубкова М. Г. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Зубкова Мария | ИИПб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 1.6x^3 - 2.1x^2 + 7x, вычислить его значение      *");
            Console.WriteLine("* при x = 2, результат сохранить в текстовый файл OutPutFileTask0.txt     *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат из файла: " + File.ReadAllText(res));

            Console.ReadKey();
        }
    }
}