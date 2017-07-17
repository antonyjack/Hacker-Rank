using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Solution
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Console.WriteLine(Calculate(arr));
        }

        static string Calculate(int[] array)
        {
            double totalLength = array.Length;
            double positive = 0, negative = 0, zero = 0;
            for (var i = 0; i < totalLength; i++)
            {
                if (array[i] > 0)
                    positive++;
                else if (array[i] < 0)
                    negative++;
                else
                    zero++;
            }
            List<double> obj = new List<double>()
            {
                positive/totalLength,
                negative/totalLength,
                zero/totalLength
            };
            return string.Join("\n", obj);
        }

    }
}
