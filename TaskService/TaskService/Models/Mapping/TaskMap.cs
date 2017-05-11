using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TaskService.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<Task>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.idTask);

            // Properties
            // Table & Column Mappings
            this.ToTable("Task");
            this.Property(t => t.idTask).HasColumnName("idTask");
            this.Property(t => t.TextHeader).HasColumnName("TextHeader");
            this.Property(t => t.Text).HasColumnName("Text");
        }
    }
}
