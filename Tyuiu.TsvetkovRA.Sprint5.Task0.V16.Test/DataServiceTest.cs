using Tyuiu.TsvetkovRA.Sprint5.Task0.V16.Lib;
namespace Tyuiu.TsvetkovRA.Sprint5.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Temp\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
           
            Assert.AreEqual(true, fileExists);
        }
    }
}
