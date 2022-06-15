namespace MonsterHunterWeaponsAPI.Domain.Models
{
    public class Weapon
    {
        public enum Type {
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
        public Type WeaponType { get; set; }

    }
}
