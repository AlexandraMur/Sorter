using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isorter;

namespace insertionSort
{
    public class Bindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ISorter>().To<InsertionSorter>();
        }
    }

    public class InsertionSorter : ISorter
    {
        public int[] Sort(int[] array)
        {
            Console.WriteLine("Insertion Sort");

            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;

                    }
                    j--;
                }
            }
            return array;
        }
    }
}
