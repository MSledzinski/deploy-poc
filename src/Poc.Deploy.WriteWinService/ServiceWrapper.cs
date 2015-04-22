namespace Poc.Deploy.WriteWinServiceHost
{
    using System;
    using System.ServiceModel;

    using Poc.Deploy.WriteWinService;

    using Topshelf;

    public class ServiceWrapper
    {
        private ServiceHost commandServiceHost;
        private ServiceHost queryServiceHandler;

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
            if (commandServiceHost != null)
            {
                commandServiceHost.Close();
            }

            if (queryServiceHandler != null)
            {
                queryServiceHandler.Close();
            }

            commandServiceHost = new ServiceHost(typeof(EmploymentCommandsHandleService));
            commandServiceHost.Open();

            queryServiceHandler = new ServiceHost(typeof(EmploymentQueryHandleService));
            queryServiceHandler.Open();
        }

        private void OnStopInternal()
        {
            if (commandServiceHost != null)
            {
                commandServiceHost.Close();
                commandServiceHost = null;
            }

            if (queryServiceHandler != null)
            {
                queryServiceHandler.Close();
                queryServiceHandler = null;
            }
        }
    }
}