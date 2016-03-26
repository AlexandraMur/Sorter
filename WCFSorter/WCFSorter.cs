using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ninject;
using Ninject.Modules;
using Ninject.Extensions.Xml;
using Ninject.Extensions.Xml.Processors;

namespace sorter
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WCFSorter : IWCFSorter
    {
        public int[] Sort(int[] array)
        {
            try
            {
                var kernel = new Ninject.StandardKernel();
                kernel.Load("BubbleSort.dll");
                IWCFSorter sorter = kernel.Get<IWCFSorter>();
                return sorter.Sort(array);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                System.Console.ReadLine();
                return null;
            }
        }
    }
}
