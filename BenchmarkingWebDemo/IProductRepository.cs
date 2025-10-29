namespace BenchmarkingWebDemo;

public interface IProductRepository
{
    public Task<List<Product>> GetAllProducts();
    public Task<List<ProductOptimized>> GetAllProductsOptimized();
}

