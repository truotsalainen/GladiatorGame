using GladiatorGame.Core.Common;

namespace GladiatorGame.Core;

public interface IScheduler
{
    bool IsWaitingForInput { get; }

    void Enqueue(ICommand command);
    void ProcessNext();
    void PurgeCommandsById(int id);
    int GetNextActor();
}