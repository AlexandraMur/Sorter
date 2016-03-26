using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isorter;

namespace bubbleSort
{
    public class Bindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ISorter>().To<BubbleSorter>();
        }
    }

    public class BubbleSorter: ISorter
    {
        public int[] Sort(int[] array)
        {
            Console.WriteLine("Bubble Sort");

            int temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            return array;
        }
    }
}
