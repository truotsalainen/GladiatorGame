namespace GladiatorGame.Core.Actions;

public interface IFormulaEvaluator
{
    public int CalculateEffect(string formula, int entityId);
}