using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TaskService.Models.Mapping
{
    public class TaskStatuMap : EntityTypeConfiguration<TaskStatu>
    {
        public TaskStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.idTaskStatus);

            // Properties
            // Table & Column Mappings
            this.ToTable("TaskStatus");
            this.Property(t => t.idTaskStatus).HasColumnName("idTaskStatus");
            this.Property(t => t.idTask).HasColumnName("idTask");
            this.Property(t => t.idStatus).HasColumnName("idStatus");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Komentarii).HasColumnName("Komentarii");

            // Relationships
            this.HasRequired(t => t.Status)
                .WithMany(t => t.TaskStatus)
                .HasForeignKey(d => d.idStatus);
            this.HasRequired(t => t.Task)
                .WithMany(t => t.TaskStatus)
                .HasForeignKey(d => d.idTask);

        }
    }
}
