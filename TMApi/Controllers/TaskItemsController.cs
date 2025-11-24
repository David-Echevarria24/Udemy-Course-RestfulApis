using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;
using TMApi.Data;
using TMApi.Interface;
using TMApi.Models;

namespace TMApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        private ITaskRepository taskRepository;

        public TaskItemsController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var taskItems = await taskRepository.GetAllTask();
            if (taskItems == null) 
            {
                return NotFound();
            }
            return Ok(taskItems);
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           
            var taskItem = await taskRepository.GetTaskById(id);
            if (taskItem == null) 
            {
                return NotFound();            
            }
            return Ok(taskItem);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TaskItem taskItem)
        {
            var isAdded = await taskRepository.AddTask(taskItem);
            if (isAdded)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return BadRequest("Something went wrong.");
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TaskItem taskItem)
        {
            var isUpdated = await taskRepository.UpdateTask(id, taskItem);
            if (isUpdated)
            {
                return Ok("Request has been updated.");
            }
            return BadRequest("Request was not completed.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
           var isDeleted =  await taskRepository.DeleteTask(id);
            if (isDeleted)
            {
                return Ok("Deletion was complete.");
            }
            return BadRequest("Could not complete deletion.");
        }
    }
}
