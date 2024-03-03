using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CalcExp.Data
{
    public class AppDBContext:DbContext
    {
        public DbSet<User> users {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                .Build();
            var constr = config.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
    }
}
