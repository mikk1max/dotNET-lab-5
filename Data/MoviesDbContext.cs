using dotNET_lab_5.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNET_lab_5.Data;

public class MoviesDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public MoviesDbContext(DbContextOptions options) : base(options)
    {
    }
}