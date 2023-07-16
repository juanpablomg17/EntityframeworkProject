using efproject.Models;
using Microsoft.EntityFrameworkCore;

namespace efproject;

public class TasksContext : DbContext
{
    public DbSet<Category> categories { get; set; }
    public DbSet<TaskModel> tasks { get; set; }

    public TasksContext(DbContextOptions<TasksContext> options) : base(options) { }
}