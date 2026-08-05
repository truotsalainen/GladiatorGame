using GladiatorGame.Core.Common;

namespace GladiatorGame.Core.Actions;

public interface IActionExecutor
{
    public CommandResult ExecuteAction(ActionDefinition action, int sourceEntityId, int targetEntityId);
}