﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.sorter;

namespace Client
{
    class Client
    {
        private const int SIZE = 15;

        static void Main(string[] args)
        {
            WCFSorterClient client = new WCFSorterClient();

            int[] unsorted_array = new int[SIZE];

            Random rng = new Random();
            for (int i = 0; i < SIZE; i++) 
            { 
                unsorted_array[i] = rng.Next(100);
                Console.Write(unsorted_array[i]);
                Console.Write(" ");
            }

            Console.WriteLine();

            int[] sorted_array = client.Sort(unsorted_array);
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write(sorted_array[i]);
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
