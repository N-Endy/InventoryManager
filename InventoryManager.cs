public class InventoryManager
{
    private readonly IProductRepository _productRepository;
    private readonly IProductUserInteraction _userInteraction;

    public InventoryManager(IProductRepository productRepository, IProductUserInteraction userInteraction)
    {
        _productRepository = productRepository;
        _userInteraction = userInteraction;
    }

    public void AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
        _userInteraction.ShowMessage("\nProduct added successfully");
    }

    public void RemoveProduct(string productId)
    {
        _productRepository.RemoveProduct(productId);
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }

    public void GetAllProducts()
    {
        _productRepository.GetAllProducts();
    }

    public Product GetProductById(string productId)
    {
        return _productRepository.GetProductById(productId);
    }
}