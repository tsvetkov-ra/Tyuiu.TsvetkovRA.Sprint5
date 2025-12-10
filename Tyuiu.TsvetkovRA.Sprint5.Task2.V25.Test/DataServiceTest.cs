using Tyuiu.TsvetkovRA.Sprint5.Task2.V25.Lib;
namespace Tyuiu.TsvetkovRA.Sprint5.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempPath();
            FileInfo ra = new FileInfo(path);
            bool fileEx = ra.Exists;
            Assert.AreEqual(true, fileEx);
        }
    }
}
