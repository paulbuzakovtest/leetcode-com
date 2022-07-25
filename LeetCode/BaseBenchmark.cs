namespace LeetCode;

public abstract class BaseBenchmark<TProblem>
    where TProblem : IProblem, new()
{
    protected static readonly TProblem CurrentProblemInstance = new TProblem();
}