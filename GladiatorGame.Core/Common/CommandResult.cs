namespace GladiatorGame.Core.Common;

public record CommandResult(CommandType CommandType, bool Success, string? Reason = null);