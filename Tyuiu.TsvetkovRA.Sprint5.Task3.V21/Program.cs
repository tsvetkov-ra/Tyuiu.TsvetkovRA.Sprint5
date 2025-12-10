using Tyuiu.TsvetkovRA.Sprint5.Task3.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #5                                                              *");
        Console.WriteLine("* Тема: Создания итогого решения по спринту                              *");
        Console.WriteLine("* Задание #3                                                             *");
        Console.WriteLine("* Вариант #21                                                            *");
        Console.WriteLine("* Выполнил: Цветков Роман Андреевич  | ИИПб-25-1                         *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        DataService ds = new DataService();
        int x = 3;
        Console.WriteLine("x = " + x);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}