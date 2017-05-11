using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TaskService.Models.Mapping
{
    public class IspolnitelMap : EntityTypeConfiguration<Ispolnitel>
    {
        public IspolnitelMap()
        {
            // Primary Key
            this.HasKey(t => t.idIspolnitel);

            // Properties
            this.Property(t => t.Name)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Ispolnitel");
            this.Property(t => t.idIspolnitel).HasColumnName("idIspolnitel");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
