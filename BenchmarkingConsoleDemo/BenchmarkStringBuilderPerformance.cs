using BenchmarkDotNet.Attributes;

namespace BenchmarkingConsoleDemo;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class BenchmarkStringBuilderPerformance
{
    const string message = "Some text for testing purposes only.";
    const int CTR = 10000;
}
