using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsvetkovRA.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            string[] a = File.ReadAllText(path).Replace(".", "").Split(", ");
            int s = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length == 4) s++;
            }

            return s;
        }
    }
}
