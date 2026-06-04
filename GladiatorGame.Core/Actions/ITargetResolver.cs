using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Actions;

public interface ITargetResolver
{
    public IEnumerable<IEntity> GetValidTargets(int sourceEntityId, ActionDefinition action);
    public bool IsValidTarget(int sourceEntityId, int targetEntityId, ActionDefinition action);
}