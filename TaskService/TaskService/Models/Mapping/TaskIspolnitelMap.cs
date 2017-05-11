using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TaskService.Models.Mapping
{
    public class TaskIspolnitelMap : EntityTypeConfiguration<TaskIspolnitel>
    {
        public TaskIspolnitelMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TaskIspolnitel");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idTask).HasColumnName("idTask");
            this.Property(t => t.idIspolnitel).HasColumnName("idIspolnitel");

            // Relationships
            this.HasRequired(t => t.Ispolnitel)
                .WithMany(t => t.TaskIspolnitels)
                .HasForeignKey(d => d.idIspolnitel);
            this.HasRequired(t => t.Task)
                .WithMany(t => t.TaskIspolnitels)
                .HasForeignKey(d => d.idTask);

        }
    }
}
