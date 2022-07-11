using System;

namespace MonsterHunterWeaponsAPI.Models
{
  public class BaseModel
  {
    public int Id { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
  }
}