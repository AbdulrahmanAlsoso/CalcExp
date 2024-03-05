using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalcExp.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasData(DefaultData());

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(256);
        }

        private List<User> DefaultData()
        {
            return new List<User>{
              new User("Abdulrahman_140141","Abdulrahman_140141"){Id = 1} 
            };
        }
    }


}
