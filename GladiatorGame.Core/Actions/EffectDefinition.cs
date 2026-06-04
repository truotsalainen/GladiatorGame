using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Actions;

public record EffectDefinition(EffectType EffectType, string? Formula = null, DamageType? DamageType = null, string? StatusId = null, int? Duration = null);