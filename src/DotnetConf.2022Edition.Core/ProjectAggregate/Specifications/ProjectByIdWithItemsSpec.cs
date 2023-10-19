using Ardalis.Specification;
using DotnetConf._2022Edition.Core.ProjectAggregate;

namespace DotnetConf._2022Edition.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
{
  public ProjectByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
