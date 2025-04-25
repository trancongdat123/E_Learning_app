using Microsoft.EntityFrameworkCore;
using E_Learning_API.Models;

namespace E_Learning_API.Data
{
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOption<ApplicationDbContext> options) : base(options){ }

        public DbSet<User> Users { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
        }
        
    }
}