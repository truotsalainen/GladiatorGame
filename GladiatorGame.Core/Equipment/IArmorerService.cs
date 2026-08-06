using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Equipment;

public interface IArmorerService
{
    public void RepairByAmount(int entityId, EquipmentSlot slot, int amount);
    public void RepairToFull(int entityId, EquipmentSlot slot);
    public void RepairAllToFull(int entityId);
}