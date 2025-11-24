using Microsoft.AspNetCore.Mvc.ViewFeatures;
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

        public async Task<IEnumerable<TaskItem>> GetAllTask()
        {
            return await dbContext.TaskItems.ToListAsync();
        }

        public async Task<TaskItem> GetTaskById(int id)
        {
            return await dbContext.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<bool> AddTask(TaskItem taskItem)
        {
            try
            {
                await dbContext.TaskItems.AddAsync(taskItem);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch 
            {

                return false;
            }

            
        }

        public async  Task<bool> UpdateTask(int id, TaskItem taskItem)
        {


            try
            {
                var existingTaskItem = await dbContext.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
                if (existingTaskItem != null)
                {
                    existingTaskItem.Title = taskItem.Title;
                    existingTaskItem.Description = taskItem.Description;
                    await dbContext.SaveChangesAsync();
                    return true;
                }
                else { return false; }
            }
            catch
            {

                return false;
            }
            
        }

        public async Task<bool> DeleteTask(int id)
        {


            try
            {
                var existingTaskItem = await dbContext.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
                if (existingTaskItem != null)
                {
                    dbContext.TaskItems.Remove(existingTaskItem);
                    await dbContext.SaveChangesAsync();
                    return true;
                }
                else { return false; }
            }
            catch 
            {

                return false;
            }
           
        }

    }
}
