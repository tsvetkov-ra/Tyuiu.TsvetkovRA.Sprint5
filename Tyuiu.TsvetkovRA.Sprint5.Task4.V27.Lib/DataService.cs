using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TsvetkovRA.Sprint5.Task4.V27.Lib
{
    public class DataService : ISprint5Task4V27
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string strX = File.ReadAllText(path);
                string z = strX.Replace('.', ',');
                double x = (Convert.ToDouble(z));
                double y = (Math.Pow(x, 3) - 4 * x) / Math.Cos(x);
                return Math.Round(y,3);
            }
        }
    }
}