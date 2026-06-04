using GladiatorGame.Core.Common;

namespace GladiatorGame.Core;

public interface IEntity
{
    int Id { get; }
    
    bool HasComponent <T>() where T : IComponent;
    T GetComponent<T>() where T : IComponent;
}