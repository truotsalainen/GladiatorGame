using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Actions;

public record SkillRequirements(
    WeaponType? Weapon, 
    int? MinimumSkillLevel, 
    IEnumerable<AttributeRequirement> AttributeRequirements, 
    IEnumerable<EquipmentSlot> RequiredEquipment
    );