using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Mvc.Testing;

namespace BenchmarkingWebDemo;

[MemoryDiagnoser]
public class BenchmarkAPIPerformance
{
    private static HttpClient _httpClient;

    [Params(1, 25, 50)]
    public int N;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var factory = new WebApplicationFactory<Program>() // Use Program, not Startup
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureLogging(logging =>
                {
                    logging.ClearProviders(); // Disable logging
                });
            });

        _httpClient = factory.CreateClient();
    }

    [Benchmark]
    public async Task GetProducts()
    {
        for (int i = 0; i < N; i++)
        {
            var response = await _httpClient.GetAsync("/GetProducts");
        }
    }

    [Benchmark]
    public async Task GetProductsOptimized()
    {
        for (int i = 0; i < N; i++)
        {
            var response = await _httpClient.GetAsync("/GetProductsOptimized");
        }
    }
}

