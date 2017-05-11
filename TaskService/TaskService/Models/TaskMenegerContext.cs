using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TaskService.Models.Mapping;

namespace TaskService.Models
{
    public partial class TaskMenegerContext : DbContext
    {
        static TaskMenegerContext()
        {
            Database.SetInitializer<TaskMenegerContext>(null);
        }

        public TaskMenegerContext()
            : base("Name=TaskMenegerContext")
        {
        }

        public DbSet<Ispolnitel> Ispolnitels { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskIspolnitel> TaskIspolnitels { get; set; }
        public DbSet<TaskStatu> TaskStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IspolnitelMap());
            modelBuilder.Configurations.Add(new StatusMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new TaskIspolnitelMap());
            modelBuilder.Configurations.Add(new TaskStatuMap());
        }
    }
}
