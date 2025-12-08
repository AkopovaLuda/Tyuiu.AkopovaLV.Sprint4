using Tyuiu.AkopovaLV.Sprint4.Task4.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Random rad = new Random();
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("#* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и                     *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
        Console.WriteLine("* (массив): (False, False, True, True, False, False), при                 *");
        Console.WriteLine("* x = 3105, y = 275                                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] numsArray = new int[5, 5] {{5, 9, 6, 8, 5 },
                { 6, 6, 7, 3, 8 },
                { 4, 3, 9, 8, 7},
                {3, 3, 6, 7, 7},
                {8, 3, 8, 6, 6} };
        int[,] res = ds.Calculate(numsArray);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}