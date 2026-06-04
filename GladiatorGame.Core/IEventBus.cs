using GladiatorGame.Core.Common;

namespace GladiatorGame.Core;

public interface IEventBus
{
    void Publish<T>(T gameEvent) where T : IGameEvent;
    void Subscribe<T>(Action<T> handler) where T : IGameEvent;
    void Unsubscribe<T>(Action<T> handler) where T : IGameEvent;
    void Dispatch();
}