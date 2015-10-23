using Topshelf;

namespace DataServiceOne
{
  class Program
  {
    static int Main()
    {
      var exitCode = HostFactory.Run(host =>
      {
        host.Service<ServiceKernel>(service =>
        {
          service.ConstructUsing(() => new ServiceKernel());
          service.WhenStarted(kernel => kernel.StartService());
          service.WhenStopped(kernel => kernel.StopService());
        });
        host.SetDisplayName("Demo Data Service Three");
        host.SetServiceName("DataServiceThree");
        host.SetDescription("Demonstration .NET service using Nancy/Owin & Topshelf for Microservices talk at DDDNorth 2015.");
        host.RunAsNetworkService();
        host.StartAutomaticallyDelayed();
      });

      return (int)exitCode;

    }

  }
}
