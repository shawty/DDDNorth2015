using DataServiceOne.Models;
using DataServiceOne.Services;
using Nancy;

namespace DataServiceOne.Modules
{
  public class RootRoutes : NancyModule
  {
    private EmployeeData _employeeData;

    public RootRoutes(EmployeeData employeeData)
    {
      _employeeData = employeeData;
      Get["/"] = Index;
      Get["/{id}"] = GetSingle;
    }

    private dynamic Index(dynamic paramaters)
    {
      return Response.AsJson(_employeeData.GetAll());
    }

    private dynamic GetSingle(dynamic parameters)
    {
      Employee result = _employeeData.GetSingle(parameters.id);
      return result == null ? 404 : Response.AsJson(result);
    }

  }
}
