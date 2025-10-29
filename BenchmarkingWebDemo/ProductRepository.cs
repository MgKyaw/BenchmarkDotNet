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

    private List<Product> GetProductsInternal()
    {
        List<Product> products = new List<Product>();
        for (int i = 0; i < 1000; i++)
        {
            Product product = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Lenovo Legion",
                Category = "Laptop",
                Price = 3500
            };
        }
        return products;
    }

    private List<ProductOptimized>
    GetProductsOptimizedInternal()
    {
        List<ProductOptimized> products = new List<ProductOptimized>(1000);

        for (int i = 0; i < 1000; i++)
        {
            ProductOptimized product = new ProductOptimized
            {
                Id = i,
                Name = "Lenovo Legion",
                Category = 1,
                Price = 3500
            };
        }
        return products;
    }

}
