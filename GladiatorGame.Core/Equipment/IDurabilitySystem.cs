using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Equipment;

public interface IDurabilitySystem
{
    public bool ReduceDurability(int entityId, EquipmentSlot equipment, int amount);

    public Dictionary<EquipmentSlot, int> GetEquipmentDurability(int entityId);
    public int? GetDurabilityBySlot(int entityId, EquipmentSlot slot);
}