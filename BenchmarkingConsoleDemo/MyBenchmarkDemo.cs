using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Mvc.Testing;

[MemoryDiagnoser]
public class MyBenchmarkDemo
{
    private static HttpClient _httpClient;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var factory = new WebApplicationFactory<Startup>()
        .WithWebHostBuilder(configuration =>
        {
            configuration.ConfigureLogging(logging =>
            {
                logging.ClearProviders();
            });
        });

        _httpClient = factory.CreateClient();
    }

    [Benchmark]
    public void MyFirstBenchmarkMethod()
    {
        //Write your code here   
    }
    [Benchmark]
    public void MySecondBenchmarkMethod()
    {
        //Write your code here
    }
}
