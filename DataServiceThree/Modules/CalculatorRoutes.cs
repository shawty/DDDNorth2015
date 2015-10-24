using Nancy;

namespace DataServiceThree.Modules
{
  public class CalculatorRoutes : NancyModule
  {
    public CalculatorRoutes() : base("calculator")
    {
      Get["/addition/{src}/{operand}"] = Addition;
      Get["/subtraction/{src}/{operand}"] = Subtraction;
      Get["/multipication/{src}/{operand}"] = Multipication;
      Get["/division/{src}/{operand}"] = Division;
    }

    private dynamic Addition(dynamic parameters)
    {
      decimal source = parameters.src;
      decimal operand = parameters.operand;

      return Response.AsJson(new {Result = source + operand});
    }

    private dynamic Subtraction(dynamic parameters)
    {
      decimal source = parameters.src;
      decimal operand = parameters.operand;

      return Response.AsJson(new { Result = source - operand });
    }

    private dynamic Multipication(dynamic parameters)
    {
      decimal source = parameters.src;
      decimal operand = parameters.operand;

      return Response.AsJson(new { Result = source * operand });
    }

    private dynamic Division(dynamic parameters)
    {
      decimal source = parameters.src;
      decimal operand = parameters.operand;

      return Response.AsJson(new { Result = source / operand });
    }

  }
}
