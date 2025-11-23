using Microsoft.EntityFrameworkCore;
using TMApi.Models;

namespace TMApi.Data
{
    public class ApiDbContext : DbContext 
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {
            
        }


        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
