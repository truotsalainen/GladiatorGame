using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Progression;

public interface IProgressionSystem
{
    public void AddXP(int entityId, int amount);
    public bool ReadyToLevelUp(int entityId);
    public void LevelUp(int entityId);
    public void AllocateAttributePoint(int entityId, AttributeType attribute);
    public void AddWeaponXP(int entityId, WeaponType weapon, int amount);
    public void LevelWeaponSkill(int entityId, WeaponType weapon);

    public int GetCurrentXp(int entityId);
    public int GetCurrentLevel(int entityId);
    public int GetCurrentWeaponXp(int entityId, WeaponType weapon);
    public int GetCurrentWeaponLevel(int entityId, WeaponType weapon);
    public int GetUnspentAttributePoints(int entityId);

}