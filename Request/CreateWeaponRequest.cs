using MonsterHunterWeaponsAPI.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace MonsterHunterWeaponsAPI.Request
{
    //public class CreateWeaponRequest: IValidatableObject
    public class CreateWeaponRequest
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MinLength(50)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(0,1000)]
        public int Attack { get; set; }
        [Required]
        [EnumDataType(typeof(Weapon.Type))]
        public Weapon.Type WeaponType { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
        //    if (Name == "fuuck") {
        //        yield return new ValidationResult(
        //         $"Invalid name!", new[] { nameof(Name) }
        //        );
        //    }
        //}
    }
}
