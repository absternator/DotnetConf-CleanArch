using DotnetConf._2022Edition.SharedKernel;

namespace DotnetConf._2022Edition.Core.ProjectAggregate.Events;

public class NewItemAddedEvent : DomainEventBase
{
  public ToDoItem NewItem { get; set; }
  public Project Project { get; set; }

  public NewItemAddedEvent(Project project,
      ToDoItem newItem)
  {
    Project = project;
    NewItem = newItem;
  }
}
