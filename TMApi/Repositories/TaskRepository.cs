using Microsoft.EntityFrameworkCore;
using TMApi.Data;
using TMApi.Interface;
using TMApi.Models;

namespace TMApi.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private ApiDbContext dbContext;

        public TaskRepository(ApiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TaskItem> GetTaskById(int id)
        {
            return await dbContext.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task AddTask(TaskItem taskItem)
        {
            await dbContext.TaskItems.AddAsync(taskItem);
            await dbContext.SaveChangesAsync();
        }

        public async  Task UpdateTask(int id, TaskItem taskItem)
        {
            var existingTaskItem = await dbContext.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
            if (existingTaskItem != null)
            {
                existingTaskItem.Title = taskItem.Title;
                existingTaskItem.Description = taskItem.Description;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteTask(int id)
        {
            var existingTaskItem = await dbContext.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
            if (existingTaskItem != null)
            {
                dbContext.TaskItems.Remove(existingTaskItem);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<TaskItem>> GetAllTask()
        {
            return await dbContext.TaskItems.ToListAsync();
        }
    }
}
