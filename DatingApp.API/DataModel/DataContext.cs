using DatingApp.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.DataModel
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}