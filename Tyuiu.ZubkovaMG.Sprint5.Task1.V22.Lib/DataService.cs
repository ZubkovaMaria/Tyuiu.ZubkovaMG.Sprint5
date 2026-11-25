using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.ZubkovaMG.Sprint5.Task1.V22.Lib;

namespace Tyuiu.ZubkovaMG.Sprint5.Task1.V22.Lib
{
    public class DataService : ISprint5Task1V22
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            // Очищаем файл перед записью
            File.WriteAllText(path, "");

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка на деление на ноль (2 - x == 0 при x = 2)
                if (2 - x == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                    y = Math.Round(y, 2);
                }

                if (x != stopValue)
                {
                    strY = y.ToString() + "\n";
                }
                else
                {
                    strY = y.ToString();
                }

                File.AppendAllText(path, strY);
            }

            return path;
        }
    }
}
