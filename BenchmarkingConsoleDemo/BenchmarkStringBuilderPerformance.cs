using BenchmarkDotNet.Attributes;
using System.Text;

namespace BenchmarkingConsoleDemo;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class
BenchmarkStringBuilderPerformance
{
    const string message = "Some text for testing purposes only.";
    const int CTR = 10000;

    [Benchmark]
    public void WithoutStringBuilderCache()
    {
        for (int i = 0; i < CTR; i++)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(message);
            _ = stringBuilder.ToString();
        }
    }

    [Benchmark]
    public void WithStringBuilderCache()
    {
        //for (int i = 0; i < CTR; i++)
        //{
        //    var stringBuilder = StringBuilderCache.Acquire();
        //    stringBuilder.Append(message);
        //    _ = StringBuilderCache.GetStringAndRelease(stringBuilder);
        //}
    }
}
