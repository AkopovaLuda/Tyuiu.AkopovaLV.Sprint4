using Tyuiu.AkopovaLV.Sprint4.Task1.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Акопова Л. В. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму четных   *");
        Console.WriteLine("* элементов массива. С клавиатуры: 1,7,6,3,2,5,7,6,7,6,5,4,7,6            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] array = new int[3];
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Console.WriteLine("Вбейте элемент " + (i + 1) + " из " + array.Length);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));
    }
}