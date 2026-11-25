using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.ZubkovaMG.Sprint5.Task0.V10.Lib;

namespace Tyuiu.ZubkovaMG.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(2);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists);
        }
    }
}