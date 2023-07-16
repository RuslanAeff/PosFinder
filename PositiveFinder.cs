using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, -5, 3, -2, 6, 9, -15, 11, 10 };

            Console.WriteLine("The numbers within the range of 1 to 11 are:");

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]%2 == 1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            
        }
    }
}
