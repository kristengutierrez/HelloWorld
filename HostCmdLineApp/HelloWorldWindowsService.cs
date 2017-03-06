using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceProcess;

namespace HostCmdLineApp
{
    public class HelloWorldWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;

        public HelloWorldWindowsService()
        {
            ServiceName = "HelloWorldService";
        }

        public static void Main()
        {
            ServiceBase.Run(new HelloWorldWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(HelloWorldService.HelloWorldService), new Uri("http://localhost:4289/HostCmdLineApp/HelloWorldService.svc"));

            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
