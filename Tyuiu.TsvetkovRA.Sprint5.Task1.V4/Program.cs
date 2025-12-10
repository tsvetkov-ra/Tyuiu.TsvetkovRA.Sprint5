using Tyuiu.TsvetkovRA.Sprint5.Task1.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Цветков Роман Андреевич | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция, на диапазоне[-5;5] с шагом 1.                             *");

        Console.WriteLine("*                                                                         *");
        int a = -5;
        int b = 5;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("StartValue = " + a);
        Console.WriteLine("StotValue = " + b);
        string res = ds.SaveToFileTextData(a, b);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Файл: " + res + " Создан!");
        Console.ReadKey();
    }
}