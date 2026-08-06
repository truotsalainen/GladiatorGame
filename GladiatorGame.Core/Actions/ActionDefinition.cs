namespace GladiatorGame.Core.Actions;

public record ActionDefinition(
    string ID, 
    string Name,
    string Description, 
    bool IsPassive,
    TargetType TargetType, 
    IEnumerable<EffectDefinition> Effects, 
    int TimeCost, 
    int StaminaCost,
    int Range,
    SkillRequirements? Requirements = null
    );