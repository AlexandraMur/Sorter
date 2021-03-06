﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace sorter
{
    class Server
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/Sorter/");
            ServiceHost selfHost = new ServiceHost(typeof(WCFSorter), baseAddress);

            try
            { 
                selfHost.AddServiceEndpoint(typeof(IWCFSorter), new WSHttpBinding(), "Sorter");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                selfHost.Close();
            }
            catch(CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
