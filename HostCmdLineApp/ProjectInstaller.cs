using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.ServiceModel;

namespace HostCmdLineApp
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;
        public ProjectInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            service = new ServiceInstaller();
            service.ServiceName = "HelloWorldService";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
