namespace GladiatorGame.Core.Actions;

public record StatusEffectDefinition(string ID, GateType GateType, int Duration, bool Stackable, EffectDefinition? TickEffect = null, string? ForceActionID = null);