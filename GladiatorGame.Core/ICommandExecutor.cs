using GladiatorGame.Core.Common;

namespace GladiatorGame.Core;

public interface ICommandExecutor
{
    CommandResult ExecuteCommand(ICommand command);
}