using Microsoft.EntityFrameworkCore;
// using System;
// using System.Diagnostics;
// using System.Threading.Tasks;
public class UserDbContext : DbContext
{
    #region Contructor
    public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
    {

    }
    #endregion

    #region Public properties
    public DbSet<User> User { get; set; }
    #endregion

    #region Overidden methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(GetProducts());
        base.OnModelCreating(modelBuilder);
    }
    #endregion


    #region Private methods
    private List<User> GetProducts()
    {
        return new List<User>
    {
        new User { Id = 1001, Name = "Alice", UserId= 1234, SSN="123-45-6789"},
        new User { Id = 1002, Name = "Bob", UserId= 1255, SSN="987-65-4321"},
        new User { Id = 1003, Name = "Charlie", UserId= 1278, SSN="456-78-9123"},
        
    };
    }
    #endregion
}