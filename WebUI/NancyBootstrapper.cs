using Nancy;
using Nancy.Conventions;

namespace WebUI
{
  public class NancyBootstrapper : DefaultNancyBootstrapper
  {
    protected override void ConfigureConventions(NancyConventions nancyConventions)
    {
      base.ConfigureConventions(nancyConventions);

      Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/scripts", @"scripts"));
      Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/styles", @"styles"));
      Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/images", @"images"));
      Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("/fonts", @"fonts"));

    }
  }
}