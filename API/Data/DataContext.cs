using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext
  {
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Course> Courses => Set<Course>();

    public DataContext(DbContextOptions options) : base(options)
    {
    }
  }
}