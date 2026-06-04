using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Actions;

public interface IActionExecutor
{
    public CommandResult ExecuteAction(ActionDefinition a, int sourceEntityId, int targetEntityId);
}