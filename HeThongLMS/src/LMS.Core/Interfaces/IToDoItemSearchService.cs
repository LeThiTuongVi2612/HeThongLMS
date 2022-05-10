using Ardalis.Result; 
using LMS.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync();
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(string searchString);
    }
}
