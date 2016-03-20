using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Ninject;
using iwcfsorter;

namespace wcfsorter
{
    public class WCFSorter : IWCFSorter
    {
        public int[] Sort(int[] array)
        {
            try
            {
                var kernel = new Ninject.StandardKernel();
                kernel.Load("Sort.xml");
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
