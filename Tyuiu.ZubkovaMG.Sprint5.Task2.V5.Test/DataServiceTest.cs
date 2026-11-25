using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZubkovaMG.Sprint5.Task2.V5.Lib;

namespace Tyuiu.ZubkovaMG.Sprint5.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[3, 3] { { 9, 6, 6 }, { 8, 7, 2 }, { 1, 7, 8 } };
            string path = ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}