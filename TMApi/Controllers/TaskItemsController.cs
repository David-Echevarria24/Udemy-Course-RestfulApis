using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMApi.Models;

namespace TMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private static List<TaskItem> TaskItems = new List<TaskItem>()
        {
            new TaskItem { Id = 1, Title = "Sample Task", Description = "This is a sample task item." },
            new TaskItem { Id = 2, Title = "Another Task", Description = "This is another task item." },
            new TaskItem { Id = 3, Title = "Third Task", Description = "This is the third task item." }
        };

        [HttpGet]
        public IEnumerable<TaskItem> Get()
        {
            return TaskItems;
        }

        [HttpPost]
        public void Post([FromBody] TaskItem taskItem)
        {
            TaskItems.Add(taskItem);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TaskItem taskItem)
        {
            var existingTaskItem = TaskItems.FirstOrDefault(t => t.Id == id);
            if (existingTaskItem != null)
            {
                existingTaskItem.Title = taskItem.Title;
                existingTaskItem.Description = taskItem.Description;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var existingTaskItem = TaskItems.FirstOrDefault(t => t.Id == id);
            if (existingTaskItem != null)
            {
                TaskItems.Remove(existingTaskItem);
            }
        }
    }
}
