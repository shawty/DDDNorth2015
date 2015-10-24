using Nancy;

namespace DataServiceTwo.Modules
{
  public class RootRoutes : NancyModule
  {
    public RootRoutes()
    {
      Get["/"] = Index;
      Get["/machineinfo"] = MachineInfo;
      Get["/userinfo"] = UserInfo;
    }

    private dynamic Index(dynamic parameters)
    {
      return Response.AsJson(new {ServiceName = "Service Two"});
    }

    private dynamic MachineInfo(dynamic parameters)
    {
      return Response.AsJson(new { MachineName = "lucinda-mobile", OperatingSystem = "Windows 7 (64bit)" });
    }

    private dynamic UserInfo(dynamic parameters)
    {
      return Response.AsJson(new { UserName = "shawty", Workgroup = "digisolutions" });
    }

  }
}
