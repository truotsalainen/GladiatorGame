namespace GladiatorGame.Core.Common;

public interface ICommand
{
    int EntityId { get; }
    int TimeCost { get; }
    string CommandType { get; }

}