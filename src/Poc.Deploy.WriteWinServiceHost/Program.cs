namespace Poc.Deploy.WriteWinServiceHost
{
    using System;
    using System.Globalization;
    using System.Threading;

    using Poc.Deploy.WriteWinService;

    using Topshelf;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // for having excption messages in EN 
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

                var host = HostFactory.New(
                    configurator =>
                        {
                            configurator.Service<ServiceWrapper>(
                                callback =>
                                    {
                                        callback.ConstructUsing(s => new ServiceWrapper());
                                        callback.WhenStarted(s => s.Start());
                                        callback.WhenStopped(s => s.Stop());
                                    });

                            configurator.SetDisplayName("EmploymentWcfService");
                            configurator.SetServiceName("EmploymentService");

                            configurator.RunAsLocalService();
                        });

                host.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
