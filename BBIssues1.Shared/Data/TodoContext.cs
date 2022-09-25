using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBIssues1.Shared.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseLazyLoadingProxies()
            .UseInMemoryDatabase("TodoItems");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(new TodoItem { Id = 1, IsComplete = true, Name = "Tony", Secret = String.Empty });
        }
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
