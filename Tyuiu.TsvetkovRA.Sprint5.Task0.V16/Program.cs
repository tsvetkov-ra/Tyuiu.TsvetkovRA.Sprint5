using Tyuiu.TsvetkovRA.Sprint5.Task0.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Работа с файлами                                                  *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Цветков Роман Андреевич     | ИИПб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                *");
        Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
        Console.WriteLine("***************************************************************************");

        DataService dataService = new DataService();
        Console.WriteLine($"Файл записан: {dataService.SaveToFileTextData(3)}");
        Console.ReadKey();
    }
}