using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace LeetCode.Problems;

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class IsSubsequence392Benchmark : BaseBenchmark<IsSubsequence392>
{
    private string s = "abc", t = "ahbgdvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvc";
    
    [Benchmark(Baseline = true)]
    public bool IsSubsequence392() => CurrentProblemInstance.IsSubsequence(s, t);
    
    [Benchmark]
    public bool IsSubsequence392WithVar() => CurrentProblemInstance.IsSubsequenceWithVar(s, t);
    
    [Benchmark]
    public bool IsSubsequenceWithSpan() => CurrentProblemInstance.IsSubsequenceWithSpan(s, t);
}