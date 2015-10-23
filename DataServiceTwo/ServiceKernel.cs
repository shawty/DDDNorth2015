using System;
using Microsoft.Owin.Hosting;

namespace DataServiceOne
{
  class ServiceKernel
  {
    private IDisposable _dataService;

    public void StartService()
    {
      _dataService = WebApp.Start<Startup>("http://localhost:7001");
    }

    public void StopService()
    {
      _dataService.Dispose();
    }

  }
}
