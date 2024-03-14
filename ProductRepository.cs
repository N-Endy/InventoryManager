public class ProductRepository : IProductRepository
{
    private readonly IProductUserInteraction _productUserInteraction;
    private readonly List<Product> _products = new();

    public ProductRepository(IProductUserInteraction userInterface)
    {
        _productUserInteraction = userInterface;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void RemoveProduct(string productId)
    {
        var productToRemove = _products.FirstOrDefault(p => p.ProductId == productId);
        if (productToRemove != null)
            _products.Remove(productToRemove);
        else
            _productUserInteraction.ShowMessage("Product does not exist.");
    }

    public void UpdateProduct(Product product)
    {
        var productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);

        if (productToUpdate != null)
        {
            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Price = product.Price;
            productToUpdate.Quantity = product.Quantity;
        }
        else
        {
            _productUserInteraction.ShowMessage("Product does not exist.");
        }
    }

    public void GetProductById(string productId)
    {
        var productIdToBeDisplayed = _products.FirstOrDefault(p => p.ProductId == productId);

        if (productIdToBeDisplayed != null)
            _productUserInteraction.PrintSingleProduct(productIdToBeDisplayed);
        else
            _productUserInteraction.ShowMessage("Product ID is not valid.");
    }

    public void GetAllProducts()
    {
        _productUserInteraction.PrintAllProducts(_products);
    }
}