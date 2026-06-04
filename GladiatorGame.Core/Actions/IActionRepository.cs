namespace GladiatorGame.Core.Actions;

public interface IActionRepository
{
    public ActionDefinition GetActionDefinition(string id);
    public IEnumerable<ActionDefinition> GetActionsForEntity(int entityId);
    public IEnumerable<ActionDefinition> GetAllActions();
}