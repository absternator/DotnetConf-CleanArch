using Autofac;
using DotnetConf._2022Edition.Core.Interfaces;
using DotnetConf._2022Edition.Core.Services;

namespace DotnetConf._2022Edition.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
