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
            Console.WriteLine("Insertion Sorter");
            return null;
        }
    }
}
