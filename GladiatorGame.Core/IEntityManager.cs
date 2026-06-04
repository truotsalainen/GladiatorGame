using GladiatorGame.Core.Common;

namespace GladiatorGame.Core;

public interface IEntityManager
{
    public IEntity Create();
    public void Destroy(int id);
    public bool Exists(int id);


    bool HasComponent<T>(int id) where T : IComponent;
    void AddComponent<T>(int id, T component) where T : IComponent;
    void RemoveComponent<T>(int id) where T : IComponent;
    T GetComponent<T>(int id) where T : IComponent;


    IEnumerable<IEntity> GetAllWithComponent<T>() where T : IComponent;
    IEnumerable<IEntity> GetEntitiesAtPosition(Position position);
    IEntity GetEntityById(int id);
}