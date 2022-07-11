namespace MonsterHunterWeaponsAPI.Models
{
  public class Weapon : BaseModel
  {
    public enum Type
    {
      Unknown,
      GreatSword,
      SwordShield,
      DualSwords,
      LongSword,
      Hammer,
      HuntingHorn,
      Lance,
      GunLance,
      SwitchAxe,
      ChargeBlade,
      InsectGlaive,
      Bow,
      HeavyBowgun,
      Bowgun
    }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Attack { get; set; }
    public Type WeaponType { get; set; } = Type.Unknown;

    public int UserId { get; set; }
    public User? User { get; set; }

  }
}
