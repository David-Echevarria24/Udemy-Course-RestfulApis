using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TMApi.Models;

namespace TMApi.Interface
{
    public interface ITaskRepository
    {
        //Get all task items
         Task<IEnumerable<TaskItem>> GetAllTask();

        // Get a task item by id
        Task<TaskItem> GetTaskById(int id);

        // Add a new task item
        Task AddTask(TaskItem taskItem);

        // Update an existing task item
        Task UpdateTask(int id, TaskItem taskItem);

        // Delete a task item by id
        Task DeleteTask(int id);

    }
}
