using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloWorldService
{
    /// <summary>
    /// MSCS 6391 701 Topics in Math, Sts & Comp Sci
    /// Service-Oriented Architecture (SOA)
    /// Spring 2017
    /// Kristen Kozmary
    /// 
    /// Description: Building a simple HelloWorld WCF service.
    /// *code taken from 'WCF Multi-layer Services Development with Entity Framework' by Mike Liu
    /// </summary>

    [ServiceContract]
    public interface IHelloWorldService
    { 
        [OperationContract]
        string GetMessage(string name);
    }
}
