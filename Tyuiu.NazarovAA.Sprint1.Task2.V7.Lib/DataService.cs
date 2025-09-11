using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarovAA.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task2V7
    {
        public double CalculateSquareCircle(int value)
        {
            return Math.Round(Math.PI * value * value, 3);
        }
    }
}
