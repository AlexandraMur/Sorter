using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace sorter
{
    [ServiceContract]
    public interface IWCFSorter
    {
        [OperationContract]
        int[] Sort(int[] array);
    }

    [DataContract]
    public class SorterFault
    {
        private string _message;

        public SorterFault(string message)
        {
            _message = message;
        }

        [DataMember]
        public string Message { get { return _message; } set { _message = value; } }
    }
}
