using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using isorter;
using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Xml;
using Ninject.Extensions.Xml.Processors;

namespace sorter
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WCFSorter : IWCFSorter
    {
        ISorter sorter;

        public WCFSorter()
        {
            try
            {
                string[] type_of_sorter = System.IO.File.ReadAllLines(@"Sorter.txt");
                var kernel = new Ninject.StandardKernel();
                kernel.Load(type_of_sorter[0]);
                sorter = kernel.Get<ISorter>();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.ReadLine();
            }
        }

        public int[] Sort(int[] array)
        {
            return sorter.Sort(array);
        }
    }
}
