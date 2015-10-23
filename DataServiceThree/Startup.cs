using Owin;

namespace DataServiceOne
{
  class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.UseNancy();
    }

  }
}
