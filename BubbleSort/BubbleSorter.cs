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
            Console.WriteLine("Bubble Sorter");
            return null;
        }
    }
}
