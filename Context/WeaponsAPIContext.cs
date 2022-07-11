using Microsoft.EntityFrameworkCore;
using MonsterHunterWeaponsAPI.Models;

namespace MonsterHunterWeaponsAPI.Data;

public class WeaponsAPIContext : DbContext
{

  public DbSet<Weapon>? Weapons { get; set; }
  public DbSet<User>? Users { get; set; }

  public WeaponsAPIContext(DbContextOptions<WeaponsAPIContext> options) : base(options)
  { }

}

