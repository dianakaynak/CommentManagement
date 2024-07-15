using Core.Entities;
using Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess.Contexts;

public class CommentManagementContext : DbContext
{
    protected IConfiguration Configuration { get; set; }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }  
    public DbSet<User> Users { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Comment> Comments { get; set; }



    public CommentManagementContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}