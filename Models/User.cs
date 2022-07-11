using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MonsterHunterWeaponsAPI.Models
{
  public class User : BaseModel
  {
    public string? Email { get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }

    public ICollection<Weapon>? Weapons;

    public User()
    {
      Weapons = new Collection<Weapon>();
    }

  }
}