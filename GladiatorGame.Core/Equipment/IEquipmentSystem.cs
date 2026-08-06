using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Equipment;

public interface IEquipmentSystem
{
    public void EquipItem(int entityId, int itemId, EquipmentSlot slot);
    public void UnequipItem(int entityId, EquipmentSlot slot);
    public Dictionary<AttributeType,int> CalculateBonus(int entityId, int itemId, WeaponType weapon);
    
    public Dictionary<EquipmentSlot, int> GetAllEquipment(int entityId);
    public int? GetEquipmentBySlot(int entityId, EquipmentSlot slot);
}