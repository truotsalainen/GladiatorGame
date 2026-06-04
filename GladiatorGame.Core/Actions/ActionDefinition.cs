namespace GladiatorGame.Core.Actions;

public record ActionDefinition(string ID, string Name, TargetType TargetType, IEnumerable<EffectDefinition> Effects, int TimeCost, int Range);