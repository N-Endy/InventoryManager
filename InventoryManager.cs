public class InventoryManager
{
    // List to hold all products that are in the inventory
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

    public void RemoveProduct(int productId)
    {
        _productRepository.RemoveProduct(productId);
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
        // var existingProduct = products.Find(p => p.ProductId == product.ProductId);

        // if (existingProduct != null)
        // {
        //     existingProduct.Name = product.Name;
        //     existingProduct.Description = product.Description;
        //     existingProduct.Price = product.Price;
        //     existingProduct.Quantity = product.Quantity;
        //     Console.WriteLine("Product Updated");
        // }
        // else
        // {
        //     Console.WriteLine("Product Not Updated because Product is not in the inventory");
        // }
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
        // foreach (var product in products)
        // {
        //     Console.WriteLine($"Product ID: {product.ProductId}");
        //     Console.WriteLine($"Name: {product.Name}");
        //     Console.WriteLine($"Description: {product.Description}");
        //     Console.WriteLine($"Price: {product.Price:C}");
        //     Console.WriteLine($"Quantity: {product.Quantity}");
        //     Console.WriteLine("-------------------------------------");
        // }
    }

    public Product GetProductById(int productId)
    {
        return _productRepository.GetProductById(productId);
        // var productToDisplay = products.Find(p => p.ProductId == productId);

        // if (productToDisplay != null)
        // {
        //     Console.WriteLine($"Name: {productToDisplay.Name}");
        //     Console.WriteLine($"Description: {productToDisplay.Description}");
        //     Console.WriteLine($"Price: {productToDisplay.Price:C}");
        //     Console.WriteLine($"Quantity: {productToDisplay.Quantity}");
        // }
        // else
        // {
        //     Console.WriteLine("Product Not Found");
        // }
    }
}