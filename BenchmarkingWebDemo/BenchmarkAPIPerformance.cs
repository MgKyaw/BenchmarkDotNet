using Microsoft.AspNetCore.Mvc.Testing;

namespace BenchmarkingWebDemo;

public class BenchmarkAPIPerformance
{
    private static HttpClient _httpClient;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var factory = new WebApplicationFactory
        <Startup>().WithWebHostBuilder(configuration =>
        {
            configuration.ConfigureLogging(logging =>
            {
                logging.ClearProviders();
            });
        });

        _httpClient = factory.CreateClient();
    }

    [Benchmark]
    public async Task GetResponseTime()
    {
        var response = await _httpClient.GetAsync("/");
    }
}

