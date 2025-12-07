using Tyuiu.AkopovaLV.Sprint4.Task3.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема:   двумерные массивы (статический ввод)                            *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найдите минимальный элемент третьем столбце массива.                    *");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Массив:");
        int[,] num = new int[5, 5] { { 9, 7, 4, 9, 7 },
                                          { 5, 2, 5, 7, 6 },
                                          { 8, 3, 3, 5, 7 },
                                          { 8, 4, 2, 4, 5 },
                                          { 8, 8, 9, 5, 6 } };
        int rows = num.GetUpperBound(0) + 1;
        int columns = num.Length / rows;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{num[i, j]}\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(num);
        Console.WriteLine("Минимальный элемент в третьем столбце = " + res);
    }
}