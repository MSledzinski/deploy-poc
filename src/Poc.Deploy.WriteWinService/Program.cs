using Topshelf.Common.Logging;

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
                        
                        configurator.UseCommonLogging();

                            configurator.Service<ServiceWrapper>(
                                callback =>
                                    {
                                   
                                        callback.ConstructUsing(s => new ServiceWrapper());
                                        callback.WhenStarted(s => s.Start());
                                        callback.WhenStopped(s => s.Stop());
                                    });

                       // configurator.RunAs("ServiceRunner", "FPPassword1234");

                          //  configurator.SetDisplayName("EmploymentWcfService");
                          //  configurator.SetServiceName("EmpService");
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
