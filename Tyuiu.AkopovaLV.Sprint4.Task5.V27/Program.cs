using Tyuiu.AkopovaLV.Sprint4.Task5.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("#* Спринт #4                                                              *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Условие:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* случайными значениями в диапазоне от -5 до 7. Найти количество          *");
        Console.WriteLine("* отрицательных элементов.                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Введите количество строк массива: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов массива: ");
        int coms = Convert.ToInt32(Console.ReadLine());

        int[,] m = new int[rows, coms];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < coms; j++)
            {
                m[i, j] = rnd.Next(-5, 7);
            }
        }

        Console.WriteLine("\nМассив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < coms; j++)
            {
                Console.Write($"{m[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("РЕЗУЛЬТАТ: ");
        int r = ds.Calculate(m);
        Console.WriteLine("Количество отрицательных значений в массиве - " + r);
        Console.ReadKey();
    }
}