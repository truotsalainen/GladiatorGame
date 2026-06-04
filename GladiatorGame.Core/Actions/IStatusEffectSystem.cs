using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Actions;

public interface IStatusEffectSystem
{
    public void ApplyEffect(StatusEffectDefinition effect, int entityId);
    public void RemoveEffect(StatusEffectDefinition effect, int entityId);
    public void Tick (int entityId);
    public ICommand? EvaluateGate (ICommand command, GateType gate);
    public IEnumerable<StatusEffectDefinition> GetActiveEffects(int entityId);
}