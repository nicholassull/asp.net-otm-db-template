using Microsoft.EntityFrameworkCore;
//Change to Project name
namespace FriendLetter.Models
{
  //Change to Project name
  public class FriendLetterContext : DbContext
  {
    //Change to class the DB is dealing with
    public DbSet<Item> Items { get; set; }
    //Change to Project name
    public FriendLetterContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}