namespace Poc.Deploy.WriteWinServiceHost
{
    using System;
    using System.ServiceModel;

    using Poc.Deploy.WriteWinService;

    using Topshelf;

    public class ServiceWrapper
    {
        private ServiceHost serviceHost;

        public bool Start()
        {
            OnStartInternal();
            return true;
        }

        public bool Stop()
        {
            OnStopInternal();
            return true;
        }

        private void OnStartInternal()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(EmploymentCommandsHandleService));
        }

        private void OnStopInternal()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }

        }
    }
}