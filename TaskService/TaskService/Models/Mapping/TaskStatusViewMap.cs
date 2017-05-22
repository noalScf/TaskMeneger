using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TaskService.Models.Mapping
{
    public class TaskStatusViewMap : EntityTypeConfiguration<TaskStatusView>
    {
        public TaskStatusViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.idTask, t.idTaskStatus, t.idStatus, t.Name });

            // Properties
            this.Property(t => t.idTask)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idTaskStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idStatus)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Date)
                .HasMaxLength(24);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TaskStatusView");
            this.Property(t => t.idTask).HasColumnName("idTask");
            this.Property(t => t.idTaskStatus).HasColumnName("idTaskStatus");
            this.Property(t => t.idStatus).HasColumnName("idStatus");
            this.Property(t => t.TextHeader).HasColumnName("TextHeader");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Komentarii).HasColumnName("Komentarii");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
