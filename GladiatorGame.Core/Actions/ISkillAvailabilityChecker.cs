using GladiatorGame.Core;

namespace GladiatorGame.Core.Actions;

public interface ISkillAvailabilityChecker
{
    public IEnumerable<ActionDefinition> GetAvailableActions(IEntity entity);
    public bool IsSkillUsable(IEntity entity, ActionDefinition action);
}