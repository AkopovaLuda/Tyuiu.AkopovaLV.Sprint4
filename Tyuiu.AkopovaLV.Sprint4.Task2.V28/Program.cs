using Tyuiu.AkopovaLV.Sprint4.Task2.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
        Console.WriteLine("* Задания #2                                                               *");
        Console.WriteLine("* Вариант #28                                                              *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                    *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный          *");
        Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных               *");
        Console.WriteLine("* элементов массива.                                                       *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Введите количество элементов в массиве");
        int len = Convert.ToInt32(Console.ReadLine());


        int[] numsArray = new int[len];

        for (int i = 0; i <= len - 1; i++)
        {
            numsArray[i] = rnd.Next(2, 8);
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.Write(numsArray[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("Сумма нечётных элементов массива: ");
        Console.WriteLine(ds.Calculate(numsArray));

        Console.ReadKey();
    }
}