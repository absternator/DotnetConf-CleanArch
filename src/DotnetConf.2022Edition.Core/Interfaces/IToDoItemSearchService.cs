using Ardalis.Result;
using DotnetConf._2022Edition.Core.ProjectAggregate;

namespace DotnetConf._2022Edition.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
