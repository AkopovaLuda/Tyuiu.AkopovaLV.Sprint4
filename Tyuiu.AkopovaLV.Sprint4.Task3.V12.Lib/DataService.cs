using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkopovaLV.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int min = int.MaxValue;
            for (int i = 0;i< rows;i++)
            {
                for (int j = 0; j < rows; j++) 
                {
                    if (j == 2 && array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
    }
}
