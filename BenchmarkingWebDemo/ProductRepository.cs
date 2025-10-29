namespace BenchmarkingWebDemo;

public class
ProductRepository : IProductRepository
{
    public Task<List<Product>> GetAllProducts()
    {
        return Task.FromResult(GetProductsInternal());
    }

    public Task<List<ProductOptimized>> GetAllProductsOptimized()
    {
        return Task.FromResult(GetProductsOptimizedInternal());
    }

}
