using Nancy;

namespace WebUI.RouteModules
{
  public class RootRoutes : NancyModule
  {
    public RootRoutes()
    {
      Get["/"] = Index;
    }

    private dynamic Index(dynamic parameters)
    {
      return View["root/index"];
    }

  }
}