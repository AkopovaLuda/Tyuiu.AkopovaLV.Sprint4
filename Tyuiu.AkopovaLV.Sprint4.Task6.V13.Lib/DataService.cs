using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkopovaLV.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            string[] num = Array.FindAll(array, car => car.Length > 4);
            return num.Length;
        }
    }
}
