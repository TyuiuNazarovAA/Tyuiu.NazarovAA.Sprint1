using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NazarovAA.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string[] values = value.Split();
            string result = "";
            foreach (var val in values)
            {
                if (val.Length % 2 == 1)
                    result += val[..(val.Length / 2)] + val[((val.Length / 2) + 1)..];
                else
                    result += val;
                result += " ";
            }
            return result[..(result.Length - 1)];
        }
    }
}
