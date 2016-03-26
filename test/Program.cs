using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bubbleSort;

namespace test
{
    class Program
    {
        private const int SIZE = 15;

        static void Main(string[] args)
        {
            int[] unsorted_array = new int[SIZE];

            Random rng = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                unsorted_array[i] = rng.Next(100);
                Console.Write(unsorted_array[i]);
                Console.Write(" ");
            }

            BubbleSorter sorter = new BubbleSorter();

            int[] sorted_array = sorter.Sort(unsorted_array);
            for (int i = 0; i < SIZE; i++)
            {
                if (sorted_array != null)
                {
                    Console.Write(sorted_array[i]);
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
